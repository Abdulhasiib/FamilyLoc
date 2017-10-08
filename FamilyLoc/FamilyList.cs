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
            //Welcome message.
            Console.WriteLine("Welcome to the Family game. " +
                              "Tell us your Name?");

            //Member Class Initialization
            Member Participant = new Member();

            //To enter user details
            Participant.MemberAdd();

            string participantName = Participant.MemberPrefix + Participant.MemberFirstName + " " + Participant.MemberLastName;

            //Greetings to user.
            Console.WriteLine("Hello, " + participantName + ". ");

            //To ask user to provide family details.
            Console.Write("Tell us about your family. " +
                "Howmany members you've in your family? " +
                "Enter member  : ");
            int members = Int32.Parse(Console.ReadLine());

            //Compliment about family
            if (members > 5)
            {
                Console.WriteLine("Wow! you've a big family.");
            }
            else
            {
                Console.WriteLine("Cool! yours is a compact family.");
            }

            //To add Family member details
            Console.WriteLine("Would you tell us about your family members?");


            //List of family
            List<Member> UserFamily = new List<Member>();

            //To add user to family list
            UserFamily.Add(Participant);
            

            //To add family members to List
            for (int i = 1; i < members; i++)
            {
                //Member Class Initialization
                
                Member FamilyMember = new Member();

                //To enter user details
                FamilyMember.MemberAdd();

                //To Add member to List
                UserFamily.Add(FamilyMember);

                if (i == members - 1)
                {
                    Console.WriteLine("Thank you for entering your family members' names.");
                }
                
            }

            foreach (Member familymember in UserFamily)
            {
                Console.WriteLine(familymember.MemberPrefix + familymember.MemberFirstName + " " + familymember.MemberLastName + " " + familymember.RelationWithUser);
            }

            Console.ReadLine();

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

        //Member Prefix
        public string MemberPrefix { get; set; }


        /// <summary>
        /// To Get the Name of the Member
        /// </summary>
        /// <returns></returns>
        public void MemberAdd()
        {
            MemberName();
        }
        

        /// <summary>
        /// Method to get the details of the Famil Member
        /// </summary>
        /// <returns></returns>
        public string MemberName()
        {
            //First Name of Member
            Console.Write("Enter First Name: ");
            string userFirstName = Console.ReadLine();
            MemberFirstName = userFirstName;

            //Last Name of Member
            Console.Write("Enter Last Name: ");
            string userLastName = Console.ReadLine();
            MemberLastName = userLastName;

            //Gender of Member
            Console.Write("Enter Gender. Enter M/F. ");
            string gender = Console.ReadLine();
            MemberGender = gender;

            //Name prefix.
            string prefix = (gender == "M") ? "Mr. " : "Mrs. ";
            MemberPrefix = prefix;

            //Age of Member
            Console.Write("Enter Age: ");
            int memberAge = Int32.Parse(Console.ReadLine());
            MemberAge = memberAge;

            //Relation of Member with User
            Console.Write("Tell us your relation with {0} {1} {2} : ", prefix, userFirstName + " ", userLastName);
            string Relation = Console.ReadLine();
            RelationWithUser = Relation;

            //Occupation of Member
            Console.Write("What do {0} {1} {2} do for living? Enter Occupation: ", prefix, userFirstName + " ", userLastName);
            string memberOccupation = Console.ReadLine();
            MemberOccupation = memberOccupation;

            //Return Member details
            return prefix + userFirstName + " " + userLastName;
        }

    }
}