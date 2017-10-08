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
            
            Console.WriteLine("Welcome to the Family game. " +
                              "Tell us your Name?");

            string participantName = memberName();

            Console.WriteLine("Hello, " + participantName + ". ");
            Console.Write("Tell us about your family. " +
                "Howmany members you've in your family? " +
                "Enter member  : ");
            int members = Int32.Parse(Console.ReadLine());

            if (members > 5)
            {
                Console.WriteLine("Wow! you've a big family.");
            }
            else
            {
                Console.WriteLine("Cool! yours is a compact family.");
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
            //Member Class Initialization
            Member UserFamilyMember = new Member();

            //First Name of Member
            Console.Write("Enter First Name: ");
            string userFirstName = Console.ReadLine();
            UserFamilyMember.MemberFirstName = userFirstName;

            //Last Name of Member
            Console.Write("Enter Last Name: ");
            string userLastName = Console.ReadLine();
            UserFamilyMember.MemberLastName = userFirstName;

            //Gender of Member
            Console.Write("Enter Gender. Enter M/F. ");
            string gender = Console.ReadLine();
            UserFamilyMember.MemberGender = gender;

            //Name prefix.
            string prefix = (gender == "M") ? "Mr. " : "Mrs. ";

            //Age of Member
            Console.Write("Enter Age: ");
            int memberAge = Int32.Parse(Console.ReadLine());
            UserFamilyMember.MemberAge = memberAge;

            //Relation of Member with User
            Console.Write("Tell us your relation WITH {0} {1} {2}", prefix, userFirstName + " ", userLastName);
            string Relation = Console.ReadLine();
            UserFamilyMember.RelationWithUser = Relation;

            //Occupation of Member
            Console.Write("What do {0} {1} {2} do for living?", prefix, userFirstName + " ", userLastName);
            string memberOccupation = Console.ReadLine();
            UserFamilyMember.MemberOccupation = memberOccupation;

            //Return Member details
            return prefix + userFirstName + " " + userLastName;
        }
    }

    class Member
    {
        //First Name of the Member
        public string MemberFirstName { get; set; }

        //Last Name of the Member
        public string MemberLastName { get; set; }

        //Gender of the Member
        public string MemberGender { get; set; }

        //Age of the Member
        public int MemberAge { get; set; }

        //Relation of Member with the User
        public string RelationWithUser { get; set; }

        //Occupation of the Member
        public string MemberOccupation { get; set; }

    }
}