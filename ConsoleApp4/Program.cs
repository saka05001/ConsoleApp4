using System;

namespace MetoderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv bredden");
            int bredden = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv höjden");
            int höjden = int.Parse(Console.ReadLine());


            int area = Area(bredden, höjden);

            Console.WriteLine("Arean är " + area);


        }
        static int Area(int bredden, int höjden)

        {
            return bredden * höjden;
        }
    }
}



            

        
  
        



