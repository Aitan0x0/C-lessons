//rekursiya ile massivi ekrana cap etmek

namespace Massive_print
{
    internal class Program
    {

        /// <summary>
        /// Massivi cap etmek ucun istifade edirik rekursiya ile
        /// </summary>
        static void ArrayPrint(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return;

            Console.Write($"{myArray[i]}  ");
            i++;
            ArrayPrint(myArray, i);
        }

        static void Main(string[] args)
        {
            Console.Write("Massivin olcusunu daxil edin: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] myArray = new int[size];
            Console.WriteLine("Massivin elementlerini daxil edin:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Massivin [{i}] indexli elementi: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Rekursiya ile massivin capi: ");
            ArrayPrint(myArray);

        }
    }
}
