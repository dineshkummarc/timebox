using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timebox.Model;

namespace Timebox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if(tabControl1.SelectedIndex == 0)
        Size = new Size(330, 200);
      else 
        Size = new Size(600, 450);

      if (tabControl1.SelectedIndex == 1)
        reportControl1.RefreshReport();

      tabControl1.Refresh();

    }

    protected override void OnClosing(CancelEventArgs e)
    {
      timerCtrl1.Shutdown();
    }

    public void Shutdown()
    {
      timerCtrl1.Shutdown();
    }
  }
}
