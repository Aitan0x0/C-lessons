//Massivden ilk son ve daxil edilen indekse uygun olaraq elementi silen metodlar kodu

namespace Remove_element_in_massive_c_
{
    internal class Program
    {

        /// <summary>
        /// massivin ilk reqemini silen metod
        /// </summary>
        /// <param name="myArray"></param>
        static void RemoveFirst(ref int[] myArray)
        {
            int size = myArray.Length - 1;
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = myArray[i + 1];
            }

            myArray = newArray;
        }

        /// <summary>
        /// Massivde sonuncu elementi silir
        /// </summary>
        /// <param name="myArray"></param>
        static void RemoveLast(ref int[] myArray)
        {
            int size = myArray.Length - 1;
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray; 
        }

        /// <summary>
        /// Daxil edilen indexe uygun elementi massivden silir
        /// </summary>
        /// <param name="myArray"></param>
        static void RemoveByIndex(ref int[] myArray , int selectedIndex)
        {
            int size = myArray.Length - 1;
            int[] newArray = new int[size];
            for (int i = 0; i < selectedIndex; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = selectedIndex; i < size; i++)
            {
                newArray[i] = myArray[i+1];

            }
            myArray = newArray; 
        }



        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Massivin olcusunu daxil edin (en azi 4 daxil edin): ");
            while (size <= 3)
            {
                size = int.Parse(Console.ReadLine());
                if (size > 3)
                    break;
                Console.Write("Yeniden daxil edin: ");
                Console.WriteLine();
            }



            int[] myArray = new int[size];
            Console.WriteLine("Massivi daxil edin: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Massivin [{i}] indexli elementi: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            RemoveFirst(ref myArray);
            RemoveLast(ref myArray);
            Console.WriteLine("Sonundan ve evvelinden element silindikden sonra yeni massiv: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massivin [{i}] indexli elementi: {myArray[i]}");
                Console.WriteLine();
            }
            Console.WriteLine("Element silmek istediyiniz indexi daxil edin: ");

            int selectedIndex = int.MinValue;
            while (selectedIndex<0 || selectedIndex>=myArray.Length)
            {

               selectedIndex =  int.Parse(Console.ReadLine());
                if (selectedIndex < myArray.Length && selectedIndex >= 0)
                    break;
                Console.WriteLine("Yeniden cehd edin: ");

            }

            RemoveByIndex(ref myArray , selectedIndex);

            Console.WriteLine("Yekun massiv: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massivin [{i}] indexli elementi: {myArray[i]}");
                Console.WriteLine();
            }

        }
    }
}
