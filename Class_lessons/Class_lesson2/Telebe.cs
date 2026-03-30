using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lesson2
{
    internal class Telebe
    {
        public string name = " ";
        public string surname = " ";
        private int fizBal = 0, kimyaBal = 0, riyBal = 0;

        //konstruktor
        public Telebe(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Telebe(string name, string surname, int fizBal, int kimyaBal, int riyBal)
            : this(name, surname)
        {
            this.fizBal = fizBal;
            this.riyBal = riyBal;
            this.kimyaBal = kimyaBal;
        }


        //orta bal hesablayan metod
        public float OrtalamaBal()
        {
            float result = 0;
            result = (fizBal + riyBal + kimyaBal) / 3;
            return result;
        }

        //telebenin adini cap eden petod
        public void PrintName()
        {
            Console.WriteLine($"Telebe: {name}  {surname}");
        }






        public int KimyaBal
        {
            get { return kimyaBal; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;

                kimyaBal = value;
            }
        }

        public int FizikaBal
        {
            get { return fizBal; }
            set
            {
                if (value > 150)
                    value = 150;
                else if (value < 0)
                    value = 0;

                fizBal = value;
            }
        }
        public int RiyaziyyatBal
        {
            get { return riyBal; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;

                riyBal = value;
            }
        }

    }
}
