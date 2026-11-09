/*********************************************
*Name: Mahryna Yates
*Date: 11/8/2026
*Assignmnet: SDC220 Performance Assessment - Inheritance & Overriding
*/

public class Cat : Animal
{
    public string Sound { get; set;}

    public Cat(String name, int numLegs, string sound) : base(name, numLegs)
    {
        Sound = sound;
    }

    public override void PrintAnimal()
    {
        Console.WriteLine("The Cat's name is {0} and it has {1} legs and is making a {2} sound.", Name, NumLegs, Sound);
    }
}