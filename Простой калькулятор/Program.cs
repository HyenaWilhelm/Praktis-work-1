using System.Numerics;

double num1 = 0;
double num2 = 0;
int oper = 0; //Переменная отвечающая за математические знаки

do
{
    Console.WriteLine("Введите число" +
        "\n1 - сложение" +
        "\n2 - вычитание" +
        "\n3 - умножение" +
        "\n4 - деление" +
        "\n5 - возведение в степень" +
        "\n6 - квадратный корень" +
        "\n7 - 1 процент от числа" +
        "\n8 - факториал" +
        "\n9 - выход из программы");
    Console.ReadLine();
    oper = Convert.ToInt32(Console.ReadLine());
    if (oper == 1)
    {
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 + num2);
    }
    else if (oper == 2)
    {
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 - num2);
    }
    else if (oper == 3)
    {
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 * num2);
    }
    else if (oper == 4)
    {
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 / num2);
    }
    else if (oper == 5)
    {
        Console.WriteLine("Введите первое число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(num1, num2));
    }
    else if (oper == 6)
    {
        Console.WriteLine("Введите число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(num1));
    }
    else if (oper == 7)
    {
        Console.WriteLine("Введите число");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1 / 100);
    }
    else if (oper == 8)
    {
        Console.WriteLine("Введите число");
        num1 = Convert.ToDouble(Console.ReadLine());
        var factorial = new BigInteger(1);
        for (int i = 1; i < num1; i++)
        {
            Console.WriteLine(factorial *= i);
            
        }
        continue;
    }
} while (oper == 9);