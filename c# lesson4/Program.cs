//10 addimli komputerin secdiyi random ededi tapma oyunu

namespace c__lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            //1den 100cen eded secir
            int rnd_num = random.Next(1, 101);
            //addim sayi deyek
            int step = 1;
            int find_num = 0; // ilkin deyer 

            //istifadeciden reqem alaq
            Console.WriteLine("1 ve 100 arasindan secilen ededi texmin edin");

            while (find_num != rnd_num && step < 11)
            {
                Console.WriteLine("Addim:" + step + "/10");
                //reqem olub olmadigini yoxlayaq
                bool num_bool = int.TryParse(Console.ReadLine(), out find_num);
                if (!num_bool)
                {
                    Console.WriteLine("Reqem duzgun daxil edilmeyib");
                    return;
                }

                if (find_num > rnd_num)
                {
                    Console.WriteLine("Kicik eded secin");
                }
                else if (find_num < rnd_num)
                {
                    Console.WriteLine("Boyuk eded secin");
                }
                else
                {
                    Console.WriteLine("Tebrikler cavab dogrudur!");
                }
                step++;

            }

            //addim sayi bitende xeber edir
            if (step >= 11)
            {
                Console.WriteLine("-- Addim sayi bitdi -- Tutulmus eded:" + rnd_num );
            }



        }
    }
}
