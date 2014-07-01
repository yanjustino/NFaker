using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NFaker.Base
{
  internal class NFakerData
  {
    private string data;
    private static NFakerData current;

    public static NFakerData Instance()
    {
      if (current == null)
        current = new NFakerData();
      return current;
    }

    public string[] ReadFile(string folder, string file)
    {
      this.data = folder;
      return File.ReadAllLines(GetPath(file));
    }

    private string GetPath(string value)
    {
      var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      return string.Format("{0}\\data\\{1}\\{2}", directory, this.data, value);
    }
  }
}
