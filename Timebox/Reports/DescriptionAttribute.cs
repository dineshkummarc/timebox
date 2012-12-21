using System;

namespace Timebox.Reports
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false)]
  public class DescriptionAttribute : Attribute
  {
    public DescriptionAttribute(string name)
    {
      Name = name;
    }
    public DescriptionAttribute()
    {
    }

    public string Name { get; set; }
    public string Formatting { get; set; }
    public bool Hidden { get; set; }
    public int Alignement { get; set; }
    public bool HasFormatting { get { return !string.IsNullOrEmpty(Formatting); } }

  }
}