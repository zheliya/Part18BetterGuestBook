using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();
            string noMoreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What message would you like to tell your host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming (yes/no): ");
                noMoreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();
            } while (noMoreGuestsComing.ToLower() != "no");

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

            Console.ReadLine();
        }
    }
}
