using Intro.Business;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = true;

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoş geldin Oğuzhan");
}
else
{
    Console.WriteLine("Buton --> Sisteme giriş yap.");
}

string[] loans = {"Kredi 1","Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new(new DapperCourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("Kod bitti.");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Oğuzhan";
customer1.LastName = "Küreksiz";
customer1.CustomerNumber = "1234567";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678911";
customer2.FirstName = "Alican";
customer2.LastName = "Küreksiz";
customer2.CustomerNumber = "1234568";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "1234569";
customer3.TaxNumber = "1234562";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "TechCareer";
customer4.CustomerNumber = "1234570";
customer4.TaxNumber = "1234572";

BaseCustomer[] customers = { customer1,customer2,customer3,customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine("Id numarası " + customer.Id + " olan müşterinin müşteri numarası : " + customer.CustomerNumber);
}