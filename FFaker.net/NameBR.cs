using NFaker.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker
{
  public class NameBR
  {
    private static string NAME_BR = "name_br";

    public static string Name
    {
      get { return string.Format("{0} {1}", FirstName, LasttName); }
    }

    public static string NameWithPrefix
    {
      get { return string.Format("{0} {1} {2}", Prefix, FirstName, LasttName); }
    }

    public static string FirstName
    {
      get { return NAME_BR.Rand("first_names"); }
    }

    public static string LasttName
    {
      get { return NAME_BR.Rand("last_names"); }
    }

    public static string Prefix
    {
      get { return "Sr. Sra. Srta.".Rand(); }
    }
  }
}
