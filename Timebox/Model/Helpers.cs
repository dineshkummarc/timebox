using System;

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
  }
}