using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Timebox.Model;

namespace Timebox.Reports
{
  public abstract class ReportBase : IReport
  {
    private IList<object> m_data;
    private object m_currentGroup;

    public virtual string Name
    {
      get
      {
        var type = GetType();
        if (type.IsDefined(typeof(DescriptionAttribute), false))
        {
          var attr = (DescriptionAttribute) type.GetCustomAttributes(typeof(DescriptionAttribute), false)[0];
          return attr.Name;
        }

        var name = type.Name.Replace("Report", ""); // remove the 'Report' part from name
        return Regex.Replace(name, ".[A-Z]", m => m.ToString()[0] + " " + char.ToLower(m.ToString()[1]));
      }
    }

    public abstract string[] Columns { get; }
    public abstract IList<object> GetData(ITimeLog log);

    public virtual string Text
    {
      get
      {
        StringBuilder sb = new StringBuilder(10000);
        int[] widths = GetColumnWitdhs();
        if(Grouping == null) AddLine(sb, widths, Columns, null);
        foreach (var line in m_data) AddLine(sb, widths, line.ToReportEntries(GroupingName), line);
        return sb.ToString();
      }
    }

    void AddLine(StringBuilder sb, int[] widths, string[] values, object data)
    {
        if(Grouping != null && data != null)
        {
          object newGroup = Grouping(data);
          if(!newGroup.Equals(m_currentGroup))
          {
            if (sb.Length > 1) sb.AppendLine(); // if not first group, add an empty line between groups
            m_currentGroup = newGroup;
            sb.AppendLine(m_currentGroup.ToString());
          }
          sb.Append("  ");
        }

        for (int i = 0; i < values.Length; i++)
        {
          sb.AppendFormat(string.Format("{{0,-{0}}}  ", widths[i]), values[i]);  
        }
        sb.AppendLine();                                                
    }

    private int[] GetColumnWitdhs()
    {
      Dictionary<int, int> w = new Dictionary<int, int>(); // <col_idx, width>
      var reportColumns = Columns.Where(s => s != GroupingName).ToArray();
      for (int i = 0; i < reportColumns.Length; i++)
      {
        w[i] = Columns[i].Length;
      }

      foreach (var line in m_data)
      {
        var values = line.ToReportEntries(GroupingName);
        for (int i = 0; i < reportColumns.Length; i++)
        {
          if(values[i].Length > w[i])
            w[i] = values[i].Length;
        }
      }

      var arr = new int[reportColumns.Length];
      w.Values.CopyTo(arr, 0);
      return arr;
    }

    public virtual string Html
    {
      get { throw new NotImplementedException(); }
    }

    public virtual string CSV
    {
      get
      {
        StringBuilder sb = new StringBuilder(10000);
        sb.AppendLine(string.Join(";", Columns));
        foreach (var line in m_data) sb.AppendLine(string.Join(";", line.ToReportEntries(GroupingName)));
        return sb.ToString();
      }
    }

    public virtual Func<object, object> Grouping
    {
      get { return null; }
    }

    public virtual string GroupingName
    {
      get { return ""; }
    }

    public void Execute()
    {
      var log = new TimeLog();
      m_currentGroup = null;
      m_data = GetData(log);
    }
  }
}