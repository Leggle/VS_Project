using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails
{
    class PersonDetails
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public PersonDetails(int _age, string _firstName, string _gender)
        {
            Age = _age;
            FirstName = _firstName;
            Gender = _gender;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonDetails> pdList = new List<PersonDetails>();
            pdList.Add(new PersonDetails(32, "Harry", "male"));
            pdList.Add(new PersonDetails(22, "Alice", "female"));
            pdList.Add(new PersonDetails(20, "David", "male"));
            pdList.Add(new PersonDetails(25, "Cathy", "female"));
            pdList.Add(new PersonDetails(50, "Zac", "male"));
            pdList.Add(new PersonDetails(40, "Why", "female"));

            // print items in List
            Console.WriteLine("Items in the list:");
            foreach (PersonDetails pd in pdList)
            {
                Console.WriteLine("{0},{1},{2}", pd.Age, pd.FirstName, pd.Gender);
            }
            Console.WriteLine();

            // Filter Age > 35
            List<PersonDetails> filterpdList = pdList.Where(p => p.Age > 35).ToList();
            Console.WriteLine("List after filter age > 35:");
            foreach (PersonDetails pd in filterpdList)
            {
                Console.WriteLine("{0},{1},{2}", pd.Age, pd.FirstName, pd.Gender);
            }
            Console.WriteLine();

            // Sort By FirstName
            List<PersonDetails> sortpdList = pdList.OrderBy(p => p.FirstName).ToList();
            Console.WriteLine("List after sort by firstname:");
            foreach (PersonDetails pd in sortpdList)
            {
                Console.WriteLine("{0},{1},{2}", pd.Age, pd.FirstName, pd.Gender);
            }
            Console.WriteLine();

            // Add new list to existing list
            List<PersonDetails> newList = pdList;
            newList.AddRange(pdList);
            Console.WriteLine("List after added new list to existing list:");
            foreach (PersonDetails pd in newList)
            {
                Console.WriteLine("{0},{1},{2}", pd.Age, pd.FirstName, pd.Gender);
            }
            Console.WriteLine();

            // Remove male from list
            List<PersonDetails> removeMale = pdList.Where(p => p.Gender == "female").ToList();
            Console.WriteLine("List after remove male employee:");
            foreach (PersonDetails pd in removeMale)
            {
                Console.WriteLine("{0},{1},{2}", pd.Age, pd.FirstName, pd.Gender);
            }
            Console.ReadKey();

        }
    }
}
