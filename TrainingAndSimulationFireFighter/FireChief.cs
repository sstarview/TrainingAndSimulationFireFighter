using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  sealed class FireChief : FirefighterBase
  {
    public void TellFirefighterToExtinguishFire(FirefighterBase colleague)
    {
      colleague.ExtinguishFire();
    }

    public override void ExtinguishFire()
    {
      TellFirefighterToExtinguishFire(NumberOne);
    }

    public FirefighterBase NumberOne { get; set; }
  }
}
