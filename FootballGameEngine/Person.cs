using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameEngine
{
    public abstract class Person
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { 
				if(value == null)
				{
					throw new ArgumentException("Name cannot be null!");
				}
				name = value; 
			}
		}

		private int age;
		public int Age
		{
			get { return age; }
			set {
				if (value <= 0)
				{
					throw new ArgumentException("Age should be a possitive number!");
				}
				age = value; 
			}
		}

		protected Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
