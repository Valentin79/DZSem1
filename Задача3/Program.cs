// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string a = Console.ReadLine();
int aa = int.Parse(a);
int res = aa%2;
if(res == 0) Console.WriteLine($"Число {aa} чётное");
else Console.WriteLine($"Число {aa} нечётное");