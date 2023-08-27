using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
    {
    enum SoundMode{ bark, meow }
    
    class Dog
        {
        public virtual void MakeSound(SoundMode mode)
            {
            if(mode == SoundMode.bark)
                {
                Console.WriteLine("The Dog is Barking");
                }
            else
                {
                Console.WriteLine("Dog not Barking");
                }
            }
        }

    class Cat : Dog
        {
        public override void MakeSound(SoundMode mode)
            {
            if(mode == SoundMode.meow)
                {
                Console.WriteLine("The Cat is Meowing");
                }
            else
                {
                Console.WriteLine("Cat not Meowing");
                }
            }
        }
    class Overriding
        {
        static void Main(string[] args)
            {
            Dog sound = new Dog();
            sound.MakeSound(SoundMode.bark);

            sound = new Cat();
            sound.MakeSound(SoundMode.bark);
            sound.MakeSound(SoundMode.meow);

            Cat soundnew = new Cat();
            soundnew.MakeSound(SoundMode.bark);
            soundnew.MakeSound(SoundMode.meow);

            }

        }
    }
