// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
string a = Console.ReadLine();
int aa = int.Parse(a);
Console.Write("Введите число 2: ");
string b = Console.ReadLine();
int bb = int.Parse(b);
if(aa > bb) Console.WriteLine($"Число {aa} больше чем число {bb}");
else Console.WriteLine($"Число {bb} больше чем число {aa}");
