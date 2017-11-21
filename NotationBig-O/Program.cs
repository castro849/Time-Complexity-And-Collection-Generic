using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotationBig_O
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("Mark", "Zuckerberg","Facebook"));
            list.Add(new Person("Bill", "Gates", "Microsoft"));
            list.Add(new Person("Steve", "Jobs", "Apple"));
            var order_list = list.OrderBy(o => o.FirstName);
            foreach (Person person in order_list)
            {
                Console.Out.WriteLine(String.Format("{0} {1}\t\t{2}", person.FirstName, person.LastName, person.Company));
            }
            Console.In.ReadLine();
        }
    }
}
