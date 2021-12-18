using System;
using System.Collections.Generic;

namespace ClassLibraryProject
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public bool IsSystemDeveloper { get; }
        public Continent WhereFrom { get; }
        public int LengthOfFirstNameAndLastName
        {
            get => FirstName.Length + LastName.Length;
        }

        public List<string> Inventory { get; } = new List<string>
        {
            "Car",
            "Computer",
            "Mobile Phone",
            "Wrist Watch"
        };

        private int health;

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Health", "Health must be between 0 and 100");

                health = value;
            }
        }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName, bool systemDeveloper, Continent whereFrom)
        {
            FirstName = firstName;
            LastName = lastName;
            IsSystemDeveloper = systemDeveloper;
            WhereFrom = whereFrom;
            Health = 100;
        }

        public string GetPresentation()
        {
            return $"{FirstName} {LastName} is from the continent of {WhereFrom} and is{(IsSystemDeveloper ? "" : "n't")} a system developer.";
        }
    }
}
