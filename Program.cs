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
