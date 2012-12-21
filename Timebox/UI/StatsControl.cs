using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Timebox.Model;
using Timebox.Reports;

namespace Timebox
{
  public partial class StatsControl : UserControl
  {
    Dictionary<string, IReport> m_reports = new Dictionary<string, IReport>();
    public StatsControl()
    {
      InitializeComponent();

      var rpts = Assembly.GetExecutingAssembly().GetTypes()
        .Where(t => typeof (IReport).IsAssignableFrom(t) && !t.IsAbstract);
      foreach (var rptType in rpts)
      {
        var rpt = Activator.CreateInstance(rptType) as IReport;
        m_reports[rpt.Name] = rpt;
      }
      /*
      m_reports["Work Overview"] = new WorkOverviewReport();
      m_reports["Monthly Summary"] = new MonthlySummaryReport();
      m_reports["Effective Work / Day"] = new WorkPerDayReport();  */

      foreach (var pair in m_reports)
      {
        cboReports.Items.Add(pair.Key);
      }
      cboReports.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var report_key = cboReports.Text;
      var report = m_reports[report_key];
      report.Execute();
      textBox1.Text = report.Text;
    }
  }
}
