Console.Clear();
Console.Write("Введите для проверки его четности:  ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Да,оно четное");
}
else
{
    Console.WriteLine("Нет,оно не четное");
}