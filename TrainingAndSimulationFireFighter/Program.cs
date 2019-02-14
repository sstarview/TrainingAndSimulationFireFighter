using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class Program
  {
    static void Main(string[] args)
    {
      //  Firetruck truckOne = new Firetruck();
      //  FireChief bigChiefHarry = new FireChief { Name = "Harry" };

      //  truckOne.Driver = bigChiefHarry;
      //  bigChiefHarry.Drive(truckOne, new Point(100, 300));

      //  Firefighter joe = new Firefighter { Name = "Joe" };
      //  bigChiefHarry.TellFirefighterToExtinguishFire(joe);

      //FireChief bigChiefHarry = new FireChief { Name = "Harry" };
      //// Another reference to Harry, but as a firefighter
      //Firefighter stillHarry = bigChiefHarry;
      //Firefighter joe = new Firefighter { Name = "Joe" };
      //stillHarry.TellFirefighterToExtinguishFire(joe);

      //Firefighter joe = new Firefighter { Name = "Joe" };
      //Firefighter harry = new FireChief { Name = "Harry", NumberOne = joe };
      //harry.ExtinguishFire();

      //// A reference to Joe, Harry's number one
      //Firefighter joe = new Firefighter { Name = "Joe" };
      //// Firefighter harry is really a firechief, with joe as his NumberOne
      //FireChief harry = new FireChief { Name = "Harry", NumberOne = joe };
      //Firefighter harryAsAFirefighter = harry;
      //// Harry is just a firefighter, so he can extinguish fires
      //// but as a firechief he gets joe to do the work
      //harry.ExtinguishFire();
      //// While as a firefighter he does it himself
      //harryAsAFirefighter.ExtinguishFire();

      //// A reference to Joe, Harry's number one
      //Firefighter joe = new Firefighter { Name = "Joe" };
      //// FireChief harry has joe as his NumberOne
      //FireChief harry = new FireChief { Name = "Harry", NumberOne = joe };
      //FireChief tom = new FireChief { Name = "Tom", NumberOne = harry };
      //// Harry is just a firefighter, so he can extinguish fires
      //// but as a firechief he gets joe to do the work
      //harry.ExtinguishFire();
      //// But if Tom is asked to extinguish a fire, he asks Harry to do it
      //// Our policy dictates that Harry has to do it himself, not delegate to
      //// Joe this time.
      //tom.ExtinguishFire();

      //Firefighter joe = new Firefighter { Name = "Joe" };
      //joe.ExtinguishFire();

      //// A reference to Bill, the trainee
      //FirefighterBase bill = new TraineeFirefighter { Name = "Bill" };
      //bill.ExtinguishFire();

      FireStation station = new FireStation();
      // A reference to Joe, Harry's number one
      Firefighter joe = new Firefighter { Name = "Joe" };
      // A reference to Bill, the trainee
      FirefighterBase bill = new TraineeFirefighter { Name = "Bill" };
      // Harry is back
      FireChief bigChiefHarry = new FireChief { Name = "Harry" };
      // And here's our administrator - Arthur
      Administrator arthur = new Administrator
      {
        Title = "Mr",
        Forename = "Arthur",
        Surname = "Askey"
      };
      station.ClockIn(joe);
      station.ClockIn(bill);
      station.ClockIn(bigChiefHarry);
      station.ClockIn(arthur);
      station.RollCall();
      

      AFootInBothCamps both = new AFootInBothCamps();
      ISettableNamedPerson settablePerson = both;
      INamedPerson namedPerson = both;
      settablePerson.Name = "Hello";
      Console.WriteLine(settablePerson.Name);
      Console.WriteLine(namedPerson.Name);
      Console.WriteLine(both.Name);
      Console.ReadKey();
    }
  }
}
