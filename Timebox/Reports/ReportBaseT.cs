using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Timebox.Model;

namespace Timebox.Reports
{
  public abstract class ReportBase<T> : ReportBase where T : class
  {
    public override string[] Columns
    {
      get
      {
        var props = typeof (T).PropertiesForReport();
        return props.Select(p => ColumnNameFor(p)).ToArray();       
      }
    }

    public override IList<object> GetData(ITimeLog log)
    {
        var data = GetReportLines(log);
        return data.Cast<object>().ToList();      
    }

    private static string ColumnNameFor(PropertyInfo property)
    {
      if (property.IsDefined(typeof(DescriptionAttribute), false))
      {
        var attr = (DescriptionAttribute) property.GetCustomAttributes(typeof(DescriptionAttribute), false)[0];
        if(!string.IsNullOrEmpty(attr.Name))
          return attr.Name;      
      }

      return property.Name;
    }

    public override Func<object, object> Grouping // todo: unify with GroupingName to return (name, predicate)
    {
      get
      {
        var groupProp = typeof(T).PropertiesForReport().FirstOrDefault(p => p.IsDefined(typeof(GroupedByAttribute), false));
        if(groupProp == null)
          return null;

        //return o => groupProp.GetValue(o, new object[]{});
        return o => groupProp.FormattedValue(o);;
      }
    }

    public override string GroupingName
    {
      get
      {
        var groupProp = typeof(T).PropertiesForReport().FirstOrDefault(p => p.IsDefined(typeof(GroupedByAttribute), false));
        if (groupProp == null)
          return "";

        return ColumnNameFor(groupProp);
      }
    }

    public abstract IList<T> GetReportLines(ITimeLog log);      
  }
}