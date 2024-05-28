using System;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    internal class Program
    {
<<<<<<< HEAD
        public static int EnemyHealth = 20, Health = 57, Damage, filament = 49;
=======
        public static int EnemyHealth = 20, Health = 57, Damage;
        public static double armour = 0;
        public static double weapon = 0;
        public static double xp = 0;

>>>>>>> a1a0ff4fd75d938175cd7d61fd597416abf2f8ad
        static void Main(string[] args)
        {
            Start();
        }


        static void Equiptment()
        {

            if (weapon == 0.5)
            { 
            Console.WriteLine("You have no weapon");
            }

            else if (weapon == 1)
            {
                Console.WriteLine("You have weapon 1");
            }

            else if (weapon == 1.5)
            {
                Console.WriteLine("You have weapon 2");
            }

            else if (weapon == 2)
            {
                Console.WriteLine("You have weapon 3 (Highest Level)");
            }


            if (armour == 0.1)
            {
                Console.WriteLine("You have no Armour");
            }

            else if (armour == 0.5)
            {
                Console.WriteLine("You have Vaughn boots, maybe you should go tramping");
            }

            else if (armour == 1)
            {
                Console.WriteLine("You have Ginmail");
            }

            else if (armour == 1.5)
            {
                Console.WriteLine("You have weapon ResinRanger Rain Coat ");
            }

            else if (armour == 2)
            {
                Console.WriteLine("You have PLA Power Vest (Highest Level)");
            }



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
        static void closet()
        {
            Console.WriteLine("You are in Janitor Closet");
            
            Console.WriteLine("You enter a dark gloomy room, Krissi appears from the shadows.");
            Console.WriteLine("Vaughn... Have you brought me a pen?? If you would like you see your boots again, I would a pen in return. \n I trust you would have grabbed one from the hallway");
            //Add function in here
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "closet":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    closet();
                    break;
                case "hallway":
                    hallway();
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
                    office();
                    break;
                case "broom1":
                    broom1();
                    break;
                case "broom2":
                    broom2();
                    break;
            }
        }
        static void printerRoom(){
            //welcome to the room ect
            Console.WriteLine("1. to make a Wepeon\n2. to make Armor");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("1. Plastic Saber - Low damage (25 Filliment)\n 2. Filament Fencer - medium damage (50 Filliment)\n3. Resin Rapier - highest Damage (100 filliment)");
                choice = Convert.ToInt32(Console.ReadLine());
                if ((choice == 1)||(filament <= 25)) 
                { 

                }
            }
            else if (choice == 2)
            {
                //what 
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
