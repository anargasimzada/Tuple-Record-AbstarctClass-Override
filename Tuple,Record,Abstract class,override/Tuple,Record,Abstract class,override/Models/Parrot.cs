using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Record_Abstract_class_override.Models
{
    class Parrot : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("eat as parrot");
        }

        public override void Fly()
        {
            Console.WriteLine("fly as parrot");
        }

        public void Talk()
        {
            Console.WriteLine("shsh");
        }
    }
}
