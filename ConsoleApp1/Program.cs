using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      //Administrator my = new Administrator();
      Task task1 = new Task();
      Administrator me = new Administrator();
     // me.Name = "Salman";
      me.Email = "salman@";
      //Administrator my = new Administrator();
      //my.Name = "Raja";

      task1.Giver = me;
      task1.Drive("good");

      Console.WriteLine("Try");




    }
  }
}
