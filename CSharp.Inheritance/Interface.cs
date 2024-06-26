﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Interfaces
{
    /// <summary>
    /// when to use --> if the contract is solid and lesser probability of altering the structure in future
    /// example -> car Driving interface which won't change.
    /// </summary>
    interface IDriving
    {
        void StartVehicle();
        void ShiftGear();
        void Steer();
        void Accelerate();
        void ApplyBrakes();
        void StopVehicle();
    }
    public interface IParking
    {
        bool IsEmptyParkingSlot();
        void ReduceSpeed();
        void UseSignalIndicators();
        void ParkVehicle();
        void StopVehicle();

    }
    public class Driver : IDriving,IParking
    {
        //public IParking parking;
        public void Accelerate()
        {
            Console.WriteLine("Accelerated");
        }

        public void ApplyBrakes()
        {
            Console.WriteLine("Brakes applied");
        }

        public bool IsEmptyParkingSlot()
        {
            return true;
        }

        public void ParkVehicle()
        {
            Console.WriteLine("Parked");
        }

        public void ReduceSpeed()
        {
            Console.WriteLine("vehicle slowed down");
        }

        public void ShiftGear()
        {
            Console.WriteLine("Gear shifted");
        }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle started");
        }

        public void Steer()
        {
            Console.WriteLine("Steering wheel rotated");
        }

        void IDriving.StopVehicle()
        {
            Console.WriteLine("Vehicle stopped");
        }
        void IParking.StopVehicle()
        {
            Console.WriteLine("Vehicle stopped after parking.");
        }


        public void UseSignalIndicators()
        {
            Console.WriteLine("Signal indicator turned on");
        }
    }
}
