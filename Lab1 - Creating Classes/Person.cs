using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___Creating_Classes
{
    public class Person
    {
        //private data
        private string favoriteColour;
        private int age;
        private bool isWorking;

        //public properties
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour 
        { 
            get { return favoriteColour; }
            set { favoriteColour = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value; }
        }
        public Person(int pId, string fN, string lN, string fC, int age, bool isWorking)
        {
            PersonId = pId;
            FirstName = fN;
            LastName = lN;
            FavoriteColour = fC;
            Age = age;
            IsWorking = isWorking;
        }
        //methods
        public string DisplayPersonInfo()
        {
            return $"{PersonId}: {FirstName}'s favorite colour is {FavoriteColour}";
        }
        public  string ChangeFavoriteColour()
        {
            return FavoriteColour = "White";
        }
        public string GetAgeIn10Years()
        {
           int newAge = Age + 10;
            return $"{FirstName} {LastName}’s Age in 10 years is: {newAge}";
        }
        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
            
        }
    }
}
