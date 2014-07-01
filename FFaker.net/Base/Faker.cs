using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker.Base
{
  public static class Faker
  {
    public static string Numerify(this string value)
    {
      var number = string.Empty;
      foreach (var item in value.ToList())
        number += item.ToString().Replace("#", 10.Random().ToString());
      return number;
    }

    public static string Rand(this string[] value)
    {
      var index = new Random().Next(value.Count());
      return value[index];
    }

    public static string Rand(this string key, char separator = ' ')
    {
      return key.Split(separator).Rand();
    }

    public static string Rand(this string key, string value)
    {
      return NFakerData.Instance().Rand(key, value);
    }

    public static string Format(this string partn, params object[] args)
    {
      return string.Format(partn, args);
    }

    public static int Random(this int max)
    {
      return new Random().Next(max);
    }
  }
}
