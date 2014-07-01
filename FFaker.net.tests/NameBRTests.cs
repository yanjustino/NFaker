using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace NFaker.Tests
{
  [TestClass]
  public class NameBRTests
  {
    [TestMethod]
    [Description("When call NameBR.Name returns a full name")]
    public void NameBR_Name()
    {
      var name = NFaker.NameBR.Name;
      Assert.IsTrue(Regex.Match(name, "\\w* \\w").Success);
      Console.Write(name);
    }

    [TestMethod]
    [Description("When call NameBR.Name returns a full name with prefix")]
    public void NameBR_NameWithPrefix()
    {
      var name = NFaker.NameBR.NameWithPrefix;
      Assert.IsTrue(Regex.Match(name, "\\w* \\w* \\w*").Success);
      Console.Write(name);
    }
  }
}
