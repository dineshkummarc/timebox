using System;
using System.Collections.Generic;
using Timebox.Model;

namespace Timebox.Reports
{
  class MonthlySummaryItem
  {
    [GroupedBy, Description(Formatting = "MMMM, yyyy.")]
    public DateTime Started_At { get; set; }
    public string Project_Name { get; set; }
    [Description(Hidden = true)]
    public int Duration { get; set; }
    public string DurationText { get { return Duration.AsHumanReadableDurationFull(); } }
    public int Percentage { get; set; }
    public string PercentageText { get { return Percentage.AsPercentageBar(); } }
  }

  class MonthlySummaryReport : ReportBase<MonthlySummaryItem> 
  {
    public override IList<MonthlySummaryItem> GetReportLines(ITimeLog log)
    {
      var sql = @"select strftime( '%Y-%m', started_at) as started_at, sum(duration) as duration, max(project) as project_name 
          from logentry 
          group by started_at, project";

      var dt = DateTime.Today.AddMonths(-6);
      return log.ExecuteQuery<MonthlySummaryItem>(sql, Helpers.BeginningOfMonth(dt));
    }
  }
}