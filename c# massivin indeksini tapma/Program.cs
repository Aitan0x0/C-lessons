//daxil edilen massivde gosterilen ededin massivdeki indexsini qaytaran , max ve min yerini deyisen , menfileri massivden cixaran tapsiriq



namespace c__massivin_indeksini_tapma
{
    internal class Program
    {
        static int FindIndex(int num, int[] myArray)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                if (num == myArray[i])
                {
                    return i;
                }

            }
            return -1;
        }

        static void SwapMinMax(int[] myArray)
        {
            int maxNum = myArray.Max();
            int minNum = myArray.Min();
            //int[] swapArray = new int[myArray.Length];
            int minIndex = 0, maxIndex = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (maxNum == myArray[i])
                {
                    maxIndex = i;
                }
                else if (minNum == myArray[i])
                {
                    minIndex = i;
                }
            }
            int temp = myArray[maxIndex];
            myArray[maxIndex] = myArray[minIndex];
            myArray[minIndex] = temp;


            Console.WriteLine("Max min yerini deyismis massiv:");
            foreach (var item in myArray)
            {
                Console.Write(item + "\t");
            }


        }

        static void DeleteMinus (int[] myArray)
        {
            int positiveNumCount = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= 0)
                {
                    positiveNumCount++;
                }
            }

            int[] positiveArray = new int[positiveNumCount];
            int j = 0;
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] >= 0)
                {
                    positiveArray[j] = myArray[i];
                    j++;
                }
            }
            Console.WriteLine("Menfiler cixarilmis massiv :");
            foreach (var item in positiveArray)
            {
                Console.Write(item + "\t"); 
            }

        }

        static void Main(string[] args)
        {

            int[] myArray = new int[8];
            int selectNum;

            Console.WriteLine("Massivi daxil edin (tam ededler olsun): ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massiv {i}/{myArray.Length-1}: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.Write("Indexi axtarilan ededi daxil edin:");
            selectNum = int.Parse(Console.ReadLine());
            int result = FindIndex(selectNum, myArray);
            if (result != -1)
            {
                Console.WriteLine($"{selectNum} ededinin indexi: {result}");
            }
            else
            {
                Console.WriteLine("Massivde bele eded yoxdur");

            }

            Console.WriteLine();
            SwapMinMax(myArray);
            Console.WriteLine();
            DeleteMinus(myArray);

        }
    }
}
