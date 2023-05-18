using FootballGameEngine;
using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Person goalkeeper = new Goalkeeper("Gosho", 22, 01, 1.87);
            Person striker = new Striker("Pesho", 24, 10, 1.78);

            Person[] players1 = new Person[14];

            players1[0] = goalkeeper;
        }
    }
}
