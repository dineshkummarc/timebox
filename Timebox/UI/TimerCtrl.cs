using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timebox.Model;
using Timebox.UI;

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

      cmdToggleFrame.Click += (s, a) => ToggleFrame();
      lblTime.TimeboxExpired += (s, notify, stop) => OnTimeboxExpired(notify, stop);
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
        lblTime.Elapsed = (int)m_span.TotalSeconds;
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
        lblTime.SetTimebox(0, false, false);
        button1.ImageIndex = 3;
        timer1.Start();
      }

      m_start = DateTime.Now;
      m_active = !m_active;

      UpdateTimeboxCommands();
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
      ToggleFrame();
    }

    private void ToggleFrame()
    {
      var frm = ParentForm;
      if (frm.FormBorderStyle == FormBorderStyle.None)
        frm.FormBorderStyle = FormBorderStyle.FixedDialog;
      else
        frm.FormBorderStyle = FormBorderStyle.None;
    }

    private void OnTimeboxExpired(bool notify, bool stopOnEnd)
    {
      if(stopOnEnd && m_active)  // todo: duplicated from click handler - DRY
      {
        lblTime.BackColor = Color.MistyRose;
        timer1.Stop();
        button1.ImageIndex = 2;
        StoreEntry();     
        m_start = DateTime.Now;
        m_active = !m_active;
      }

      UpdateTimeboxCommands();

      if(notify)
        MessageBox.Show("Timebox for current task has expired" + stopOnEnd, "Timebox expired",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void cmdSetTimebox_Click(object sender, EventArgs e)
    {
      var frm = new TimeboxEditor();
      if(DialogResult.OK != frm.ShowDialog()) return;

      bool notify = frm.Notify;
      bool stop = frm.StopOnEnd;
      int duration = frm.Duration;

      lblTime.SetTimebox(duration, notify, stop);
      UpdateTimeboxCommands();
    }

    private void cmdRemoveTimebox_Click(object sender, EventArgs e)
    {
      lblTime.SetTimebox(0, false, false);
      UpdateTimeboxCommands();
    }

    private void UpdateTimeboxCommands()
    {
      cmdSetTimebox.Visible = m_active && !lblTime.HasTimebox;     // todo: unify cmd visibility
      cmdRemoveTimebox.Visible = m_active && lblTime.HasTimebox;
    }
  }
}
