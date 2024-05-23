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
            Console.WriteLine("Do you want to enter the room(1,2,3,4)?");
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
            }

        }


        static void Room1()
        {
            Console.WriteLine("Do you want to leave the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Start();
                    break;
            }
        }

        static void Room2()
        {
            Console.WriteLine("Do you want to leave the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Start();
                    break;
            }
        }

            static void Room3()
        {
            Console.WriteLine("Do you want to leave the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Start();
                    break;
            }
        }

        static void Room4()
        {
            Console.WriteLine("Do you want to leave the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Start();
                    break;
            }
        }
    }
}
