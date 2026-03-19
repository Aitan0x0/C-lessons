//massivin sonuna , evveline ve istenilen indeksine element (eded) elave eden kod (yoxlamalarsizdir)

namespace Add_element_in_massive_c_
{
    internal class Program
    {
        /// <summary>
        /// Massivin evveline daxil edilen ededi yazir
        /// </summary>
        /// <param name="myArray"></param>
        /// <param name="firstNum"></param>
        static void AddFirst(ref int[] myArray, int firstNum)
        {
            int newSize = myArray.Length + 1;
            int[] newArray = new int[newSize];
            newArray[0] = firstNum;
            for (int i = 1; i < newSize; i++)
            {
                newArray[i] = myArray[i - 1];
            }
            myArray = newArray;
        }

        /// <summary>
        /// massivin sonuna daxil edilen  ededi yazir
        /// </summary>
        /// <param name="myArray"></param>
        /// <param name="lastNum"></param>
        static void AddLast(ref int[] myArray, int lastNum)
        {
            int newSize = myArray.Length + 1;
            int[] newArray = new int[newSize];
            newArray[newSize - 1] = lastNum;
            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray;
        }

        /// <summary>
        /// Daxil edileren indexde yeni ededi daxil edir 
        /// </summary>
        static void AddByIndex(ref int[] myArray, int index, int indexNum)
        {
            int newSize = myArray.Length+1;
            int[] newArray = new int[newSize];
            newArray[index] = indexNum; 
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index+1; i < newSize; i++)
            {
                newArray[i] = myArray[i-1];

            }
            myArray = newArray; 
        }

        static void Main(string[] args)
        {


            Console.Write("Massivin olcusunu daxil edin: ");
            int size = int.Parse(Console.ReadLine());
            int[] myArray = new int[size];
            Console.WriteLine("Massivi daxil edin: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Massivin {i} elementi:");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Evveline elave olunacaq ededi daxil edin: ");
            int firstNum = int.Parse(Console.ReadLine());
            AddFirst(ref myArray, firstNum);
            Console.WriteLine();
            Console.Write("Sonuna elave olunacaq ededi daxil edin: ");
            int lastNum = int.Parse(Console.ReadLine());
            AddLast(ref myArray, lastNum);
            Console.WriteLine();
            Console.WriteLine("(1/2) Yeni massiv: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massvin [{i}] indexli elementi: {myArray[i]}");
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.Write("Massive eded elave etmek istediyiniz indexin nomresini daxil edin: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Hemin indexe elave etmek istediyiniz ededi daxil edin: ");
            int indexNum = int.Parse(Console.ReadLine());   
            AddByIndex(ref myArray, index, indexNum);
            //Yekun massiv
            Console.WriteLine();
            Console.WriteLine("(2/2) Yekun massiv: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massvin [{i}] indexli elementi: {myArray[i]}");
                Console.WriteLine();
            }










        }
    }
}
