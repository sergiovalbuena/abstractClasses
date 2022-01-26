using System;

namespace TicketProcessingApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tickets Processing App");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Ticket t;
            t = new Basketball();
            t.print();
            t = new Football();
            t.print();
            t = new Theater();
            t.print();
            t = new Comedy();
            t.print();
        }
    }

    public abstract class Ticket
    {
        public abstract void print();
    }

    public class Basketball : Ticket
    {
        public override void print()
        {
            Console.WriteLine("Basketball Match🏀");
            Console.Write("Price: $"); Console.WriteLine(20);
        }
    }
    public class Football : Ticket
    {
        public override void print()
        {
            Console.WriteLine("Football Match ⚽️");
            Console.Write("Price: $"); Console.WriteLine(18);
        }
    }
    public class Theater : Ticket
    {
        public override void print()
        {
            Console.WriteLine("Theater Event🎭");
            Console.Write("Price: $"); Console.WriteLine(22);
        }
    }
    public class Comedy : Ticket
    {
        public override void print()
        {
            Console.WriteLine("Comedy StandUp😂");
            Console.Write("Price: $"); Console.WriteLine(12);
        }
    }

}
