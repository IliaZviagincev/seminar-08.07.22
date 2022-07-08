Console.Clear();
Console.Write("Введите первое число:  ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:  ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:  ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Число первозаписанное самое большое:  " + num1 + " > " + num2 + " а еще " + num1 + " > " + num3);
}
else
{
    if (num2 > num1 && num2 > num3)
    {
        Console.WriteLine("Число второе самое большое:  " + num2 + " > " + num1 + " а еще " + num2 + " > " + num3);
    }
    if (num3 > num1 && num3 > num2)
    {
        Console.WriteLine("Число третье самое большое:  " + num3 + " > " + num1 + " а еще " + num3 + " > " + num2);
    }
    else
    {
        //подстраховка если три числа одинаковые
        if (num1 == num2 && num1 == num3)
        {
            Console.WriteLine("Мне кажется вы подкинули три одинаковых числа");
        }
        //подстраховка если все же два числа одинаковы
        else
        {
            if (num1 == num2)
            {
                int a = num1;
                int b = num3;
                if (a > b)
                {
                    Console.WriteLine("число  " + a + " > " + b);
                }
                else
                {
                    Console.WriteLine("Число  " + b + " > " + a);
                }

            }
            if (num1 == num3)
            {
                int a = num1;
                int b = num2;
                if (a > b)
                {
                    Console.WriteLine("число  " + a + " > " + b);
                }
                else
                {
                    Console.WriteLine("Число  " + b + " > " + a);
                }
            }
            if (num2 == num3)
            {
                int a = num2;
                int b = num1;
                if (a > b)
                {
                    Console.WriteLine("число  " + a + " > " + b);
                }
                else
                {
                    Console.WriteLine("Число  " + b + " > " + a);
                }
            }
        }

    }

}

