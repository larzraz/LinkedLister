using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLister
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person { Id = 1, FirstName = "Farrand", LastName = "Semkins", Gender = Gender.Female, Age = 77 };
            Person p2 = new Person { Id = 2, FirstName = "Trev", LastName = "Quail", Gender = Gender.Male, Age = 84 };
            Person p3 = new Person { Id = 3, FirstName = "Dani", LastName = "Ballister", Gender = Gender.Female, Age = 76 };
            Person p4 = new Person { Id = 4, FirstName = "Hyacinthie", LastName = "Mish", Gender = Gender.Female, Age = 70 };

            LinkedList list = new LinkedList();

            list.InsertFirst(p1);  // p5
            list.InsertFirst(p2); // p21,p5
            list.InsertFirst(p3);  // p9,p21,p5
            list.InsertFirst(p4);
            list.RemoveAt(2);
            Console.WriteLine(list.Items(0));
            Console.ReadKey();
        }
    }
}
