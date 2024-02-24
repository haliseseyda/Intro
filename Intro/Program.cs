// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = false; //Sisteme girmiş mi?
Console.WriteLine(message1);

//condition Şart
if (isAuthenticated) //true
{
    Console.WriteLine("Buton-->Hoşgeldin Halise");
}
else
{
    Console.WriteLine("Sisteme Giriş Yap");
}

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; //db den gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

/*
Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 17...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12...";
course3.Price = 20;

Course[] courses = {course1 , course2 , course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}*/

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

//value types --> int, bool, double...
//reference type --> array, class, interface...

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}