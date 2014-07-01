using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NFaker.Tests
{
  [TestClass]
  public class NameBRTests
  {
    [TestMethod]
    [Description("When call NameBR.FirstName returns a name")]
    public void NameBR_FullName()
    {
      var first_name = NFaker.NameBR.FirstName;

    }
  }
}
