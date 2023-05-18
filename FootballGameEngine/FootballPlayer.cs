using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameEngine
{
    public abstract class FootballPlayer : Person
    {
        protected FootballPlayer(string name, int age, int number, double height)
            : base(name, age)
        {
            Number = number;
            Height = height;
        }

        public int Number { get; set; }

        private double height;
        public double Height
        {
            get { return height; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be a possitive number!");
                }
                height = value; 
            }
        }

    }
}
