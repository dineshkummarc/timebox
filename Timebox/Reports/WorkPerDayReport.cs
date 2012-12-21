using System;
using System.Collections.Generic;
using Timebox.Model;

namespace Timebox.Reports
{
  class WorkPerDayItem
  {
    [Description("Date", Formatting = "d")]
    public DateTime Started_At { get; set; }
    [Description("Time", Hidden = true)]
    public int Duration { get; set; }
    [Description("Time")]
    public string DurationText { get { return Duration.AsHumanReadableDurationFull(); } }
    [Description("|-------------- 8h --------------|", Alignement = -1)]
    public string DurationBar { get { return " " + Duration.AsBar(); }  }

  }

  [Description("Effective Work / Day")]
  class WorkPerDayReport : ReportBase<WorkPerDayItem>
  {
    public override IList<WorkPerDayItem> GetReportLines(ITimeLog log)
    {
      var sql =
        @"select date(started_at) as started_at, sum(duration) as Duration
          from logentry 
          where started_at > @0
          group by started_at";

      return log.ExecuteQuery<WorkPerDayItem>(sql, DateTime.Today.AddDays(-30));
    }
  }
}