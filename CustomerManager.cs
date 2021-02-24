using System;
namespace ClassMethodDemo
{
    public class CustomerManager
    {

        //Bir veya birden fazla müşteri ekleme işlemi
        //bu method imzası ile simüle edildi
        public void AddCustomer(Customer customer)
           
        {
            Console.WriteLine(customer.firstName + " isimli müşteri eklendi!");

        }

        //Overloading 
        public void AddCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.firstName + " isimli müşteri eklendi!");
            }
        }

        //Bu method müşterileri listeler(ad soyad şeklinde)
        public void ToListCustomers(Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Müşteri:" + customer.firstName + " " + customer.lastName); ;
            }
        }

        public void RemoveCustomer(Customer[] customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.firstName+" isimli müşteri silindi...");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine(customer.firstName + " isimli müşteri silindi...");

        }

        public void UpdateCustomer(Customer customer, string newFirstName, string newLastName)
        {
            Console.WriteLine(customer.firstName + " "+ customer.lastName + " müşterisinin bilgileri güncellendi..." );
            customer.firstName = newFirstName;
            customer.lastName = newLastName;
            Console.WriteLine("Güncel Ad:" + newFirstName);
            Console.WriteLine("Güncel Soyad:"+newLastName);
        }

    }
}
