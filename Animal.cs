/*********************************************
*Name: Mahryna Yates
*Date: 11/8/2026
*Assignmnet: SDC220 Performance Assessment - Inheritance & Overriding
*/

using System.Reflection;

public class Animal
{
        public string Name { get; set;}
        public int NumLegs { get; set;}

    public Animal(String name, int numLegs)
    {
        Name = name;
        NumLegs = numLegs;
    }

    public virtual void PrintAnimal()
    {
        Console.WriteLine("The Animal's name is {0} and it has {1} legs.", Name, NumLegs);
    }
}