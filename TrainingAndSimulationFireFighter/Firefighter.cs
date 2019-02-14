using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class Firefighter : FirefighterBase
  {
    public override void ExtinguishFire()
    {
      Console.WriteLine("{0} is putting out the fire!", Name);
      TurnOnHose();
      TrainHoseOnFire();
    }

    protected virtual void TurnOnHose()
    {
      Console.WriteLine("The fire is going out.");
    }

    protected virtual void TrainHoseOnFire()
    {
      Console.WriteLine("Training hose on the fire.");
    }
  }
}
