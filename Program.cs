// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write("Digite o ano do seu nascimento: ");
int year =  int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Vovê tem {age} anos,");

