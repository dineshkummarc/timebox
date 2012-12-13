using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timebox.Model;

namespace Timebox
{
  public partial class StatsControl : UserControl
  {
    Dictionary<string, IReport> m_reports = new Dictionary<string, IReport>();
    public StatsControl()
    {
      InitializeComponent();

      m_reports["Work Overview"] = new WorkOverviewReport();
      m_reports["Monthly Summary"] = new MonthlySummaryReport();
      m_reports["Effective Work / Day"] = new WorkPerDayReport();

      foreach (var pair in m_reports)
      {
        cboReports.Items.Add(pair.Key);
      }
      cboReports.SelectedIndex = 0;
    }

    void ProcessLogItemsSince(DateTime when, Action<LogEntry> action)
    {
      var log = new TimeLog();
      var entries = log.GetEntriesSince(when);
      foreach (var entry in entries) action(entry);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var report_key = cboReports.Text;
      var report = m_reports[report_key];
      textBox1.Text = report.Generate();
    }

    private void WorkOverviewReport()
    {
      var log = new TimeLog();
      
    }

    private void MonthlySummaryReport()
    {
      
    }


  }
}
