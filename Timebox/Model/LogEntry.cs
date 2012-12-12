using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace Timebox.Model
{
  [TableName("LogEntry")]
  [PrimaryKey("Id", autoIncrement = true)]
  [ExplicitColumns]
  class LogEntry
  {
    private string m_comment;
    public LogEntry()
    {
      Project = "";
      Comment = "";
      StartedAt = DateTime.Now;
    }

    [Column]
    public int Id { get; set; }

    [Column("started_at")]
    public DateTime StartedAt { get; set; }

    [Column]
    public int Duration { get; set; }

    [Column]
    public string Project { get; set; }

    [Column]
    public string Comment
    {
      get { return m_comment ?? ""; }
      set { m_comment = (string.IsNullOrEmpty(value.Trim()) ? null : value); }
    }
  }
}
