using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.AbstractClass
{
    public abstract class Driving
    {
        
        public void StartVehicle()
        {
            Console.WriteLine("Push the start button");
        }
        public abstract void DriveVehicle();
        
        public void StopVehicle()
        {
            Console.WriteLine("Push the stop button");
        }
    }
    public class VehicleDriver : Driving
    {
        public override void DriveVehicle()
        {
            Console.WriteLine("Driving the vehicle");
        }
    }
}
