using System;
using System.Collections.Generic;
using Timebox.Model;

namespace Timebox.Reports
{
  class WorkOverviewItem
  {
    private string m_tasks;

    [GroupedBy, Description(Formatting = "d")]
    public DateTime Started_At { get; set; }
    public string Project_Name { get; set; }
    [Description(Hidden = true)]
    public int Duration { get; set; }
    public string DurationText { get { return Duration.AsHumanReadableDurationFull(); } }
    public string Tasks
    {
      get { return m_tasks; }
      set { m_tasks = value.Trim(',', ' ').Replace(", , ", ", "); }
    }
  }

  class WorkOverviewReport : ReportBase<WorkOverviewItem> 
  {
    public override IList<WorkOverviewItem> GetReportLines(ITimeLog log)
    {
      var sql =
        @"select date(started_at) as started_at, sum(duration) as duration, group_concat(comment, "", "") 
          as tasks, max(project) as project_name from logentry 
          where started_at > @0 
          group by started_at, project 
          order by started_at desc";
      return log.ExecuteQuery<WorkOverviewItem>(sql, Helpers.PreviousMonday());      
    }
  }
}