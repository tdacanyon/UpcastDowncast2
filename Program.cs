using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastDowncast2
{
  class Program
  {

    public class animals
    {
      public int IdNum;
    }
    public class dog : animals
    {
      public string beg;
    }

    public class cat : animals
    {
      public string meow;
    }

    static void Main(string[] args)
    {
      dog dog1 = new dog()
      {
        IdNum = 1,
        beg = "Food Please"
      };
      dog dog2 = new dog()
      {
        IdNum = 2,
        beg = "How about some food?"
      };

      cat cat1 = new cat()
      {
        IdNum = 1,
        meow = "Meow yo!"
      };

      cat cat2 = new cat()
      {
        IdNum = 2,
        meow = "What Up G? Meow!"
      };

      List<animals> amList = new List<animals>();
      // Upcasting = using all instances as the base class;     
      amList.Add(dog1);
      amList.Add(dog2);
      amList.Add(cat1);
      amList.Add(cat2);

      foreach (animals animalCycle in amList)
      {
        Console.WriteLine(animalCycle.IdNum.ToString());
      }
      Console.ReadLine();

      // This here's your downcasting. 

      foreach (animals animalCycle in amList)
      {
        if (animalCycle is cat)
        {
          cat catCatch = animalCycle as cat;
          Console.WriteLine(catCatch.meow);
          Console.ReadLine();
        }
      }
      Console.ReadLine();
    }
  }
}
