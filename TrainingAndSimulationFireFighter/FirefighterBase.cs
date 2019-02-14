using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  abstract class FirefighterBase:INamedPerson,ISalariedPerson
  {
    public string Name { get; set; }

    public decimal Salary { get; set; }

    public abstract void ExtinguishFire();

    public void Drive(Firetruck truckToDrive, Point coordinates)
    {
      if (truckToDrive.Driver != this)
      {
        return;
      }
      truckToDrive.Drive(coordinates);
    }
  }
}
