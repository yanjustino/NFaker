using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace NFaker.Tests
{
  [TestClass]
  public class GeolocationTests
  {
    [TestMethod]
    [Description("When call Geolocation.Latitude returns a double velue")]
    public void Geolocation_Latitude()
    {
      var latitude = NFaker.Geolocation.Latitude.ToString();
      Assert.IsTrue(Regex.Match(latitude, "[0-9]").Success);
      Console.Write(latitude);
    }

    [TestMethod]
    [Description("When call Geolocation.Longitude returns a double velue")]
    public void Geolocation_Longitude()
    {
      var longitude = NFaker.Geolocation.Longitude.ToString();
      Assert.IsTrue(Regex.Match(longitude, "[0-9]").Success);
      Console.Write(longitude);
    }
  }
}
