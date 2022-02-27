// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число: ");
string a = Console.ReadLine();
int aa = int.Parse(a);

int i = 1;
if(aa < 1) Console.WriteLine("Число должно быть больше 0");
while(i <= aa)
{
    int rem = i%2;
    if(rem == 0) Console.WriteLine(i);
    i = i+1;
}

