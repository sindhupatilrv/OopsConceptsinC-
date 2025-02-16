using OOPConcepts;

namespace OOPConcepts
{
    public class ChildClass : BaseClass
    {
      // child class modified same parent data but it's not reintialize it 
        public void BankDetails()   {
            BaseClass baseClass = new BaseClass
            {
                age = 50,
                address = "Child Class Address",
                id = 10,
                name = "Child Class Name"
            };
            Console.WriteLine(baseClass.age);
            Console.WriteLine(baseClass.name);
            Console.WriteLine(baseClass.id);
            Console.WriteLine(baseClass.address);
        }
    }
}
