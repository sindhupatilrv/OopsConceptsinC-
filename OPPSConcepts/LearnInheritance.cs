using OOPConcepts;

namespace OOPConcepts
{
    public class LearnInheritance
    {
        public static void Main(string[] args)
        {

            BaseClass baseClass = new BaseClass();
            baseClass.PersonalDetails();
            Console.WriteLine("Parent class Personal Details" + baseClass.name);
            Console.WriteLine("Parent class Personal Details" + baseClass.address);
            Console.WriteLine("Parent class Personal Details" + baseClass.id);


            ChildClass childClass = new ChildClass();
            childClass.BankDetails();
        }
    }
}
