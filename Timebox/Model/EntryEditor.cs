using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timebox.Model
{
  public partial class EntryEditor : Form
  {
    public EntryEditor()
    {
      InitializeComponent();
    }

    internal EntryEditor(LogEntry entry)
    {
      InitializeComponent();

      txtProject.DataBindings.Add("Text", entry, "Project");
      txtComment.DataBindings.Add("Text", entry, "Comment");
      txtDuration.DataBindings.Add("Text", entry, "Duration");
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
