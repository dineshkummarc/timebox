using System;
using System.Collections.Generic;

namespace Timebox.Model
{
  public interface ITimeLog
  {
    void AddEntry(LogEntry entry);
    IList<string> GetAllProjects();
    IList<LogEntry> GetEntriesSince(DateTime startDate);
    void ResetDb();
    void Remove(LogEntry entry);
    void Update(LogEntry entry);
    IList<T> ExecuteQuery<T>(string sql, params object[] args);
    LogEntry Merge(IList<LogEntry> entries, string desc);
  }
}