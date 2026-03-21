//massivdeki ededlerin cemini tapir (rekursiya ile)

namespace Massive_sum
{
    internal class Program
    {

        /// <summary>
        /// Massivdeki ededlerin cemini qaytarir , rekursiyadan istifade olunub 
        /// </summary>
        /// <param name="myArray"></param>
        /// <param name="result"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        static int Sum(int[] myArray, int result = 0, int i = 0)
        {
            if (i >= myArray.Length)
                return result;
            result += myArray[i];
            i++;
            return Sum(myArray, result, i);
        }
        static void Main(string[] args)
        {
            //massivin olcusunu isteyirik
            Console.Write("Massivin olcusunu daxil edin: ");
            int size = int.Parse(Console.ReadLine());
            int[] myArray = new int[size];

            Console.WriteLine();

            //massivi daxil edeciyik
            Console.WriteLine("Massivi daxil edin: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Massivin [{i}] indexli elementi: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine($"Massivdeki elementlerin cemi: {Sum(myArray)};");
        }
    }
}
