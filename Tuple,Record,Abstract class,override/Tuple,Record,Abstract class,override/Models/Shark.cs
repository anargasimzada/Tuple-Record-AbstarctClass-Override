using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tuple_Record_Abstract_class_override.Models
{
    internal class Shark:Fish
    {
        public void Hunt()
        {
            Console.WriteLine("hunted");
        }
    }
}
