using System;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    internal class Program
    {
        public static int EnemyHealth = 20, Health = 57, Damage;
        static void Main(string[] args)
        {
            Start();
        }


        static void Inventory()
        {
            int[] items = { };
        }


        static void Start()
        {

            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin!\nSo you can go home and have a great weekend!");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            office();
            fight();
        }

        //admin/office - item room
        static void office()
        {
            Console.WriteLine("You are in the Office");
            Thread.Sleep(1000);
            Console.WriteLine("Your environmental impact of printing off rain forests of paper for your math exams, has enraged the office lady who appears to be a blob of glue and staplers for hands ");
            Console.WriteLine();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "office":
                    Console.WriteLine("Your are already here\n");
                    office();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        //Janitor Closet 
        static void Closet()
        {
            Console.WriteLine("You are in Room 2");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case :
                    Room1();
                    break;

            }
        }


        //Boss Room
        static void broom1()
        {
            Console.WriteLine("You are in BOSS ROOM 1 TEMPORARY NAME");
            Console.WriteLine("broom1 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom1":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom1();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        //Boss Room
        static void broom2()
        {
            Console.WriteLine("You are in BOSS ROOM 2 TEMPORARY NAME");
            Console.WriteLine("broom2 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    broom2();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        static void hallway()
        {
            Console.WriteLine("You are in the Hallway");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            //Pen in the hallway
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hallway":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    hallway();
                    break;
                case "office":

                case "broom1":

                case "broom2":

            }
        }
        static void fight()
        {
            Random random = new Random();
            do
            {
                Console.WriteLine("1: Attack\n2: sleep");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:// this is the option for attacking
                        attack();
                        break;
                }
                Console.WriteLine($"The enemy has {EnemyHealth} HP left, and you have {Health} HP left");
            } while ((Health > 0) && (EnemyHealth > 0));


            static void attack()
            {
                Random random = new Random();
                int hit = random.Next(101);/// generate a random number between 1-100 this will be used to get the success or faliure of the hit
                Console.WriteLine("1: Extreme hit\n2: Hard hit\n3: Easy hit\n4: Weak hit");//this gives the user the option to select what type of attack they want to do
                int attack = Convert.ToInt32(Console.ReadLine());
                switch (attack)
                {
                    case 1://this is the hardest attack to hit so it has the highest damage
                        Damage = 30;
                        if (hit > 75)
                        {
                            Console.WriteLine($"You hit and did {Damage}");
                            EnemyHealth = EnemyHealth - Damage;
                        }
                        else
                        {
                            Console.WriteLine("You missed");
                        }
                        break;
                    case 2://this is the 2nd hardest attack to hit so it does the 2nd most damage the rest follow this pattern
                        Damage = 20;
                        hit = random.Next(101);
                        if (hit > 50)
                        {
                            Console.WriteLine($"You hit and did {Damage}");
                            EnemyHealth = EnemyHealth - Damage;
                        }
                        else
                        {
                            Console.WriteLine("You missed");
                        }
                        break;
                    case 3:
                        Damage = 10;
                        hit = random.Next(101);
                        if (hit > 25)
                        {
                            Console.WriteLine($"You hit and did {Damage}");
                            EnemyHealth = EnemyHealth - Damage;
                        }
                        else
                        {
                            Console.WriteLine("You missed");
                        }
                        break;
                    case 4:
                        Damage = 5;
                        hit = random.Next(101);
                        if (hit > 1)
                        {
                            Console.WriteLine($"You hit and did {Damage}");
                            EnemyHealth = EnemyHealth - Damage;
                        }
                        else
                        {
                            Console.WriteLine("You missed");
                        }
                        break;
                }
            }
            static void enemyAttack()
            {
                Random random = new Random();
                int hit = random.Next(101);/// generate a random number between 1-100 this will be used to get the success or faliure of the hit
                int enemyChoice = random.Next(5);
                Console.WriteLine(enemyChoice);
                switch (enemyChoice)
                {


                    case 1:
                        Damage = 30;
                        if (hit > 75)
                        {
                            Console.WriteLine($"enemyName hit and did {Damage}");
                            Health = Health - Damage;
                        }
                        else
                        {
                            Console.WriteLine("enemyName missed");
                        }
                        break;
                    case 2:
                        Damage = 20;
                        hit = random.Next(101);
                        if (hit > 50)
                        {
                            Console.WriteLine($"enemyName hit and did {Damage}");
                            Health = Health - Damage;
                        }
                        else
                        {
                            Console.WriteLine("enemyName missed");
                        }
                        break;
                    case 3:
                        Damage = 10;
                        hit = random.Next(101);
                        if (hit > 25)
                        {
                            Console.WriteLine($"enemyName hit and did {Damage}");
                            Health = Health - Damage;
                        }
                        else
                        {
                            Console.WriteLine("enemyName missed");
                        }
                        break;
                    case 4:
                        Damage = 5;
                        hit = random.Next(101);
                        if (hit > 1)
                        {
                            Console.WriteLine($"enemyName hit and did {Damage}");
                            Health = Health - Damage;
                        }
                        else
                        {
                            Console.WriteLine("enemyName missed");
                        }
                        break;
                }
            }
        }
    }
}
