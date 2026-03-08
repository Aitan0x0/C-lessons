//massivdeki 0-lari sona yazan kod

namespace c__massive_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[6];
            int[] myArray_1 = new int[6];
            //int zeroCount = 0;
            int j = 0;

            //massivi daxil etdik
            Console.WriteLine("Massivi daxil edin: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massiv [{i}]:");
                myArray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] != 0)
                {
                    myArray_1[j] = myArray[i];
                    j++;
                }

            }
            for (; j < myArray_1.Length; j++)
            {
                myArray_1[j] = 0;

            }

            Console.WriteLine($"Olari sona atilmis massiv  :");
            foreach (var item in myArray_1)
            {
                Console.Write(item + " ");
            }

        }
    }
}
