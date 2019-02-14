using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class Firetruck
  {
    public FirefighterBase Driver { get; set; }

    readonly Ladder ladder = new Ladder { Length = 30.0 };

    public Ladder Ladder
    {
      get
      {
        return ladder;
      }
    }

    public Hose Hose { get; set; }


    public void Drive(Point coordinates)
    {
      if (Driver ==null)
      {
        return;
      }
      Console.WriteLine("Driving to {0}", coordinates);
    }
  }
}
