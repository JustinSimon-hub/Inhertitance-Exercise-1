using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine("Do you want to learn some shit about birds and snakes?");
           string a = Console.ReadLine();




                //Creating new bird and retile class objects
            Bird bird = new Bird("red", "v-shape flight pattern","eats mostly worms", "large beak size");
            Reptile reptile = new Reptile();

           //Creating new list for the bird and reptile class so that each property i create i pass them into the lists
            List<Bird> birdlist = new List<Bird>();
            List<Reptile> reptilelist = new List<Reptile>();

            reptile.CanAdapt = "can adapt";
            reptile.CanBreath = "can beathe";
            reptile.CanDie = "can die";
            reptile.HasSex = "reproduces";
            reptile.IsSnakeColdBlooded = true;
            reptile.SnakeDiet = "eats mostly mice and small mammals";
            reptile.SnakeScaleColor = "this snake is all red";
            reptile.SnakeSpecies = "this snake is a python";

            
            bird.CanAdapt = "can adapt";
            bird.CanBreath = "can breathe";
            bird.CanDie = "does die eventually";
            bird.HasSex = "reproduces like any other bird";

            //Adding the every property set for both the classes into the lists created earlier
            birdlist.Add(bird);
            reptilelist.Add(reptile);
        if ( a == "yes"){
            foreach(var i in birdlist)
            {

            }

            foreach(var s in reptilelist)
            {
                Console.WriteLine($"The snake {reptile.CanAdapt} and {reptile.CanBreath} and like any animal {reptile.CanDie} and does {reptile.HasSex} and is {reptile.IsSnakeColdBlooded} due the envirnomnent they live in, and eats {reptile.SnakeDiet} and is usually {reptile.SnakeScaleColor} and is a mmember of the {reptile.SnakeSpecies}.");
            }
            Console.WriteLine("***********************");
            foreach ( var b in birdlist)
            {
                Console.WriteLine($"The bird has a {bird.BFeatherColor} and a beak size {bird.BBeakSize} and mostly eats {bird.BBirdDiet} and flies in a {bird.BFlightPattern} and {bird.CanAdapt} and does {bird.CanBreath} and like any animal it {bird.CanDie} and creates more through {bird.HasSex}.");
            }
        }
        else 
        {
            Console.WriteLine("Oh well then.");
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