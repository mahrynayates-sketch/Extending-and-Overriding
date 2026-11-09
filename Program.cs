/*********************************************
*Name: Mahryna Yates
*Date: 11/8/2026
*Assignmnet: SDC220 Performance Assessment - Inheritance & Overriding
*/

public class InheritanceAndOverriding
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n Mahryna Yates - Week 5 PA Inheritance and Overriding\n");

        Cat c = new Cat("Fluffy", 4, "Meow");
        Animal a = new Animal("Roo", 2);
       

        a.PrintAnimal();
        c.PrintAnimal();

        c.Name = "Garfield";
        c.NumLegs = 4;
        c.Sound = "I'm HUNGRY";

        a.Name = "Flipper";
        a.NumLegs = 0;

        a.PrintAnimal();
        c.PrintAnimal();
    }
}