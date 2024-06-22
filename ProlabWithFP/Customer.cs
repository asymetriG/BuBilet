using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Customer
    {
        public List<Passenger> passengers = new List<Passenger>();
        public string serialNumber = GenerateRandomString(25);
        public int totalTicketCost = 0;

        static string GenerateRandomString(int length)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnnopqrstuvwxyz123456789"; 

            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }

        public void addPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        } 
    }
}
