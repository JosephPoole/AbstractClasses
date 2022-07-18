using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region Vehicles
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle 
             * (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Vehicle c1 = new Car()
            {
                Year = "2020",
                Make = "Chevrolet",
                Model = "Corvette",
            };
            Vehicle m1 = new Motorcycle()
            {
                Year = "2020",
                Make = "Kawasaki",
                Model = "Ninja"
            };
            Vehicle c2 = new Car()
            {
                Year = "2020",
                Make = "Ford",
                Model = "Mustang"
            };
            Vehicle m2 = new Motorcycle()
            {
                Year = "2020",
                Make = "Honda",
                Model = "VStar"
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(c1);
            vehicles.Add(c2);
            vehicles.Add(m1);
            vehicles.Add(m2);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" Year: {vehicle.Year} |Make {vehicle.Make} | Model: {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            c1.DriveAbstract();
            Console.WriteLine();
            m2.DriveVirtual();
            Console.WriteLine();
            #endregion            
            
        }
    }
}
