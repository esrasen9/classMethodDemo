using System;
namespace ClassMethodDemo
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
        public int age { get; set; }

        public Customer(string firstName , string lastName,int age,int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.id = id;
        }
    }
}
