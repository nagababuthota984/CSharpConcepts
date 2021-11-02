// See https://aka.ms/new-console-template for more information
using CSharp.Inheritance;
using CSharpConcepts;
using CSharpConcepts.AbstractClass;
using CSharpConcepts.Interfaces;
using CSharpConcepts.Polymorphism;

//Inheritance
//Dog dog = new Dog();
//Cat cat = new Cat();


//Polymorphism
//Vehicle veh = new Vehicle();   //calls the base class methods
//veh.MakeSound();
//veh.Start();
//Vehicle bike = new Bike();      // can call overriden methods.. if any method is hidden by derived class (bike).. then base class method will be called.
//bike.MakeSound();
//bike.Start();
//Bike newbike = new Bike();   //calls the start method which is hidden by bike class.
//newbike.Start();

//Interfaces
//Driver driver = new Driver();
//driver.StartVehicle();
//driver.ShiftGear();
//((IDriving)driver).StopVehicle();
//((IParking)driver).StopVehicle();
////instead of type casting
//IDriving idrive = new Driver();
//IParking ipark = new Driver();
//idrive.StopVehicle();
//ipark.StopVehicle();

//abstract class
Driving driving = new Driving();
VehicleDriver driv = new VehicleDriver();
//driv.StartVehicle();
//driv.DriveVehicle();
//driv.StopVehicle();


//singleton class
Singleton s1 = Singleton.Instance;
Singleton s2 = Singleton.Instance;
Console.WriteLine(Singleton.Count);