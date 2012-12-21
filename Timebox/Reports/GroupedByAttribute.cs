using System;

namespace Timebox.Reports
{
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class GroupedByAttribute : Attribute
  {
  }
}