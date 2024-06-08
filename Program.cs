using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    public struct enemy
    {
        public string name;
        public int enemyHealth;
    }
    internal class Program
    {
        public static double EnemyHealth = 20, Health = 100, Damage, filament = 49, energy = 100;
        public static double armour = 0.1;
        public static double weapon = 0.5;
        public static double xp = 0;
        public static int pen = 0; 
        public static int roomid;
        public static double difficulty = 0.1;
        public static string EnemyName;
        public static double DamageMod = 1;
        public static int card = 0;

        //Room Visit ids
        public static int officeid = 0, hallwayintro = 0, closetid = 0, boom1id = 0, broom2id = 0;  //first floor 



        static void Main(string[] args)
        {
            Start();
        }

        static void will()//method to add a enemy copy this when adding someone to the game
        {
            enemy will;
            will.name = "Office Lady";//sets enemy name
            will.enemyHealth = 25;// sets enemy health
            EnemyHealth = will.enemyHealth;// overides the last enemies health
            EnemyName = will.name;
            DamageMod = 1;
        }
        static void BussinessGuy()
        {
            enemy BussinessStudent;
            BussinessStudent.name = "Bussiness Student";//sets enemy name
            BussinessStudent.enemyHealth = 20;// sets enemy health
            EnemyHealth = BussinessStudent.enemyHealth;// overides the last enemies health
            EnemyName = BussinessStudent.name;
            DamageMod = 1;
        }
        static void Krissi()
        {
            enemy Krissi;
            Krissi.name = "Krissi Wood";//sets enemy name
            Krissi.enemyHealth = 50;// sets enemy health
            EnemyHealth = Krissi.enemyHealth;// overides the last enemies health
            EnemyName = Krissi.name;
            DamageMod = 1.5;
        }
        static void printer()
        {
            enemy printer;
            printer.name = "3D Printer";//sets enemy name
            printer.enemyHealth = 30;// sets enemy health
            EnemyHealth = printer.enemyHealth;// overides the last enemies health
            EnemyName = printer.name;
            DamageMod = 1.25;
        }
        static void mathsStudent()
        {
            enemy mathStudent;
            mathStudent.name = "Deacon";//sets enemy name
            mathStudent.enemyHealth = 20;// sets enemy health
            EnemyHealth = mathStudent.enemyHealth;// overides the last enemies health
            EnemyName = mathStudent.name;
            DamageMod = 1.33;
        }
        static void Victor()
        {
            enemy Victor;
            Victor.name = "Victor";//sets enemy name
            Victor.enemyHealth = 75;// sets enemy health
            EnemyHealth = Victor.enemyHealth;// overides the last enemies health
            EnemyName = Victor.name;
            DamageMod = 1.6;
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
                armour = 0.5;
            }

            else if (armour == 1)
            {
                Console.WriteLine("You have Ginmail");
                armour = 1;
            }

            else if (armour == 1.5)
            {
                Console.WriteLine("You have weapon ResinRanger Rain Coat ");
                armour = 1.5;
            }

            else if (armour == 2)
            {
                Console.WriteLine("You have PLA Power Vest (Highest Level)");
                armour = 2;
            }
        }
        static void callroom()
        {
            switch (roomid)
            {
                case 0:
                    office();
                    break;
                case 1:
                    Start();
                    break;
                case 2:
                    hallway();
                    break;
                case 3:
                    closet();
                    break;
                case 4:
                    broom1();
                    break;
                case 5:
                    broom2();
                    break;
            }
        }


        static void Start()
        {
            Console.Clear();
            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin!\nSo you can go home and have a great weekend!");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            roomid = 0;
            office();
        }

        //admin/office - item room
        static void office()
        {
            if (officeid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }

            Console.Clear();
            roomid = 1;
            Console.WriteLine("You are in the Office");
            Thread.Sleep(1000);
            Console.WriteLine("Your environmental impact of printing off rain forests of paper for your math exams, has enraged the office lady who appears to be a blob of glue and staplers for hands ");
            Thread.Sleep(1000);
            Console.WriteLine("You must now fight your way out of this one!");
            Thread.Sleep(1000);
            Console.WriteLine("Press Enter to Begin the Fight!");
            officeid = 1; //prevents user from going back
            will(); //Will is known as the office lady
            fight(); //I believe this should be moved into the office yes you are correct i have moved it there now
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

        static void hallway()
        {
            string temp;
            int input;

            roomid = 2;
            Console.WriteLine("You are in the Hallway");
            Thread.Sleep(1000);
           
            if (hallwayintro == 0)
            {
                Console.WriteLine("You spot a pen lying on the ground, it seems appears to be the last Te Pūkenga BIT pen? ");
                Thread.Sleep(1000);
                Console.WriteLine("Would you like to pick up the pen (1) or leave it on the ground as there are better things to find (0)");
                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);

                if (input == 1)
                {
                    Console.WriteLine("You have picked up the pen");
                    pen = 1;
                    Console.ReadLine();
                }
                else
                {
                    pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                    Console.WriteLine("You choice not to pick up the pen it probably wasn't important");
                }
            }


            hallwayintro = 1;

            Console.WriteLine("You stand in the hallway you can navigate to the (office), (broom1), (broom2), (closet)"); //Need to rename broom1 and broom2
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
                case "closet":
                    closet();
                    break;
            }
        }

      

        //Janitor Closet 
        static void closet()
        {

            if (closetid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }


            Console.Clear();
            roomid = 3;
            Console.WriteLine("You are in Janitor Closet");
            Thread.Sleep(2000);
            Console.WriteLine("You enter a dark gloomy room, Krissi appears from the shadows.");
            Thread.Sleep(2000);
            Console.WriteLine("[Krissi]: Vaughn... Have you brought me a pen?? If you would like you see your boots again, I would a pen in return. \n I trust you would have grabbed one from the hallway");
            Thread.Sleep(2000);

            if (pen == 1)
            {
                Console.WriteLine("[Krissi]: Thank you for grabbing my pen, you know I am a true pen thief, thank you");
                Thread.Sleep(2000);
                Console.WriteLine("[Krissi]: Here are your special boots");
                Thread.Sleep(1000);
                armour = 0.5;
                Thread.Sleep(1000);
                Console.WriteLine("[YOU EQUPIED YOUR BOOTS]");
            }

            else
            {
                Console.WriteLine("[Krissi]: Disappointing you didn't bing me a pen how about you go else where"); //Change to Fight Code
                Krissi();
                fight();
            }

            closetid = 1;

            Console.WriteLine("Closet Hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "closet":
                    Console.WriteLine("You can't go back into a room you are already in! Try the hallway instead");
                    hallway();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        //Boss Room
        static void broom1()
        {
            string response;

            if (boom1id == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }



            //Angry Student Boss
            Console.Clear();
            roomid = 4;
            Console.WriteLine("[First Year Student]: Hi Vaughn, I was just wondering if you had marked my math exam?");
            Thread.Sleep(1000);
            Console.WriteLine("You can either respond with 'yes' or 'no'");
            response = Console.ReadLine();

            boom1id = 1;

            if (response == "yes")
            {
                Console.WriteLine("Yes, I'll get round to marking the math papers, I just have to find my gin");
            }
            else
            {
                Console.WriteLine("No!, I need to find my gin, I don't have time to mark math papers");
                //Add Boss fight to trigger as student is mad with Vaughn
            
            
            }



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
            string response;

            if (broom2id == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                hallway();
            }



            //Business Student Boss
            Console.Clear();
            roomid = 5;
            broom2id = 1;
            Console.WriteLine("You enter into a into one of the business studies class rooms");
            Thread.Sleep(1000);
            Console.WriteLine("The student comes over and begins trying to sell you crypto");
            Thread.Sleep(1000);
            Console.WriteLine("Do you wish to buy some crypto from the business studies student?");
            Thread.Sleep(1000);
            Console.Write("Yes or No?");
            response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("[Business Studies Student]: Great I will sign you up - business studies student");
                Thread.Sleep(3000);
                Console.WriteLine("[Business Studies Student]: Hey there! Want to skyrocket your bank account to the moon?");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: Well, hold onto your seatbelt because I've got something hotter than Elon's tweets: cryptocurrencies!");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: Picture this: you, sipping champagne on a yacht, courtesy of your crypto investments.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: Gone are the days of boring stocks and bonds. We're talking about digital gold, baby!");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: With crypto, you're not just an investor, you're a pioneer in the wild west of finance.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: And guess what? You don't need a fancy suit or a Wall Street address to get started.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: In the crypto world, everyone's welcome, from the hoodie-wearing tech geek to the hipster barista.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: So, what are you waiting for? Let's make those dreams of Lambos and private islands a reality!");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: Are you ready to dive into the crypto ocean with me?");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: Just imagine the thrill of riding the waves of Bitcoin highs and dodging the lows.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: It's like being a surfer on the biggest financial wave of the century!");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: And hey, even if you wipe out, there's always another wave waiting to lift you back up.");
                Thread.Sleep(3000); 
                Console.WriteLine("[Business Studies Student]: So, grab your board and let's catch that crypto wave together!");
            }
            else
            {
                Console.WriteLine("[Business Studies Student]: HOW DEAR YOU! YOU HAVEN'T EVEN LISTEND TO MY PITCH");
                //Trigger Boss
            }
            Console.WriteLine("broom2 hallway");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.WriteLine("You are already here press ENTER to continue");
                    Console.ReadLine();
                    //broom2();
                    Console.WriteLine("You can't go back into a room you are already in! Try the hallway instead");
                    hallway();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }


        
        //Second Floor

        static void hallway2()
        {
            Console.WriteLine("You are now on the 2nd floor");
            Console.WriteLine("You see three rooms:\n 3d printer room\n2. Studio room\n3. Maths Room\n4. Next floor\n Last floor");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    if (card == 1)
                    {
                        printerRoom();
                    }
                    else
                    {
                        Console.WriteLine("you need a card to unlock this room");
                    }
                    break;
                case 2:
                    studioRoom();
                    break;
                case 3:
                    mathsRoom();
                    break;

            }
        }
        static void mathsRoom()
        {

            Console.WriteLine("You entered the Maths Room\nDecain is there, He does not look happy");
            Console.WriteLine("You entered the Maths Room\nDecain is there, He does not look happy");
            Console.WriteLine("Vaughn you are making the tutorals a nightmare\nnone of the questions are esay");
            Console.WriteLine("what is  eiπ + ln(−1) = x2 +∫0∞​xsin(x)​dx");
            Console.ReadLine();
            Console.WriteLine("Wrong. I will have to tech you a lesson about maths");
            //matthew add fight
        }
        static void studioRoom()
        {
            Console.WriteLine("Vick is here\nhe asks a serious quesetion");
            Console.WriteLine("How many seasons of the Simpsons are there?");
            int temp = Convert.ToInt32(Console.ReadLine());

            //mathew add fight and at the end of the fight make the card value 1
        }


        static void printerRoom()
        {
            //welcome to the room ect
            Console.WriteLine("1. to make a Wepeon\n2. to make Armor");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("1. Plastic Saber - Low damage (25 Filliment)\n 2. Filament Fencer - medium damage (50 Filliment)\n3. Resin Rapier - highest Damage (100 filliment)");
                choice = Convert.ToInt32(Console.ReadLine());
                if ((choice == 1) || (filament <= 25))
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
            int charge = 0;
            Random random = new Random();
            do
            {
                Console.WriteLine($"You have {Health} HP and {energy} Energy.                                                          {EnemyName} has {EnemyHealth} HP");//Change to name from list
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Choose your move!: 1: Strong Attack \n2: Medium Attack \n3: Low Attack \n4: Charge Attack \n5: Gain Energy");

                int option = Convert.ToInt32(Console.ReadLine());
                int hit = random.Next(101);

                switch (option)
                {
                    case 1: if (energy >= 40) { energy -= 40; Damage = random.Next(30, 41); if (hit > 84) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Strong Attack"); break;
                    case 2: if (energy >= 20) { energy -= 20; Damage = random.Next(19, 32); if (hit > 50) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Medium Attack"); break;
                    case 3: if (energy >= 10) { energy -= 10; Damage = random.Next(9, 22); ; if (hit > 25) EnemyHealth -= Damage; else Console.WriteLine("You missed"); } else Console.WriteLine("you dont have enough energy for the Low Attack"); break;
                    case 4: if (charge == 3) { Damage = random.Next(50, 80); EnemyHealth -= Damage; } else charge++; break;
                    case 5: int energyGained = random.Next(1, 50); energy = Math.Min(100, energy + energyGained); break;
                }

                if (EnemyHealth > 0) enemyAttack(); // Enemy attacks only if it's still alive
                Console.WriteLine("\n\n");
            } while (Health > 0 && EnemyHealth > 0);

            if (Health <= 0)
            {
                Console.WriteLine("You have been defeated. Game Over.");
                Console.ReadLine();
                if (difficulty > 1)
                {
                    hallway();
                }
                else
                {
                    Start();
                }

            }
            else if (EnemyHealth <= 0)
            {
                Console.WriteLine("You have defeated the enemy!");
                // Implement logic to reward the player or move to the next part of the game

                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                difficulty++;
                Console.Clear();
                Console.WriteLine("You've been kicked out into the hallway"); //Added here since you get kicked out here everytime to kill a boss
                hallway();


            }
        }

        static void enemyAttack()
        {
            Random random = new Random();
            int hit = random.Next(101);
            int enemyChoice = random.Next(1, 5);

            switch (enemyChoice)
            {
                case 1: Damage = 30; if (hit > 75) Health -= Damage; else Console.WriteLine("Enemy missed"); break;//replace enemy name with one from a list
                case 2: Damage = 20; if (hit > 50) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 3: Damage = 10; if (hit > 25) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
                case 4: Damage = 5; if (hit > 1) Health -= Damage; else Console.WriteLine("Enemy missed"); break;
            }
        }
    }
}