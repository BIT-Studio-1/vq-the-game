namespace vg_the_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }


        static void Start()
        {
            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin! \n So you can go home and have a great weekend!");
            Console.WriteLine("Do you want to enter the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Room1();
            }

        }


        static void Room1()
        {
            Console.WriteLine("Do you want to leave the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("your win");
                    break;
            }
        }


    }
}
