using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            int hp = generator.Next(30, 40);
            int attack = generator.Next(6, 8);

            bool alive = true;

            Console.WriteLine("Please write a name to your character (4-16 letters and no numbers)");
            string username = Console.ReadLine();

            int check;
            bool checkUsername = int.TryParse(username, out check);

            while (checkUsername == true || username.Length >= 16 || username.Length <= 4)
            {
                username = Console.ReadLine();

                
                checkUsername = int.TryParse(username, out check);
            }

            while (alive == true)
            {

                Console.WriteLine("You are now inside the dungeon");


            }

            Console.ReadLine();
        }
    }
}
