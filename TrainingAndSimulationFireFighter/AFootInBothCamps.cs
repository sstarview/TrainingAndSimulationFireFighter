using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class AFootInBothCamps : INamedPerson, ISettableNamedPerson
  {
    private string settableName;

    //string INamedPerson.Name
    public string Name
    {
      get
      {
        Console.WriteLine("Accessed through the INamedPerson interface");
        return settableName;
      }
    }

    string ISettableNamedPerson.Name
    {
      get
      {
        return settableName;
      }
      set
      {
        Console.WriteLine("Accessed through the " + "ISettableNamedPerson interface");
        if (settableName != null && settableName.Contains(" "))
        {
          // You can't set it if it contains the space
          // character
          return;
        }
        settableName = value;
      }
    }
  }
}
