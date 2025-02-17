
namespace OOPConcepts
{
    public class PolymorphismSample{

        public void PostCall(int body){
            
            Console.WriteLine($"Polymorphism method is called PostCall with body data and it's body value is : '{body}'\n");
        }
        public void PostCall(){
            Console.WriteLine($"Same PostCall methods is called without variable inside the method");
        }
    }
       
    
}
