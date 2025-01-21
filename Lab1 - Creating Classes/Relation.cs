using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___Creating_Classes
{
    public class Relationship
    {
        //Private properties
        private string relationshipType;
        //Public properties
        public string RelationshipType
        {
            get { return relationshipType; }
            set { relationshipType = value; }
        }
        //Constructor
        public Relationship(string RType)
        {
            RelationshipType = RType;
        }
        //Methods
        public string ShowRelationShip(Person person1,Person person2)
        {
            if(RelationshipType == "Brother") 
            {
                return $"Relationship between {person1.FirstName} and {person2.FirstName} is: Brotherhood."; 
            }
            if(RelationshipType == "Sister") 
            { 
                return $"Relationship between {person1.FirstName} and {person2.FirstName} is: Sisterhood.";
            }
            if (RelationshipType == "Father")
            {
                return $"Relationship between {person1.FirstName} and {person2.FirstName} is: Fatherhood.";
            }
            if (RelationshipType == "Mother")
            {
                return $"Relationship between {person1.FirstName} and {person2.FirstName} is: Motherhood.";
            }
            return "";
        }

    }
}
