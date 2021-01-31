using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Domain
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

        public Person(string firstName, string lastName, bool systemDeveloper, Continent whereFrom)
        {
            FirstName = firstName;
            LastName = lastName;
            IsSystemDeveloper = systemDeveloper;
            WhereFrom = whereFrom;
        }

        public string GetPresentation()
        {
            return $"{FirstName} {LastName} is from the continent of {WhereFrom} and is{(IsSystemDeveloper ? "" : "n't")} a system developer.";
        }

    }
}
