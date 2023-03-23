using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}
		public bool HasWings {get; set;}
		public int NumOfEggs {get; set;}
		
		public string BirdCall {get; set;}
		private string _feathercolor;
		public string FeatherColor 
		{
			get
			{
				return _feathercolor;

			}
			set
			{
				_feathercolor = value;

			}
		}

		}
}

