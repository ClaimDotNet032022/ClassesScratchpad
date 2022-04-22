using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad032022
{
    public class Dog
    {
        public static int Population {get; private set;}

        public string Color { get; }
        public string Name { get; set; }
        public int HeightInches { get; set; }
        public bool IsSitting { get; private set; }



        public Dog(string color, string name, int height)
        {
            Color = color;
            Name = name;
            HeightInches = height;
            IsSitting = false;

            ++Population;
        }

        public static Dog operator +(Dog dog1, Dog dog2)
        {
            string newName = $"{dog1.Name} and {dog2.Name}'s child";
            int newHeight = (dog1.HeightInches + dog2.HeightInches) / 2;
            return new Dog(dog1.Color, newName, newHeight);
        }

        public void Speak()
        {
            Console.WriteLine("Bark! Bark!");
        }

        public void Sit()
        {
            IsSitting = true;
        }

        public void Stand()
        {
            this.IsSitting = false;
        }

        public static void DoSomethingStatic(Dog dog)
        {
            dog.IsSitting = false;
        }
    }
}
