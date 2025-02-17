using OOPConcepts;

namespace OOPConcepts
{
    public class LearnInheritance {
        // A class can inheritance from another class to extend or customize the original class 
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------Learn Inheritance Concepts Started-----------------");
            BaseClass baseClass = new BaseClass();
            baseClass.PersonalDetails();
            Console.WriteLine("Parent class Personal Details" + baseClass.name);
            Console.WriteLine("Parent class Personal Details" + baseClass.address);
            Console.WriteLine("Parent class Personal Details" + baseClass.id);
            ChildClass childClass = new ChildClass();
            childClass.BankDetails();
            Console.WriteLine("--------------Learn Inheritance Concepts Ended-----------------");

            Console.WriteLine("--------------Learn Polymorphism Concepts Ended-----------------");
            PolymorphismSample SameMethod = new PolymorphismSample();
            SameMethod.PostCall();
            SameMethod.PostCall(3);

        }
    }
}
