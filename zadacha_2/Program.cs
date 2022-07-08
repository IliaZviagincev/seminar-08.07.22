Console.Write("Введите первое число:  ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:  ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число первое больше второго:  " + num1 + " > " +num2);
}
else
{
    Console.WriteLine("Число второе больше первого:  " + num1 + " < " + num2);
}