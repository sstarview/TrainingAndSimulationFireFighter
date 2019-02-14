using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class TraineeFirefighter : Firefighter
  {
    private bool hoseTrainedOnFire;

    protected override void TurnOnHose()
    {
      if (hoseTrainedOnFire)
      {
        base.TurnOnHose();
      }
      else
      {
        Console.WriteLine("There's water going everywhere!");
      }
    }

    protected override void TrainHoseOnFire()
    {
      hoseTrainedOnFire = true;
      base.TrainHoseOnFire();
    }

  }
}
