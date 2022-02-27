// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
string a = Console.ReadLine();
int aa = int.Parse(a);
Console.Write("Введите число 2: ");
string b = Console.ReadLine();
int bb = int.Parse(b);
Console.Write("Введите число 3: ");
string c = Console.ReadLine();
int cc = int.Parse(c);

int max = aa;
if(bb > max) max = bb;
if(cc > max) max = cc;

Console.WriteLine($"Максимальное число {max}");
