using System;
namespace Inheritance
{
	public class Animal
	{
		public Animal()
		{
		}

//Creating properties using the private encapsulation method
		private string canBreath;
		public string CanBreath 
		{ 	
				get {return canBreath;}
				set {canBreath = value;}
		}
		private string canDie;
		public string CanDie
		{
			get {return canDie; }
			set{canDie = value;}
		}

		private string hasSex;
		public string HasSex
		{
			get{return hasSex;}
			set{hasSex = value;}
		}

		private string canAdapt;
		public string CanAdapt
		{
			get {return canAdapt;}
			set {canAdapt = value;}
		
			
		}







	}

}

