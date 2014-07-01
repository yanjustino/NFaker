using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NFaker
{
  public class NFakerData
  {
    private string data;
    private static NFakerData current;

    public static NFakerData Instance()
    {
      if (current == null)
        current = new NFakerData();
      return current;
    }

    public string Rand(string key, string value)
    {
      this.data = key;

      var lines = file(value);
      var index = new Random().Next(lines.Count());
      return lines[index];
    }

    private string[] file(string value)
    {
      return File.ReadAllLines(path(value));
    }

    private string path(string value)
    {
      var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      return string.Format("{0}\\data\\{1}\\{2}", directory, this.data, value);
    }

  }
}
