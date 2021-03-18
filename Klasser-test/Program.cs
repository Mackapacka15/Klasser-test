using System.Collections.Generic;
using System;

namespace Klasser_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Avatar hero = new Avatar();
            Avatar villan = new Avatar();
            Monster enemy = new Monster();

            Console.WriteLine(enemy.hp);

            Console.ReadLine();
        }
    }
}
