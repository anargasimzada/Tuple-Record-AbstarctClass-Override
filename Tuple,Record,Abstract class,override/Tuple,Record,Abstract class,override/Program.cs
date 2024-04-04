using Tuple_Record_Abstract_class_override.Models;

namespace Tuple_Record_Abstract_class_override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot nazim = new Parrot();
            Shark akula = new Shark();
            Eagle eagle = new Eagle();
            Animal[] animals = {nazim, akula,eagle};
            //nazim.Eat();
            //akula.Eat();
            //eagle.Fly();
            foreach (Animal animal in animals)
            {
                animal.Eat();
            }
        }
    }
}
