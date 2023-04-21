// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int max=int.Parse(Console.ReadLine());
//Console.WriteLine (max);
Console.WriteLine("Введите второе число: ");
int a=int.Parse(Console.ReadLine());
//Console.WriteLine (a);
if (a>max)  
{
max=a;
}
Console.WriteLine("Введите третье число: ");
a=int.Parse(Console.ReadLine());
//Console.WriteLine (a);
if (a>max)  
{
max=a;
}


Console.WriteLine("Максимальное число из трёх " + max);
