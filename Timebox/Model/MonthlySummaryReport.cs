using System;
using System.Linq;
using System.Text;

namespace Timebox.Model
{
  class MonthlySummaryReport : IReport
  {
    class Item
    {
      public int Duration { get; set; }
      public string Project_Name { get; set; }
      public DateTime Started_At { get; set; }
    }

    public string Generate(params object[] args)
    {
      ITimeLog log = new TimeLog();
      StringBuilder sb = new StringBuilder(2000);
      var sql =
        @"select strftime( '%Y-%m', started_at) as started_at, sum(duration) as duration, max(project) as project_name 
          from logentry 
          group by started_at, project";

      var dt = DateTime.Today.AddMonths(-6);
      var items = log.ExecuteQuery<Item>(sql, Helpers.BeginningOfMonth(dt));

      var results = items.GroupBy(i => i.Started_At);
      foreach (var result in results)
      {
        sb.AppendLine(result.Key.ToString("MMMM, yyyy."));

        var total = result.Sum(i => i.Duration);

        foreach (var item in result)
        {
          var percentage = (item.Duration * 100)/total;
          sb.AppendFormat("  {0, -16} {1, 9} {2,3}% {3}\r\n", 
            item.Project_Name, 
            item.Duration.AsHumanReadableDuration(),
            percentage,
            percentage.AsPercentageBar());
        }
        sb.AppendLine("");
      }
      return sb.ToString();
    }
  }
}