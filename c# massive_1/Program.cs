//massivleri klaviatura ile daxil etmek ,  ters qaydada cixarmaq , cut ededlerin cemi

namespace c__massive_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //massivin uzunlugu daxil edilir ve yoxlanilir
            Console.Write("Massivin uzunlugunu daxil edin: ");
            bool length_bool = int.TryParse(Console.ReadLine(), out int index);
            while (!length_bool || index <= 0)
            {
                Console.WriteLine("Uzunluq duzgun daxil edilmeyib , zehmet olasa yeniden cehd edin!");
                length_bool = int.TryParse(Console.ReadLine(), out index);

                continue;
            }

            int[] myArray = new int[index];

            //massiv menimsedilir
            Console.WriteLine("\nMassivi daxil edin:");
            for (int i = 0; i < index; i++)
            {
                Console.Write($"Massiv [{i}] = ");
                bool element_bool = int.TryParse(Console.ReadLine(), out int element);
                while (!element_bool)
                {
                    Console.WriteLine("Massiv elementi duzgun daxil edilmeyib.Eded daxil edin");
                    Console.Write($"Massiv [{i}] = ");
                    element_bool = int.TryParse(Console.ReadLine(), out element);
                    continue;

                }
                myArray[i] = element;
            }


            //massivin tersini cap edir
            Console.Write("\nDaxil edilen massivin tersi:");

            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write($"{myArray[i]} ");
            }

            //massivde cut ededleri ve onlarin cemini tapmaq
            int evenSum = 0;
            bool hasEvenNum = false;

            Console.WriteLine();
            Console.Write("Massiv daxilindeki cut ededler:");
            for (int i = 0; i < index; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    hasEvenNum = true;
                    Console.Write($"{myArray[i]} ");
                    evenSum += myArray[i];
                }

            }
            if (!hasEvenNum)
            {
                Console.Write(" Massivde cut eded yoxdur!");
            }
            Console.WriteLine();
            Console.Write($"Massivdeki cut ededlerin cemi: {evenSum}");

            //massiv daxilindeki min eded tapilir
            int minElem = myArray[0]; //massivin ilk reqemini default goturek

            for (int i = 1; i < index; i++)
            {
                if (myArray[i] < minElem)
                    minElem = myArray[i];

            }
            Console.WriteLine();
            Console.WriteLine($"Massivdeki minimum eded: {minElem}");
        }
    }
}