using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lesson1
{
    class Book
    {
        public string title;
        public string author;
        public int pageCount;


        public void GetInfo()
        {
            Console.WriteLine($"'{title}' - {author} , {pageCount} sehife");


        }

    }

    class Hero
    {
        public string name;
        public string type;
        public int level;
        public int health;

        public Hero(string _name, string _type)
        {
            name = _name;
            type = _type;
            level =  1;
            health = 100;
        }



        /// <summary>
        /// Level atlayir
        /// </summary>
        public void LevelUp()
        {
            if (level < 5)
            {

                level = level + 1;
                Console.WriteLine($"{level} levele atladiniz!");

            }
            else
            {
                Console.WriteLine($"Max leveldesiniz");


            }

        }



        /// <summary>
        /// Heros status
        /// </summary>
        public void ShowStatus()
        {

            Console.WriteLine("Karakterin statusu:");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Type : {type}");
            Console.WriteLine($"Lvl : {level}");
            Console.WriteLine($"Health: {health}");

        }

    }


}
