//Student No: S10166869 , S10162177
//Student Name: Jourdan Lim , Sean Yeo Degen
//Module Group: IT05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            Console.WriteLine("Enter your option");
            int UserOption = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (UserOption == 1)
                {
                    listMovies();
                }
                if (UserOption == 2)
                {

                }
                if (UserOption == 3)
                {

                }
                if (UserOption == 4)
                {

                }
                if (UserOption == 5)
                {

                }
                if (UserOption == 6)
                {

                }
                if (UserOption == 7)
                {

                }
                if (UserOption == 8)
                {
                    break;
                }

            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Movie Ticketing System");
            Console.WriteLine("=================================");
            Console.WriteLine("1.  List all movies");
            Console.WriteLine("2.  Add a movie screening session");
            Console.WriteLine("3.  List movie screenings");
            Console.WriteLine("4.  Delete a movie screening session");
            Console.WriteLine("5.  Order movie ticket/s");
            Console.WriteLine("6.  Add a movie rating");
            Console.WriteLine("7. View movie ratings and comments");
            Console.WriteLine("8. Recommend movies");
            Console.WriteLine("0.  Exit");
            Console.WriteLine("0.  Exit");
            Console.WriteLine("=================================");
        }

        static void listMovies()
        {

        }
    }
}
