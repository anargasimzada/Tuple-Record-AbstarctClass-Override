using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Record_Abstract_class_override.Models
{
    internal class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("fly as eagle");
        }
    }
}
