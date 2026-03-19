//polindrom massivin yoxlanisi

namespace Polindrom_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            bool isPolindrom = false;

            Console.WriteLine("Massivi daxil edin : ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massiv [{i}]: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();


            for (int i = 0 , j=myArray.Length-1; i <myArray.Length/2 && j> myArray.Length / 2; i++ , j--)
            {
                if (myArray[i] == myArray[j])
                {
                    isPolindrom = true; 
                }
                else
                {
                    isPolindrom = false;
                    break;
                }
            }

            if (isPolindrom)
            {
                Console.WriteLine("Massiv polindromdur");
            }
            else
            {
                Console.WriteLine("Massiv polindrom deyil");
            }

        }
    }
}
