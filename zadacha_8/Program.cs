Console.Clear();
Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine());
int i;
if (num > 0) // если число положительное
{
    for (i = 2; i <= num; i += 2)
    {
        Console.Write(" " + i);
    }
}
if (num==0) // а вдруг пользователь ввел нолик
{
    Console.Write("Зачем Вы ввели нуль?");
}
else // а здесь мы полагаем, что число может быть отрицательным
{
    for (i=-2;i >= num; i=i-2)
    {
        Console.Write(" "+i);
    }
}