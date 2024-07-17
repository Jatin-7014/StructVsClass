using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo.Models
{
    internal class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("============Employee Details===============");
            Console.WriteLine($"Name: {Name}\nAge:{Age}\nId:{Id}");
        }
    }
}
