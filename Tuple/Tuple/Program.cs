namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int Num,string Text) result = A();      //first tuple
            Console.WriteLine(result.Num);

            (int Num, string Text,int Num2) result2 = B();      //second tuple
            Console.WriteLine(result2.Num2);

            (int Num, string Text, int Num2,string Name) result3 = C();      //third tuple
            Console.WriteLine(result3.Name);
        }
        static (int,string) A()
        {                                 //first tuple
            return (15, "anar");
        }
        static (int,string,int) B()
        {                                          //second tuple
            return (1, "salam", 23);
        }
        static (int,string,int,string) C()
        {                                           //third tuple
            return (12, "code", 34, "academy");
        }
    }

}
