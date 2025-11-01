


//UPPGIFT 21 

Console.WriteLine("Skriv in heltal");
double userInput = double.Parse(Console.ReadLine());

double Kvadrat(double x)
{
    return Math.Pow(userInput, 2); 
}

double KvadratSimpel(double x, double y)
{
    return userInput * userInput; 
}

double svar = Kvadrat(userInput);
double svarEnkel = KvadratSimpel(userInput, userInput); 
Console.WriteLine($"Svar = {svar}");
Console.WriteLine($"Svar = {svarEnkel}");


//UPPGIFT 20
/*
Console.WriteLine("Skriv in ett heltal"); // instruktion 
int userInput = int.Parse(Console.ReadLine()); // konverterar int till string från input 

if (userInput == 0) // om userInput == noll, avbryts programmet med return; 
{
    Console.WriteLine("Hejdå");
    return; 
}
else if (userInput % 2 == 0) // jämnt tal 
{
    Console.WriteLine("Jämnt tal"); 
} 
else if (userInput % 2== 0) //udda tal 
{
    Console.WriteLine("Udda Tal"); 
}
*/



//UPPGIFT 18 & 19 alfabet A-Z
/*
for (char alfabeth = 'A'; alfabeth <= 'Z'; alfabeth++) //iteration av A-Z
{
    Console.Write(alfabeth); //Skriver ut iterationen. 
}

for (char alfabeth = 'Z'; alfabeth >= 'A'; alfabeth--) //iteration av A-Z,
{
    Console.Write(alfabeth); //Skriver ut iterationen. 
}
*/




//UPPGIFT 16 & 17 
/*
Console.WriteLine("Jämna Tal av 0-20"); 
for(int i = 0; i <= 20; i++)
{
    if ( i % 2 == 0) // modulus operatören. Om resulatet = 0, jämna tal
    {
        Console.WriteLine(i); //skriver ut talen 
    }
}

Console.WriteLine("Udda Tal av 0-20");
for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 1) // Om resultat = 1, udda tal 
    {
        Console.WriteLine(i);
    }
}
*/




//UPPGIFT 15 
/*
Console.WriteLine("Conversion, KR to EURO. 1 kr = 0.095"); //skriver ut instruktion
double userAmount = double.Parse(Console.ReadLine());  //konverterar data typ double till string 
double Convert(double amount) // metod för att byta från kr till euro enligt rate. 
{
    return amount * 0.095d; 
}

double convertedSum = Convert(userAmount); // assignerar summan av metoden till en variabel för lättare användning. 
Console.WriteLine($"Converted {userAmount} kr to {convertedSum} Euros"); //resulat 
*/






//UPPGIFT 14
/*
Console.WriteLine("Skriv in 2 heltal för att räkna ut summa"); //skriver ut instruktionen 
int int1 = int.Parse(Console.ReadLine()); // får tag på användarens input
int int2 = int.Parse(Console.ReadLine());

int Add(int X, int Y) //metod för att räkna summan av x och y 
{
  
    return X +Y;
}
int sum = Add(int1, int2); //assignerar summan av metoed till en variabel 

Console.WriteLine($"Summan av {int1} och {int2} är = {sum}"); //skriver ut resultatet. 
*/