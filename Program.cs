using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Esra","Şen",20,20040);
            Customer customer2 = new Customer("Engin", "Demiroğ", 37, 20040);
            Customer customer3 = new Customer("Lale", "Hagdhjf", 20, 20041);
            Customer customer4 = new Customer("Sevim", "Şen", 21, 20042);
            Customer customer5 = new Customer("Nazik", "fjjfdn", 20, 20043);
            Customer customer6 = new Customer("Duygu", "gjgjgj", 20, 20044);


            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            Customer[] customers = new Customer[] { customer4,customer5,customer6};
            customerManager.ToListCustomers(customers);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            customerManager.AddCustomer(customers);
            customerManager.RemoveCustomer(customer2);
            customerManager.RemoveCustomer(customer1);

            string newName = "Mustafa";
            string newLastName = "Çalışkan";
            customerManager.UpdateCustomer(customer2,ref newName, ref newLastName);

           





        }
    }
}
