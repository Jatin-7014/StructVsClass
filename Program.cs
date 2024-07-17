using StructDemo.Models;
namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //memory allocated in the stack
            Employee employee1 = new Employee() {Id=101,Name="Jatin",Age=22};
            //copy passed in the struct
            Employee employee2 = employee1;


            //memory allocated in the heap
            Manager manager1 = new Manager() { Id = 1001, Name = "Alex", Age = 35 };
            //reference is pointing to different location
            Manager manager2 = manager1;

            employee2.Age = 26;
            manager2.Age = 40;




            employee1.ShowDetails();
            manager1.ShowDetails();
            //change occured in empl2 copy 
            employee2.ShowDetails();
            //change occured in both places due to reference
            manager2.ShowDetails();
        }
    }
}
