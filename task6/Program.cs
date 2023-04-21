// Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int ost = number%10;
if (ost == 0 || ost == 2 || ost == 4 || ost == 6 || ost == 8)
{
    Console.WriteLine("Число чётное");
}
else Console.WriteLine("Число нечётное");
