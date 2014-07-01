using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker.Base
{
  internal static class Faker
  {
    public static string Numerify(this string value)
    {
      var number = string.Empty;
      foreach (var item in value.ToList())
        number += item.ToString().Replace("#", 10.Randomize().ToString());
      return number;
    }
  }
}
