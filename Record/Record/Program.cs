using System.Text.RegularExpressions;
using System.Xml.Linq;
using System;

namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecord std1 = new StudentRecord()
            {
                Name = "Anar",
                Surname = "Qasimzade",
                Age = 20,
                Group = "AB106",
                Uni = "AzTU"
            };
            StudentRecord std2 = std1 with { Name = "Nurlan", Surname = "Abbasov" };
            Console.WriteLine(std1);
            Console.WriteLine(std2);
            StudentRecord std2 = new StudentRecord("A", "B");
            Console.WriteLine(Object.ReferenceEquals(std1, std2));
            Console.WriteLine(std1 == std2);
        }
        record StudentRecord(string Name = "XXX", string Surname = "YYY", byte Age = 0, string Grup = "", string Uni = "");

    }
}
