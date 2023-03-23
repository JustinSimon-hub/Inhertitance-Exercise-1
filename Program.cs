using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

//New Instantiations of Bird and Reptile Class
            Bird Birdie = new Bird{FeatherColor = "Red", NumOfEggs = 2,HasWings = true,BirdCall = "Sqeueee"};
            

            Reptile Scaly = new Reptile{AvgNumOfEggs = 2,NumLegs = 4,WhatitEats = "Mice",RegensLimbs = true};
            
//Object values for bird inside list 

            List<Bird> birds = new List<Bird>();
                    birds.Add(Birdie);
            List<Reptile> reptiles = new List<Reptile>();
                        reptiles.Add(Scaly);

            //Displays obj info for bird class 
            for (int i = 0; i < birds.Count; i++)
                        {
                            Console.WriteLine(birds[i]);
                        }


            // Displays obj info for reptile class
            foreach( var o in reptiles)
            {
                Console.WriteLine(o);
            }

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
