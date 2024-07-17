using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructDemo.Models
{
    struct Employee
    {
        // Struct does not support inheritance....
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("============Employee Details===============");
            Console.WriteLine($"Name: {Name}\nAge:{Age}\nId:{Id}");
        }

    }
}
