using System;
using System.Linq;
using System.Text;

namespace Timebox.Model
{
  class WorkPerDayReport : IReport
  {
    class Item
    {
      public int Duration { get; set; }
      public DateTime Started_At { get; set; }
    }

    public string Generate(params object[] args)
    {
      ITimeLog log = new TimeLog();
      StringBuilder sb = new StringBuilder(2000);
      var sql =
        @"select date(started_at) as started_at, sum(duration) as Duration
          from logentry 
          where started_at > @0
          group by started_at";

      var items = log.ExecuteQuery<Item>(sql, DateTime.Today.AddDays(-30));

      sb.AppendLine("   Date        Time    |-------------- 8h --------------|");
      sb.AppendLine("------------------------------------------------------------");
      foreach (var item in items)
      {
          
          sb.AppendFormat("{0, 10}. {1, 9}   {2}\r\n",
                          item.Started_At.ToShortDateString(),
                          item.Duration.AsHumanReadableDuration(),
                          item.Duration.AsBar());

      }
      return sb.ToString();
    }
  }
}