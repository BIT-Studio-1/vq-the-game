namespace vg_the_game
{
    internal class Program
    {
        static void room1()
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
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to enter the room(1)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                room1();
            }
        }
    }
}
