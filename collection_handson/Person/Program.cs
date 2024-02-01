using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","deLauter", 84 ),
            new Person("Gail","Dawson", 19 ),
        };

        #region 1) Name with D
        //var person1 = people;

        //foreach (Person per in person1.ToList())
        //{
        //    if (!(per.LastName.StartsWith("D") || per.LastName.StartsWith("d")))
        //    {
        //        person1.Remove(per);
        //    }

        //}
        //Console.WriteLine("Number of people who's last name starts with the letter D: " + person1.Count());
        #endregion

        #region 2) Age > 40 (using remove, sort and reverse/for loop)

        //var person2 = people;
        ////Write a code for first Person Older Than 40 In Descending Alphabetical Order By First Name
        //foreach (Person p in person2.ToList())
        //{
        //    if (p.Age < 40)
        //    {
        //        person2.Remove(p);
        //    }
        //}
        //// Sort in ascending alphabetical order by first name:
        //person2.Sort((p1, p2) => string.Compare(p1.FirstName, p2.FirstName));

        //// Reverse the list based on names using reverse function:
        //person2.Reverse();

        #region //To print only 1st person in descending ordered list of Age > 40 :

        //Console.WriteLine("First Person Older Than 40 in Descending Order by First Name: " + person2.First().ToString());
        //// OR
        //Console.WriteLine("First Person Older Than 40 in Descending Order by First Name: " + person2[0].ToString());
        //// OR
        //for (int i = 0;  i<person2.Count; i ++)      // for loop -> start, length, skip
        //{
        //    Console.WriteLine("First Person Older Than 40 in Descending Order by First Name: " + person2[i].ToString());
        //    break;
        //}

        #endregion

        #region //To print entire list in descending order of Age > 40 : 

        //foreach (Person oldperson in person2.ToList())
        //{
        //    Console.WriteLine(oldperson.FirstName + " " + oldperson.LastName + " " + oldperson.Age);
        //}
        //// OR using for loop to print reverse order: 
        //for (int i = person2.Count - 1; i >= 0; i--)      // for loop -> start, length, skip
        //{
        //    Console.WriteLine(person2[i].FirstName + " " + person2[i].LastName + " " + person2[i].Age);
        //    //OR
        //    //Person oldPerson = person2[i];
        //    //Console.WriteLine(oldPerson.FirstName + " " + oldPerson.LastName + " " + oldPerson.Age);
        //}

        #endregion

        #endregion

        // OR 

        #region Age > 40 (using linq)

        //// Printing only 1st name after filtering: 
        
        //var person2 = people
        //    .Where(p => p.Age > 40)
        //    .OrderByDescending(p => p.FirstName)
        //    .FirstOrDefault(); 
        //Console.WriteLine("First Person Older Than 40 in Descending Order by First Name: " + person2.ToString());

        //// Printing entire list after filtering:
        
        //var person2 = people
        //    .Where(p => p.Age > 40)
        //    .OrderByDescending(p => p.FirstName)
        //    .ToList();
        //foreach (var person in person2)
        //{
        //    Console.WriteLine("First Person Older Than 40 in Descending Order by First Name: " + person.ToString());
        //}

        #endregion

    }
}
public class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //// override ToString to return the person's FirstName LastName Age
    public override string ToString()
    {
        return $"{FirstName} {LastName} {Age}";
    }

}
