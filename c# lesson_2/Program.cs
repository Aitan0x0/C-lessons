//Uc ededin cemi , hasili 

using System;
namespace c__lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //evvelce uc ededi tek tek daxil edek
            Console.WriteLine("Ilk ededi daxil edin :");
          bool a_bool=   double.TryParse(Console.ReadLine(), out double a);

            Console.WriteLine("Ikinci ededi daxil edin :");
            bool b_bool = double.TryParse(Console.ReadLine(), out double b);

            Console.WriteLine("Ucuncu ededi daxil edin :");
            bool c_bool = double.TryParse(Console.ReadLine(), out double c);

            if(a_bool && b_bool && c_bool)
            {
                double sum = a + b + c;
                double hasil = a * b * c;

                Console.WriteLine("Cemleri : " + sum );
                Console.WriteLine("Hasilleri : " + hasil );
            }
            else
            {
                Remove - Item - Recurse - Force.git
                Console.WriteLine("Ededler dogru daxil edilmeyib");
                return; 
            }

        }
    }
}
