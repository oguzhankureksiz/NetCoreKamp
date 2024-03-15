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
    Console.WriteLine(loans[0]);
}

Console.WriteLine("Kod bitti.");