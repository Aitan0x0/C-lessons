//massivin olcusunu azaldim artiran metof (ref ile0

namespace Resize_massive_c_
{
    internal class Program
    {
        /// <summary>
        /// Massivi azaldib , boyude bilir
        /// </summary>
        /// <param name="newSize"></param>
        /// <param name="myArray"></param>
        static void ReSize(int newSize, ref int[] myArray)
        {
            int[] newArray = new int[newSize];
            int limit = Math.Min(newSize, myArray.Length);

            for (int i = 0; i < limit; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 5, 5 };

            Console.Write("Massiv budur: ");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Massivi istediyiniz olcusunu daxil edin (artib,azaltmaq): ");
            int newSize = int.Parse(Console.ReadLine());
            ReSize(newSize, ref myArray);
            Console.WriteLine();
            Console.Write("Yeni Massiv: ");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
