using System;
namespace Inheritance
{
	public class Bird : Animal
	{
//Set properties for the Bird class using the constructor method where i pass and set the properties through the parameters of the bird constructor
		public string BFeatherColor {get; set;}
		public string BFlightPattern {get; set;}
		public string BBirdDiet {get; set;}
		public string BBeakSize{get; set;}
		public Bird(string FeatherColor, string FlightPattern, string BirdDiet, string BeakSize)
		{
			BFeatherColor =  FeatherColor; 
			BFlightPattern = FlightPattern;
			BBirdDiet = BirdDiet;
			BBeakSize = BeakSize;
		}



	}
}

