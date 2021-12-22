using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.AbstractClass
{
    /// <summary>
    /// when to use -> 1)if the members are not public 2)if some of the functionality is common among the implementations and remaining is done by extending the class
    /// example -> driving a tesla car... just have to start and stop the car, since driving is automated and pre-defined.
    /// </summary>
    public abstract class Driving
    {
        public Driving()
        {
            Console.WriteLine("This is abstract class.");
        }
        public Driving(string driverName)
        {
            Console.WriteLine(driverName);
        }
        public abstract void StartVehicle();
        public  void DriveVehicle()
        {
            Console.WriteLine("Driving the vehicle");
        }

        public abstract void StopVehicle();
    }
    public class Driver : Driving
    {


        public override void StartVehicle()
        {
            //base("ravi");
            Console.WriteLine("Starting the vehicle");
        }
        public override void StopVehicle()
        {
            Console.WriteLine("Stopping the vehicle");
        }

    }
}
