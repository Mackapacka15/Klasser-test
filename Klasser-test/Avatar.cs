using System;

namespace Klasser_test
{
    public class Avatar
    {
        public int x;
        public int y;
        public int speed;
        public int damage;
        public int hp;
        public int maxHp;

    public Avatar() 
    {
        Random generator = new Random(); 
        hp=generator.Next(50);
    }
    }
}
