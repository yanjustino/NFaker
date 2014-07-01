using NFaker.Base;
using System;
using System.Linq;

namespace NFaker
{
  public class AddressBR
  {
    private static string ADDRESS_BR = "address_br";

    public static string State 
    {
      get { return ADDRESS_BR.Rand("state"); } 
    }

    public static string ZipCode 
    { 
      get { return "#####-###".Numerify(); } 
    }

    public static string StateAbbr 
    {
      get { return ADDRESS_BR.Rand("state_abbr"); } 
    }

    public static string City 
    {
      get { return ADDRESS_BR.Rand("city"); } 
    }

    public static string StreetPrefix 
    {
      get { return "Rua Avenida Travessa Alameda".Rand(); } 
    }

    public static string Street 
    { 
      get 
      {
        switch (2.Randomize())
        {
          case 0: return string.Format("{0} {1}", StreetPrefix, NameBR.Name);
          case 1: return string.Format("{0} {1} {2} {3}", StreetPrefix,
            NameBR.FirstName, NameBR.LasttName, NameBR.LasttName);
          default: return string.Empty;
        }      
      } 
    }
  }
}
