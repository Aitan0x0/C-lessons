//string massivde en uzununu tapan ve ters ceviren proqram

namespace String_massivw
{
    internal class Program
    {

        static void LongerString(string[] myArray)
        {
            string maxString = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (maxString.Length < myArray[i].Length)
                    maxString = myArray[i];
            }
            Console.Write($"Massivdeki uzun string : {maxString} - > {maxString.Length} simvol");
        }

        static string[] SwapArray(string[] myArray)
        {
            string[] swapArray = new string[myArray.Length];
            int j = 0;
            for (int i = myArray.Length-1; i >= 0; i--)
            {
                
                    swapArray[j] = myArray[i];
                j++;
                
            }
            return swapArray; 

        }
        static void Main(string[] args)
        {
            string[] myArray = new string[4];
            Console.WriteLine("String massiv daxil edin:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Massivin {i}/{myArray.Length - 1}: ");
                myArray[i] = Console.ReadLine();

            }

            Console.WriteLine();
            //Console.Write($"Massivdeki uzun soz:");
            LongerString(myArray);
            Console.WriteLine();
            Console.Write("Ters yazilmis array: ");
            string[] swapArr = SwapArray(myArray);
            foreach (var item in swapArr)
            {
                Console.Write(item + "\t");
            }
           

        }
    }
}
