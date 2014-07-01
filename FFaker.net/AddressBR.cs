using NFaker.Base;
using System;
using System.Linq;

namespace NFaker
{
  public class AddressBR : Faker
  {
    private static string KEY = "address_br";

    public static string State 
    { 
      get { return Rand(KEY, "state"); } 
    }

    public static string ZipCode 
    { 
      get { return Numerify("#####-###"); } 
    }

    public static string StateAbbr 
    { 
      get { return Rand(KEY, "state_abbr"); } 
    }

    public static string City 
    { 
      get { return Rand(KEY, "city"); } 
    }

    public static string StreetPrefix 
    { 
      get { return RandStreetPrefix(); } 
    }

    public static string Street 
    { 
      get { return RandStreet(); } 
    }

    private static string RandStreetPrefix()
    {
      var STREET_PREFIX = new string[] { "Rua", "Avenida", "Travessa", "Alameda" };
      var index = new Random().Next(STREET_PREFIX.Count());
      return STREET_PREFIX[index];
    }

    private static string RandStreet()
    {
      switch (new Random().Next(2))
      {
        case 0: return string.Format("{0} {1}", StreetPrefix, "");
        case 1: return string.Format("{0} {1} {2} {3}", StreetPrefix,
          NameBR.FirstName, NameBR.LasttName, NameBR.LasttName);
        default: return string.Empty;
      }
    }
  }
}
