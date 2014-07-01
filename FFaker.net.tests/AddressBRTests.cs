using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace NFaker.Tests
{
  [TestClass]
  public class AddressBRTests
  {
    [TestMethod]
    [Description("When call 'AddressBR.State' returns state name")]
    public void AddressBR_State()
    {
      Assert.IsNotNull(NFaker.AddressBR.State);
    }

    [TestMethod]
    [Description("When call 'AddressBR.ZipCode' returns a zipcode")]
    public void AddressBR_ZipCode()
    {
      var zipcode = NFaker.AddressBR.ZipCode;
      Assert.IsTrue(Regex.Match(zipcode, "[0-9]{5}-[0-9]{3}$").Success);
    }

    [TestMethod]
    [Description("When call 'AddressBR.StateAbbr' returns a state abbr")]
    public void AddressBR_StateAbbr()
    {
      Assert.IsNotNull(NFaker.AddressBR.StateAbbr);
    }

    [TestMethod]
    [Description("When call 'AddressBR.ZipCode' returns a city")]
    public void AddressBR_City()
    {
      Assert.IsNotNull(NFaker.AddressBR.City);
    }

    [TestMethod]
    [Description("When call 'AddressBR.StreetPrefix' returns a Street Prefix")]
    public void AddressBR_StreetPrefix()
    {
      Assert.IsNotNull(NFaker.AddressBR.StreetPrefix);
    }

    [TestMethod]
    [Description("When call 'AddressBR.StreetPrefix' returns a Street")]
    public void AddressBR_Street()
    {
      Assert.IsNotNull(NFaker.AddressBR.Street);
    }
  }
}
