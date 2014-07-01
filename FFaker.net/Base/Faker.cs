using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker.Base
{
  public class Faker
  {
    protected static string Numerify(string mask)
    {
      var number = string.Empty;
      foreach (var item in mask.ToList())
        number += item.ToString().Replace("#", new Random().Next(10).ToString());
      return number;
    }

    protected static string Rand(string key, string value)
    {
      return NFakerData.Instance().Rand(key, value);
    }
  }
}
