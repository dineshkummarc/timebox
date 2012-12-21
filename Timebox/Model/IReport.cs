using System.Collections.Generic;

namespace Timebox.Model
{
  internal interface IReportOld
  {
    string Generate(params object[] args);
  }
}