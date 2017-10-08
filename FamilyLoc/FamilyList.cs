using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfFamily
{
    class FamilyList
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Family game.");

            string participantName = memberName();

            Console.WriteLine("Hello,   " + participantName + ". ");
            Console.Write("Tell us about your family. " +
                "Howmany members you've in your family? " +
                "Enter member  : ");
            int members = Int32.Parse(Console.ReadLine());

            if (members > 5)
            {
                Console.WriteLine("Wow! you've a big family.....");
            }
            else
            {
                Console.WriteLine("Cool! yours is a compact family. Cool!");
            }

            Console.WriteLine("Tell us about your family members, how many?");

            string[] familyMembers = new string[members];

            familyMembers[0] = participantName;

            for (int i = 1; i < members; i++)
            {
                string nameOfMember = memberName();

                familyMembers[i] = nameOfMember;

                if (i == members - 1)
                {
                    Console.WriteLine("Thank you for entering your family members' names.");
                }
            }

            foreach (var familymember in familyMembers)
            {
                Console.WriteLine(familymember);
            }

            Console.ReadLine();

        }


        private static string memberName()
        {
            //First Name of Member
            Console.Write("Enter First Name: ");
            string userFirstName = Console.ReadLine();

            //Last Name of Member
            Console.Write("Enter Last Name: ");
            string userLastName = Console.ReadLine();

            //Gender of Member
            Console.Write("Enter Gender. Enter M/F. ");
            string gender = Console.ReadLine();

            //Name prefix.
            string prefix = (gender == "M") ? "Mr. " : "Mrs. ";

            //Age of Member
            Console.Write("Enter Age: ");
            int memberAge = Int32.Parse(Console.ReadLine());

            //Relation of Member with User
            Console.Write("Tell us your relation with {0} {1} {2}", prefix, userFirstName + " ", userLastName);
            string Relation = Console.ReadLine();

            //Return Member details
            return prefix + userFirstName + " " + userLastName + " " + memberAge + "years" + " " + Relation;
        }
    }
}