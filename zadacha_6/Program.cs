﻿// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Clear();
Console.Write("Введите для проверки его четности:  ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) //проверяем четность делением по модулю без остатка
{
    Console.WriteLine("Да,оно четное");
}
else
{
    Console.WriteLine("Нет,оно не четное");
}