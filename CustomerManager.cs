using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void ListCustomers(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.name + " " + customer.lastName);
            }
        }
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.lastName + " adlı müşteri eklendi..");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.name + " " + customer.lastName + " adlı müşteri silindi..");
        }
    }
}
