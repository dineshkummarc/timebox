using System;
using System.Linq;
using System.Reflection;
using Timebox.Reports;

namespace Timebox.Model
{
  static class Helpers
  {
    public static string AsHumanReadableTime(this DateTime time)
    {
      return time.ToString("HH:mm");
    }

    public static string AsHumanReadableDuration(this int duration)
    {
      bool neg = Math.Sign(duration) < 0;
      duration = Math.Abs(duration);
      duration = Math.Abs(duration);
      int h = duration / 3600;
      int m = (duration % 3600) / 60;
      int s = (duration % 3600) % 60;

      return string.Format("{3}{0}:{1:00}:{2:00}", h, m, s, neg ? "-" : "");
    }
    public static string AsHumanReadableDurationFull(this int duration)
    {
      bool neg = Math.Sign(duration) < 0;
      duration = Math.Abs(duration);
      int h = duration / 3600;
      int m = (duration % 3600) / 60;
      int s = (duration % 3600) % 60;

      return string.Format("{3}{0}h:{1:00}m:{2:00}s", h, m, s, neg ? "-" : "");
    }

    public static string AsPercentageBar(this int percentage)
    {
      return new string('=', (int) Math.Round(percentage / 2.5));
    }

    public static string AsBar(this int duration)
    {
      return new string('=', duration / 900);
    } 

    public static DateTime PreviousMonday()
    {
      var today = DateTime.Today.AddDays(-7);

      while (today.DayOfWeek != DayOfWeek.Monday)
        today = today.AddDays(-1);
      return today;
    }

    public static DateTime BeginningOfMonth(DateTime reference)
    {
      return new DateTime(reference.Year, reference.Month, 1);
    }
    public static DateTime BeginningOfPreviousMonth(DateTime reference)
    {
      var thisMonth = BeginningOfMonth(reference);
      return BeginningOfMonth(thisMonth.AddDays(-2));
    }

    public static PropertyInfo[] PropertiesForReport(this Type type)
    {
      return type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.IsVisibleInReport()).ToArray();
    }

    public static string PropertyFormatter(this PropertyInfo prop)
    {
      if (!prop.IsDefined(typeof(DescriptionAttribute), false))
        return "";

      var attr = (DescriptionAttribute)prop.GetCustomAttributes(typeof (DescriptionAttribute), false)[0];
      return attr.Formatting;
    }
    public static int PropertyAlignment(this PropertyInfo prop)
    {
      if (!prop.IsDefined(typeof(DescriptionAttribute), false))
        return 1;

      var attr = (DescriptionAttribute) prop.GetCustomAttributes(typeof(DescriptionAttribute), false)[0];
      return attr.Alignement;
    }

    public static bool IsVisibleInReport(this PropertyInfo prop)
    {
      if (!prop.IsDefined(typeof(DescriptionAttribute), false))
        return true;

      var attr = (DescriptionAttribute) prop.GetCustomAttributes(typeof(DescriptionAttribute), false)[0];
      return !attr.Hidden;
    }


    public static string FormattedValue(this PropertyInfo prop, object target)
    {
      object value = prop.GetValue(target, new object[] {});
      if (value == null) return "";

      var fmt = prop.PropertyFormatter();
      if (string.IsNullOrEmpty(fmt)) return value.ToString();
   
      return string.Format("{0:" + fmt + "}", value);
      //return string.Format(fmt, value);
    }

    public static string[] ToReportEntries(this object obj, params string[] properties_to_skip)
    {
      return obj.GetType().PropertiesForReport()
        .Where(p => !properties_to_skip.Contains(p.Name, StringComparer.InvariantCultureIgnoreCase))
        .Select(p => p.FormattedValue(obj))
        .ToArray();
    }

  }
}