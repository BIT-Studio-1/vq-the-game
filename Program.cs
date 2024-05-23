using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    internal class Program
    {
        public static int EnemyHealth, Health, Damage;
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
            Room1();

        }


        static void Room1()
        {
            Console.WriteLine("You are in Room 1");
            Thread.Sleep(1000);
            Console.WriteLine("Your environmental impact of printing off rain forests of paper for your math exams, has enraged the office lady who appears to be a blob of glue and staplers for hands ");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\n Room 4");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your are already here\n");
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }

        static void Room2()
        {
            Console.WriteLine("You are in Room 2");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Console.WriteLine("You are already here\n");
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }

        static void Room3()
        {
            Console.WriteLine("You are in Room 3");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Console.WriteLine("You are already here\n");
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }

        static void Room4()
        {
            Console.WriteLine("You are in Room 4");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Console.WriteLine("You are already here\n");
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }
        static void Hallway()
        {
            Console.WriteLine("You are in the hallway");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Console.WriteLine("You are already here\n");
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }
        static void JanitorsCloset()
        {
            Console.WriteLine("You are in you are in the Janitors Closet");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    Console.WriteLine("You are already here\n");
                    JanitorsCloset();
                    break;
                case 7:
                    Lift();
                    break;
            }
        }
        static void Lift()
        {
            Console.WriteLine("You are in the Lift");
            Console.WriteLine("Room 1\nRoom 2\nRoom 3\nRoom 4\nHallway\nJanitorsCloset\nLift");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Room1();
                    break;
                case 2:
                    Room2();
                    break;
                case 3:
                    Room3();
                    break;
                case 4:
                    Room4();
                    break;
                case 5:
                    Hallway();
                    break;
                case 6:
                    JanitorsCloset();
                    break;
                case 7:
                    Console.WriteLine("You are already here\n");
                    Lift();
                    break;
            }
        }
        static void fight()
        {
            Random random = new Random();
            Console.WriteLine("1: Attack\n2: Heal");
            int option = Convert.ToInt32(Console.ReadLine());
            int hit = random.Next(101);
            switch (option)
            {
                case 1:

                    Console.WriteLine("1: Extreme hit\n2: Hard hit\n3: Easy hit\n4:Weak hit");
                    int attack = Convert.ToInt32(Console.ReadLine());
                    switch (attack)
                    {
                        case 1:
                            Damage = 30;

                            if (hit > 75)
                            {
                                Console.WriteLine($"You hit and did {Damage}");
                                EnemyHealth = EnemyHealth - Damage;
                                if (EnemyHealth > 0)
                                {
                                    Console.WriteLine($"The enemy has {EnemyHealth}hp left");
                                }
                                else
                                {
                                    Console.WriteLine($"The enemy has 0 hp");
                                }
                            }
                            break;
                        case 2:
                            Damage = 20;
                            hit = random.Next(101);
                            if (hit > 50)
                            {
                                Console.WriteLine($"You hit and did {Damage}");
                                EnemyHealth = EnemyHealth - Damage;
                                if (EnemyHealth > 0)
                                {
                                    Console.WriteLine($"The enemy has {EnemyHealth}hp left");
                                }
                                else
                                {
                                    Console.WriteLine($"The enemy has 0 hp");
                                }
                            }
                            break;
                        case 3:
                            Damage = 10;
                            hit = random.Next(101);
                            if (hit > 25)
                            {
                                Console.WriteLine($"You hit and did {Damage}");
                                EnemyHealth = EnemyHealth - Damage;
                                if (EnemyHealth > 0)
                                {
                                    Console.WriteLine($"The enemy has {EnemyHealth}hp left");
                                }
                                else
                                {
                                    Console.WriteLine($"The enemy has 0 hp");
                                }
                            }
                            break;
                        case 4:
                            Damage = 5;
                            hit = random.Next(101);
                            if (hit > 1)
                            {
                                Console.WriteLine($"You hit and did {Damage}");
                                EnemyHealth = EnemyHealth - Damage;
                                if (EnemyHealth > 0)
                                {
                                    Console.WriteLine($"The enemy has {EnemyHealth}hp left");
                                }
                                else
                                {
                                    Console.WriteLine($"The enemy has 0 hp");
                                }
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
