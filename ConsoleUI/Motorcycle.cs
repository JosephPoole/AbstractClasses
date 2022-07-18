﻿using System;

namespace ConsoleUI
{
	/* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
	public class Motorcycle : Vehicle
	{
		public static string HasSideCart {  get; set; }
       
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is Driving.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle is driving in virtual.");
        }
    }
}
