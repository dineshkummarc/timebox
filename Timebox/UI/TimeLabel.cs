using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Timebox.Model;

namespace Timebox
{
  internal class TimeLabel : Label
  {
    private int m_elapsed;
    private bool m_notify, m_timeboxExpired, m_stopOnEnd;
    private StringFormat m_fmt;
    
    public delegate void TimeboxExpiredHandler(object sender, bool alert, bool stopOnEnd);
    public event TimeboxExpiredHandler TimeboxExpired;

    Font m_timeboxFont = new Font("Calibri", 10);

    public TimeLabel()
    {
      TimeboxDuration = 0;
      m_fmt = new StringFormat(StringFormatFlags.NoWrap);
      m_fmt.Alignment = StringAlignment.Far;
      m_fmt.Trimming = StringTrimming.Character;
      m_fmt.LineAlignment = StringAlignment.Center;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if(TimeboxDuration > 0)
      {
        DrawTimeboxInfo(e.Graphics);
        DrawProgressBar(e.Graphics);
      }
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
      DrawElapsedTime(e.Graphics);
    }

    private void DrawProgressBar(Graphics graphics)
    {
      var w = Width;
      var thickness = 5;
      var top = Height - thickness;
      var done = 0;
      if(Elapsed >= TimeboxDuration)
        done = w;
      else
        done = (int) ((Elapsed / (float) TimeboxDuration) * w);
      var left = w - done;
      graphics.FillRectangle(Elapsed >= TimeboxDuration ? Brushes.Red : Brushes.DarkSlateBlue, 0, top, done, thickness);
      graphics.FillRectangle(Brushes.LightSteelBlue, done, top, left, thickness);
    }

    private void DrawElapsedTime(Graphics graphics)
    {
      var rc = ClientRectangle;
      rc.Offset(0, TimeboxDuration > 0 ? 3 : -1);
      TextRenderer.DrawText(graphics, Elapsed.AsHumanReadableDuration(), Font, rc, Color.Black,
        TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

    }

    private void DrawTimeboxInfo(Graphics graphics)
    {
      var tb = TimeboxDuration.AsHumanReadableDurationFull();
      tb = "BOX: " + tb.Substring(0, tb.Length - 4); // remove seconds part ( ':00s')
      graphics.DrawString(tb, m_timeboxFont, Brushes.Black, 2, -1);

      var left = TimeboxDuration - Elapsed;
      var el = left.AsHumanReadableDurationFull();
      var width = graphics.MeasureString(el, m_timeboxFont).Width;
      graphics.DrawString(el, m_timeboxFont, Brushes.Firebrick, Width - (width + 2), -1);

    }

    public void SetTimebox(int duration, bool notify, bool stopOnEnd)
    {
      TimeboxDuration = duration;
      m_notify = notify;
      m_stopOnEnd = stopOnEnd;
      m_timeboxExpired = false;
    }

    private int TimeboxDuration { get; set; }
    public bool HasTimebox { get { return TimeboxDuration > 0; } }

    public int Elapsed
    {
      get { return m_elapsed; }
      set 
      { 
        if(m_elapsed == value) return;
        m_elapsed = value;
        bool expiryChanged = m_timeboxExpired != m_elapsed >= TimeboxDuration;
        m_timeboxExpired = m_elapsed >= TimeboxDuration;
        Text = m_elapsed.AsHumanReadableDuration();
        if (m_timeboxExpired && expiryChanged && TimeboxExpired != null)
        {
          TimeboxExpired(this, m_notify, m_stopOnEnd);
        }
      }
    }
  }

}