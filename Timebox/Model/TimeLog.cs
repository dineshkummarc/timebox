using System;
using System.Collections.Generic;
using System.Linq;

namespace Timebox.Model
{
  class TimeLog : ITimeLog
  {
    public void AddEntry(LogEntry entry)
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        db.Insert(entry);
      }           
    }

    public IList<string> GetAllProjects()
    {
      using(var db = new PetaPoco.Database("timeboxDb"))
      {
        var res = db.Fetch<string>("select distinct project from LogEntry order by started_at desc");
        return res;
      }     
    }

    public IList<LogEntry> GetEntriesSince(DateTime startDate)
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        var res = db.Fetch<LogEntry>("select * from LogEntry where started_at >= @0 order by started_at desc", startDate);
        return res;
      }
    }

    public void ResetDb()
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        var res = db.Execute("delete from LogEntry");
      }
    }

    public void Remove(LogEntry entry)
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        var res = db.Delete(entry);
      }
    }

    public void Update(LogEntry entry)
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        var res = db.Update(entry);
      }
    }

    public IList<T> ExecuteQuery<T>(string sql, params object[] args)
    {
      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        return db.Fetch<T>(sql, args);
      }
    }

    public LogEntry Merge(IList<LogEntry> entries, string desc)
    {
      var start = entries.OrderBy(e => e.StartedAt).First().StartedAt;
      var duration = entries.Sum(e => e.Duration);
      var project = entries[0].Project;

      using (var db = new PetaPoco.Database("timeboxDb"))
      {
        foreach (var e in entries)
        {
          db.Delete(e);
        }

        var entry = new LogEntry() {Project = project, Duration = duration, Comment = desc, StartedAt = start};
        db.Insert(entry);
        return entry;
      }              
    }
  }
}