using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.name = "Ahmet Oğuz";
            customer1.lastName = "Canlı";

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.name = "Abdullah Taha";
            customer2.lastName = "Aksakal";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.ListCustomers(customers);
        }
    }
}
