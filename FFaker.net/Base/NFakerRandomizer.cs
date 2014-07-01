using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker.Base
{
  internal static class NFakerRandomizer
  {
    public static string Rand(this string[] value)
    {
      var index = value.Count().Randomize();
      return value[index];
    }

    public static object[] Rand(this object[,] values)
    {
      var index = values.GetLength(0).Randomize();

      return new object[] 
      { 
        values.GetValue(index, 0), 
        values.GetValue(index, 1) 
      };
    }

    public static double[] Rand(this double[,] values)
    {
      var index = values.GetLength(0).Randomize();

      return new double[] 
      { 
        (double)values.GetValue(index, 0), 
        (double)values.GetValue(index, 1) 
      };
    }

    public static string Rand(this string value, char separator = ' ')
    {
      return value.Split(separator).Rand();
    }

    public static string Rand(this string key, string value)
    {
      var values = NFakerData.Instance().ReadFile(key, value);
      return values.Rand();
    }

    public static int Randomize(this int max)
    {
      return new Random().Next(max);
    }
  }
}
