﻿namespace vg_the_game
{
    internal class Program
    {
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

            Console.WriteLine("Do you want to enter the room(1,2,3,4)?");
            Console.WriteLine("You are the one and only Vaughn Malkin. \nYou wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine("Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\nYou realise you are missing your trusty bottle of gin");
            Thread.Sleep(2000);
            Console.WriteLine("Your mission. Find your bottle of Gin!\nSo you can go home and have a great weekend!");
            Console.WriteLine("Do you want to enter the room(1)?");
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
                    Room1();
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
                    Room1();
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
                    Room1();
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
                    Room1();
                    break;
            }
        }
    }
}
