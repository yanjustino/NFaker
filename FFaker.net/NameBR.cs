using NFaker.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFaker
{
  public class NameBR : Faker
  {
    private static string KEY = "name_br";

    public static string FirstName
    {
      get { return Rand(KEY, "first_names"); }
    }

    public static string LasttName
    {
      get { return Rand(KEY, "last_names"); }
    }

  }
}
