using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timebox.Model;

namespace Timebox
{
  public partial class TimerCtrl : UserControl
  {
    private DateTime m_start;
    private TimeSpan m_span;
    private bool m_active = false;
    private ITimeLog m_log;

    public TimerCtrl()
    {
      InitializeComponent();

      m_log = new TimeLog();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if(DesignMode) return;

      var projects = m_log.GetAllProjects();
      cboProjects.Items.AddRange(projects.ToArray());
      if(projects.Count > 0)
      {
        cboProjects.SelectedIndex = 0;
      }
      cboProjects_TextChanged(this, EventArgs.Empty);           
    }

    

    private void StoreEntry()
    {
      var project = cboProjects.Text;
      var entry = new LogEntry()
                    {
                      Duration = (int)m_span.TotalSeconds, 
                      Project = project, 
                      Comment = txtComment.Text,
                      StartedAt = m_start
                    };

      m_log.AddEntry(entry);
      if(!cboProjects.Items.Contains(entry.Project))
      {
        cboProjects.Items.Add(entry.Project);  
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if(m_active)
      {
        m_span = DateTime.Now - m_start;
        var txt = string.Format("{0}:{1:00}:{2:00}", m_span.Hours, m_span.Minutes, m_span.Seconds);
        if(txt != lblTime.Text) lblTime.Text = txt;
      } 
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (m_active)
      {
        lblTime.BackColor = Color.MistyRose;
        timer1.Stop();
        button1.ImageIndex = 2;
        StoreEntry();         
      }
      else
      {
        lblTime.BackColor = Color.Honeydew;
        button1.ImageIndex = 3;
        timer1.Start();
      }

      m_start = DateTime.Now;
      m_active = !m_active;
    }

    private void cboProjects_TextChanged(object sender, EventArgs e)
    {
      bool hasText = cboProjects.Text.Trim().Length > 0;
      button1.Enabled = hasText;
      cboProjects.BackColor = hasText ? SystemColors.Window : Color.MistyRose;
    }

    public void Shutdown()
    {
      if(m_active)
      {
        m_active = false;
        StoreEntry();   
      }
    }

    private void lblTime_DoubleClick(object sender, EventArgs e)
    {
      var frm = ParentForm;
      if (frm.FormBorderStyle == FormBorderStyle.None)
        frm.FormBorderStyle = FormBorderStyle.FixedDialog;
      else
        frm.FormBorderStyle = FormBorderStyle.None;
    }
  }

  internal class SmoothLabel : Label
  {
    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
      base.OnPaint(e);
    }
  }
    
}
