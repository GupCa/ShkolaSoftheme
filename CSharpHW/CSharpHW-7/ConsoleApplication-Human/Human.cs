using System;

namespace ConsoleApplication_Human
{
    public class Human
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }

        public Human()
        {
            BirthDate = DateTime.MinValue;
            FirstName = "";
            LastName = "";
            Age = 0;
        }

        public Human(DateTime birthDate, string firstname, string lastname)
        {
            BirthDate = birthDate;
            FirstName = firstname;
            LastName = lastname;
            Age = Convert.ToInt32((DateTime.Today - BirthDate).TotalDays / 365);
        }
        
        public override bool Equals(Object obj) 
        {
            if (obj == null ) 
                return false;

            Human h = obj as Human;
            return (BirthDate == h.BirthDate) &&
                   (FirstName == h.FirstName) &&
                   (LastName == h.LastName) &&
                   (Age == h.Age);
        }
        public override int GetHashCode() 
        {
            return  11 + 13*Age;
        }


    }
}