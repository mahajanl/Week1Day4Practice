using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1day4practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Lakshami";
            //Console.WriteLine("You have " + firstName.Length + " in your name.");

            //string lastName = "Mahajan";
            //Console.WriteLine("You have " + lastName.Length + " in your last name.");

            //Console.WriteLine("Type in your first name for me.");
            //string lastName = Console.ReadLine();
            //int lastNameLeng = lastName.Length;

            //Console.WriteLine("Type in your last name for me,");
            //string firstName = Console.ReadLine();
            //int firstNAmeLeng = lastName.Length;

            //if(lastNameLeng > firstNAmeLeng)
            //{Console.WriteLine("Your last name is longer than your first name.");
            //}
            //else if(firstName.Length == lastName.Length)
            //{ Console.WriteLine("They're the same!");
            //}
            //else
            //{ Console.WriteLine("Your last name is longer!");
            //}

            //Console.WriteLine("This is a \t tab" + "\nThis is a new line" + "\nThis is a \abell sound.");

            //string nameOne = "Harry";
            //string nameTwo = "Cleo";

            //bool strEq = (nameOne == nameTwo);

            //if (nameOne == nameTwo) 
            //{ Console.WriteLine("These names are the same!");
            //}

            //else if (nameOne != nameTwo) 
            //{ Console.WriteLine("These names are different. How cool is that?");
            //}

            // this is not part of what I want to do::
            // Console.WriteLine(strEq);

            //Console.WriteLine(nameOne.Equals(nameTwo));

            Console.WriteLine("Hi there! Can I have your first name?");
            string uneNom = Console.ReadLine();

            Console.WriteLine("Can I now have your last name as well?");
            string deuxNom = Console.ReadLine();

            Console.WriteLine("Your name is " + uneNom + " " + deuxNom + ".");

        }
    }
}
