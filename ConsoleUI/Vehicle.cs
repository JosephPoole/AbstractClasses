﻿using System;
namespace ConsoleUI
{
	/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
	public abstract class Vehicle
	{
			public string Year { get; set; }
			public string Make { get; set; }
			public string Model { get; set; }

		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
        {
            Console.WriteLine("Yes.");
        }
	}
}
