using System;

namespace ConstructorYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id =1,FirstName="Mislina",LastName="AYDIN",City=" Sivas"};
            Customer customer2 = new Customer(1, "Derin", "Demiroğ", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer1.City);
        }
    }
    class Customer 
    {
        public Customer()
        {
            // customer 1 ve 2 için
        }
        public Customer(int id ,string firstName,string lastName,string city) //customer2 nin farklı kullanımı
           
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }



    }
}
