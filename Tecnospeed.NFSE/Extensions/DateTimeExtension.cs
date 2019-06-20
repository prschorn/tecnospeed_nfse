using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tecnospeed.NFSE.Extensions
{
  public static class DateTimeExtension
  {
    public static string DatabaseTime(this DateTime dt)
    {
      var dbTime = $"{dt.Year}-{dt.Month}-{dt.Day}T{dt.Hour.ToString("00")}:{dt.Minute.ToString("00")}:{dt.Second.ToString("00")}";

      return dbTime;
    }
  }
}
