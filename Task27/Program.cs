// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Clear();
try
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = n;
    int sum = 0;

    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }

    Console.WriteLine($"Сумма цифр в числе {m}: {sum}");
}
catch (System.Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}
