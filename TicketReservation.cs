using System;
using System.Collections.Generic;

public class Program
{

    public static void Main()
    {
        IDictionary<string, string> ticketlist = new Dictionary<string, string>();

        while (true)
        {
            System.Console.WriteLine("=======================================");
            System.Console.WriteLine("Welcome to Ticket Reservation System:");
            System.Console.WriteLine("Enter:");
            System.Console.WriteLine("1. Book A ticket");
            System.Console.WriteLine("2. Cancel A Booking");
            System.Console.WriteLine("3. See The booked Tickets:");
            System.Console.WriteLine("4. Exit");
            String choice = Console.ReadLine();
            if (choice == "1")
            {
                customer c1 = new customer();
                tickets t1 = new tickets();
                System.Console.WriteLine("Enter Your Username:");
                c1.username = Console.ReadLine();
                System.Console.WriteLine("Enter Your Phone Number:");
                c1.phone = Console.ReadLine();
                c1.enrollment++;
                ticketlist.Add(c1.username, (t1.ticketnumber).ToString());
                System.Console.WriteLine("Ticket Booked: " + ticketlist.Count);
            }
            else if (choice == "2")
            {
                System.Console.WriteLine("Enter Your Username:");
                string username = Console.ReadLine();
                ticketlist.Remove(username);
                System.Console.WriteLine("Ticket Cancelled");
            }
            else if (choice == "3")
            {
                System.Console.WriteLine("Tickets Booked In Total: " + ticketlist.Count);
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Wrong Input Entered");
            }

        }
    }
}

public class customer
{

    public string username;
    public string phone;
    public int enrollment = 0;
}

public class tickets
{

    public int ticketnumber;
    public string bookingname;
}