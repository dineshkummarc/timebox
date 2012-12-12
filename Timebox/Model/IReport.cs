using System.Collections.Generic;

namespace Timebox.Model
{
  internal interface IReport
  {
    string Generate(params object[] args);
  }
}