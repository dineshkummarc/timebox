using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timebox.Model
{
  class WorkOverviewReport : IReport 
  {
    class Item
    {
      private string m_tasks;

      public DateTime Started_At { get; set;}
      public int Duration { get; set; }

      public string Tasks
      {
        get { return m_tasks; }
        set { m_tasks = value.Trim(',', ' ').Replace(", , ", ", "); }
      }

      public string Project_Name { get; set; }
    }

    public string Generate(params object[] args)
    {
      ITimeLog log = new TimeLog();
      StringBuilder sb = new StringBuilder(2000);
      var sql =
        @"select date(started_at) as started_at, sum(duration) as duration, group_concat(comment, "", "") 
          as tasks, max(project) as project_name from logentry 
          where started_at > @0 
          group by started_at, project 
          order by started_at desc";
      var items = log.ExecuteQuery<Item>(sql, Helpers.PreviousMonday());

      var results = items.GroupBy(i => i.Started_At);
      foreach (var result in results)
      {
        sb.AppendLine(result.Key.ToShortDateString());
        foreach (var item in result)
        {
          sb.AppendFormat("  {0, -20} {1, 10} {2}\r\n", item.Project_Name, item.Duration.AsHumanReadableDuration(), item.Tasks);  
        }
        sb.AppendLine("");
      }
      return sb.ToString();

    }
  }
}