using System;
using System.Collections.Generic;
using Timebox.Model;

namespace Timebox.Reports
{
  class DetailedWorkItem
  {
    [Description(Formatting = "d"), GroupedBy]
    public DateTime Started_At { get; set; }
    public string Project { get; set; }
    [Description("Time", Hidden = true)]
    public int Duration { get; set; }
    [Description("Time")]
    public string DurationText { get { return Duration.AsHumanReadableDurationFull(); } }
    public string Comment { get; set; }
  }


  [Description("Work tasks / day")]
  class DetailedWorkReport : ReportBase<DetailedWorkItem>
  {
    public override IList<DetailedWorkItem> GetReportLines(ITimeLog log)
    {
      var sql =
        @"select started_at, duration, project, comment
          from logentry 
          where started_at > @0
          order by started_at desc";

      return log.ExecuteQuery<DetailedWorkItem>(sql, DateTime.Today.AddDays(-30));
    }
  }
}