using System;
using System.Collections.Generic;
using Timebox.Model;

namespace Timebox.Reports
{
  public interface IReport
  {
      string Name { get; }
      string[] Columns { get; }
      string Text { get; }
      string Html { get; }
      string CSV { get; }
      Func<object, object> Grouping { get; }
      void Execute();
  }
}
