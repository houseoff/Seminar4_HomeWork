// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
try
{
    Console.Write("Введите 1-ое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-ое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for (int i = 1; i <= m; i++)
        result *= n;

    Console.WriteLine($"Результат возведения в степень {m} числа {n}: {result}");
}
catch (System.Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}