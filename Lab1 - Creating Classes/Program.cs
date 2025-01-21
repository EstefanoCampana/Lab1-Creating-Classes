// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Runtime.CompilerServices;
using Lab1___Creating_Classes;
//Creating all person objects
Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
Person gina = new Person(2, "Gina", "James", "Green", 18, false);
Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

//Displaying Gina's information as a sentence
Console.WriteLine(gina.DisplayPersonInfo());

//Displaying Mike's information as a list.
Console.WriteLine(mike);

//Changing Ian's favorite colour to White.
Console.WriteLine(ian.DisplayPersonInfo());
ian.ChangeFavoriteColour();
Console.WriteLine(ian.DisplayPersonInfo());

//Printing Mary's age in 10 years.
Console.WriteLine(mary.GetAgeIn10Years());

//Creating two relation objetcs.
Relationship brother = new Relationship("Brother");
Relationship sister = new Relationship("Sister");

//Displaying the relationship between Ian and Mike.
Console.WriteLine(brother.ShowRelationShip(ian, mike));

//Displaying the relationship between Gina and Mary.
Console.WriteLine(sister.ShowRelationShip(gina, mary));

//Adding all person objects into a list.
List<Person> persons = new List<Person>();
persons.Add(ian);
persons.Add(gina);
persons.Add(mike);
persons.Add(mary);

//Defining variables to calculate the average age of the persons in the list.
double avAge = 0;
double totalAge = 0;
string youngest = "";
string oldest = "";
int youngAge = 100;
int oldestAge = 0;

//Foreach loop to iterate through the list to find the oldest and youngest person in the list.
foreach (Person person in persons)
{
    if (person.Age < youngAge)
    {
        youngAge = person.Age;
        youngest = person.FirstName;

    }
    if (person.Age > oldestAge) 
    {
        oldestAge = person.Age;
        oldest = person.FirstName;
    }
    totalAge += person.Age;
}
//Calculating the average age of the persons in the list.
avAge = totalAge / persons.Count;
Console.WriteLine($"Average age is: {avAge}");

//Displaying who is the oldest and youngest person in the list.
Console.WriteLine($"The youngest person is: {youngest} and they are {youngAge} years old.");
Console.WriteLine($"The oldest person is: {oldest} and they are {oldestAge} years old.");


foreach (Person person in persons)
{
    if (person.FirstName.Contains("M"))     //Displaying all the persons that their name start with the letter M.
    {
        Console.WriteLine(person);
    }
    if (person.FavoriteColour == "Blue")    //Displaying the information for the person that likes the color Blue.
    {
        Console.WriteLine(person);
    }
}