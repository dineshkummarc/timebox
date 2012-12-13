using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timebox.Model;

namespace Timebox.UI
{
  public partial class MergeForm : Form
  {
    public MergeForm()
    {
      InitializeComponent();
    }

    internal MergeForm(IList<LogEntry> entries, string desc)
    {
      InitializeComponent();
      txtComment.Text = desc;
    }

    public string Description   
    {
      get { return txtComment.Text; } 
    }
  }
}
