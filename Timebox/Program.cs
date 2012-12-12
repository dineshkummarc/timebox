using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Timebox
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Form1 frm = new Form1();
      Application.Run(frm);

      Application.ApplicationExit += (s, a) => frm.Shutdown();
    }
  }
}
