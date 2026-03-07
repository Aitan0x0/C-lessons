//massivde diaqonal ve ters diaqonal uzerindeki ededler cemi , ikinci max eded

namespace c__Matris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //massivi mueyyen edek
            int[,] myMatris = new int[3, 3];
            int diaqonalSum =0 , tersDiaqonalSum = 0;
           

            //diaqonali daxil edek 
            for (int i = 0; i < myMatris.GetLength(0); i++)
            {
                for (int j = 0; j < myMatris.GetLength(1); j++)
                {
                    Console.WriteLine($"Index: ({i},{j}) ");
                    myMatris[i, j] = int.Parse(Console.ReadLine());

                }
            }

            //ekrana verek 
            Console.WriteLine();
            Console.WriteLine("Matris:");
            int maxNum = int.MinValue;
            int secondMaxNum = int.MinValue;

            for (int i = 0; i < myMatris.GetLength(0); i++)
            {
                for (int j = 0; j < myMatris.GetLength(1); j++)
                {
                    Console.Write(myMatris[i,j] + "\t");
                    if (maxNum < myMatris[i, j])
                    {
                        secondMaxNum = maxNum;
                        maxNum = myMatris[i, j];
                    }
                    else if (maxNum > myMatris[i,j] && myMatris[i,j] > secondMaxNum)
                    {
                        secondMaxNum = myMatris[i, j];
                    }

                    if (j == (myMatris.GetLength(1) - 1) - i)
                    {
                        tersDiaqonalSum += myMatris[i, j];
                    }
                    if(i == j)  //ve ya sadece diaqonalSum = myMatris[i,i]; de yazmaq olar
                    {
                        diaqonalSum += myMatris[i, j];
                    }

                }
                Console.WriteLine();
            }
        


            Console.WriteLine();
            Console.WriteLine($"Diaqonal ededlerinin cemi: {diaqonalSum}");
            Console.WriteLine($"Ters diaqonal ededlerinin cemi: {tersDiaqonalSum}");
            Console.WriteLine($"Matrisdeki max eded: {maxNum}");
            Console.WriteLine($"Matrisdeki ikinci max eded: {secondMaxNum}");


            //ters diaqonal cemi 





        }
    }
}
