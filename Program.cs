using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Room Number(TD224 Or AGSE111): ");
            string RoomNumber = Console.ReadLine();
            
            try {
                if(RoomNumber != "TD224" && RoomNumber != "AGSE111")
                {
                    throw new Exception();
                }
            }
            catch
            {
                System.Console.WriteLine("Wrong Room Number, try again");
            }

            Console.Write("Please Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.Write("Please Enter Date Entered the Room (MM/DD/YY): ");
            

            try
            {
                DateTime DateEntered = DateTime.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Wrong datatype was entered, {ex.Message}, Please try again");
        
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message},let's Do it again ");
                System.Environment.Exit(1);
            }

            Console.Write("Please Enter Time Entered the Room(HH:MM): ");
            try
            {
                DateTime TimeEntered = DateTime.Parse(Console.ReadLine());

            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message},let's Do it again ");
                System.Environment.Exit(1);
            }
            
            Console.Write("Please Enter the time stayed in the Room: ");
            int TimeStayed = int.Parse(Console.ReadLine());           


        }
    }
}
