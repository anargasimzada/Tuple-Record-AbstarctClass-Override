using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Record_Abstract_class_override.Models
{
    internal class Fish : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("eat as fish");
        }

        public void Swim()
        {
            Console.WriteLine("swim");
        }
    }
}
