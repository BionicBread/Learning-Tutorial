using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{

    public class Customer
    {
        //List<Order> Orders = new List<Order>(); // quick way to create a field without a constructor

        //readonly List<Client> Client = new List<Client>(); // readonly keyword means the list is only assigned once

        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); // It is best practice to initialise a list as empty in a class. This can be done using a constructor however said constructor must be the default so the empty
                                                                // list is created when the class is called
                                                                // The better way to achieve this is to initialise the list outside of the constructor. This means there is no dependancy on the constructor hierarchy.
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            Orders = new List<Order>();
        }
    }
}
