﻿Console.Clear();
Console.Write("Введите трехзначное число:  ");
int num = int.Parse(Console.ReadLine());
int num_out;

// проверяем действительно ли трехзначное число введено
if (num > 1000 || num < 100)
{
    Console.WriteLine("Это не трехзначное число");
}

else
{
    num_out = num % 10; //а теперь найдем делением по модулю последний символ
    Console.WriteLine("последнее последний символ числа будет: _ _ " + num_out);
}