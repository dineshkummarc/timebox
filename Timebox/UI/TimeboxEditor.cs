using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timebox.UI
{
  public partial class TimeboxEditor : Form
  {
    public TimeboxEditor()
    {
      InitializeComponent();
    }

    public bool Notify
    {
      get { return checkBox1.Checked; }
    }

    public int Duration 
    {
      get { return int.Parse(textBox1.Text) * 60; }
    }

    public bool StopOnEnd
    {
      get { return chkStopTask.Checked; }
    }

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        int.Parse(textBox1.Text);
        errorProvider1.SetError(textBox1, "");
        btnOK.Enabled = true;
      }
      catch (Exception)
      {
        errorProvider1.SetError(textBox1, "Must be a valid integer");
        e.Cancel = true;
        btnOK.Enabled = false;
      }
    }
  }
}
