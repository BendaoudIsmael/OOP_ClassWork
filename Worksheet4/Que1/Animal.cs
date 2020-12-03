using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    abstract class Animal
    {
        string speak;
        string sound;

        public string Speak1 { get => speak; set => speak = value; }
        public string Sound { get => sound; set => sound = value; }

        public virtual string Speak()
        {
            return "Hello!";
        }

        /*
         *public virtual string Speak()
          {
            return "Hello! I am a generic animal!";
          }
         */

        public virtual string Move()
        {
            return "Animal moving";
        }

        public virtual string Eat()
        {
            return "Animal eating";
        }
    }
}
