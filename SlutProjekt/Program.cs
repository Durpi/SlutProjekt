using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();
            bool playing = true;

            while (playing == true)
            {
                int userHp = generator.Next(30, 40);
                int userAttack = generator.Next(6, 8);
                int originalUserHp = userHp;

                bool alive = true;

                Console.WriteLine("Please write a name to your character (4-16 letters and no numbers)");
                string username = Console.ReadLine();
                
                bool checkUsername = username.All(char.IsDigit);

                while (checkUsername == false && username.Length >= 16 && username.Length <= 4)
                {
                    Console.WriteLine("Please write with 4-16 characters and no numbers");
                    username = Console.ReadLine();
                    
                    checkUsername = username.All(char.IsDigit);
                }

                while (alive == true)
                {

                    Console.WriteLine("You are now inside the dungeon");
                    Console.WriteLine("You meet a monster and fight it");

                    int monsterHp = generator.Next(30, 40);
                    int monsterAttack = generator.Next(6, 8);


                    Console.WriteLine(username + " has " + userHp + " right now" +
                        "\nThe moster has " + monsterHp + " right now");

                    while (monsterHp == 0 || userHp == 0)
                    {
                        Thread.Sleep(4000);

                        monsterHp = monsterHp - userAttack;
                        userHp = userHp - monsterAttack;
                        Console.WriteLine("User hp dropped down to " + userHp +
                            "\nThe monsters hp dropped down to " + monsterHp);
                        Thread.Sleep(3000);
                        if (monsterHp < 0)
                        {
                            monsterHp = 0;
                        }
                        if (userHp < 0)
                        {
                            userHp = 0;
                        }
                    }
                    if (userHp <= 0 && monsterHp <= 0)
                    {
                        Console.WriteLine("you survive but use all your strength to heal youtself");
                        userHp = originalUserHp;
                    }
                    else if (userHp <= 0)
                    {
                        alive = false;
                    }
                    else if (monsterHp <= 0)
                    {
                        userHp = originalUserHp;
                        userAttack++;
                    }


                }

                if (alive == false)
                {
                    Console.WriteLine("Do you want to play again? [yes][no]");

                    string replay = Console.ReadLine().ToLower().Trim();

                    while (replay != "yes" || replay != "no")
                    {
                        replay = Console.ReadLine().ToLower().Trim();
                    }

                    if (replay == "yes")
                    {
                        playing = true;
                    }

                    if (replay == "no")
                    {
                        playing = false;
                    }


                }

                Console.ReadLine();
            }
            
        }
    }
}
