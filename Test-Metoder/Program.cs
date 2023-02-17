using System;
namespace Metoder_test
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två heltal separerade med * tecknet");
            Console.WriteLine(" ");
            string a =Console.ReadLine();
            Console.WriteLine(" ");
            string[] b=a.Split('*');
            int c =int.Parse(b[0]);
            int d =int.Parse(b[1]);
            Console.WriteLine(Area(c,d));
        }
        static int Area(int bredd, int höjd)
        {
            
            return bredd * höjd;
        }
    }
}