using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        public string Show()
        {
            // Checks if the animal class  can fly, they all got a CanFly bool value.
            // if the animal can't fly, returns can't fly.
            if (CanFly == true)
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2} and can fly", Name, Sound, GetType());
            }
            else
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2}", Name, Sound, GetType());
            }
        }

    }
   
    // that, in this case, are public and called in Program.cs code
    class Dog : Animal
    {
        public Dog(String name)
        {
            Name = name;
            Sound = "WOAF WOAF";
            CanFly = false;
        }
    }
    class Cat : Animal
    {
        public Cat(String name)
        {
            Name = name;
            Sound = "MEOW";
            CanFly = false;
        }
    }
    class Bird : Animal
    {
        public Bird(String name)
        {
            Name = name;
            Sound = "pipipi";
            CanFly = true;
        }
    }
}