// Петя впервые пришел на урок физкультуры в новой школе. Перед началом урока ученики выстраиваются по росту, в порядке невозрастания. 
// Напишите программу, которая определит, на какое место в шеренге Пете нужно встать, чтобы не нарушить традицию, 
// если заранее известен рост каждого ученика и эти данные уже расположены по невозрастанию (то есть каждое следующее число не больше предыдущего). 
// Если в классе есть несколько учеников с таким же ростом, как у Пети, то программа должна расположить его после них.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
// Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке невозрастания. 
// Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите единственное целое число – номер Пети в шеренге учеников.

// Блок 1. Код для запуска в Visual Studio Code
void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] <= array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

Console.Clear();
try
{
    Console.Write("Введите число учеников, не считая Петю: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n > 100)
    {
        Console.Write("Вы ошиблись!\nВведите число учеников, не считая Петю: ");
        n = Convert.ToInt32(Console.ReadLine());
    }

    int[] array = new int[n];
    int count = 0;
    while (count != n)
    {
        Console.Write($"Введите росты учеников в см. (осталось ввести {n - count}): ");
        int m = Convert.ToInt32(Console.ReadLine());
        if (m > 200)
        {
            Console.WriteLine($"Вы ошиблись!");
            count--;
        }
        else
        {
            array[count] = m;
        }
        count++;
    }

    Console.Write("Введите рост Пети в см: ");
    int k = Convert.ToInt32(Console.ReadLine());
    while (k > 200)
    {
        Console.Write("Вы ошиблись!\nВведите рост Пети в см: ");
        k = Convert.ToInt32(Console.ReadLine());
    }

    SortArray(array);
    int result = 0;
    for (int i = 0; i < n - 1; i++)
    {
        if (k <= array[i] & k > array[i + 1])
            result = i + 2;
    }
        
    if (k > array[0])
        result = 1;

    if (k <= array[n-1])
        result = n + 1;

    Console.WriteLine($"Ширенга: {string.Join(", ",array)}");
    Console.WriteLine($"Номер Пети в ширенге учеников: {result}");
}
catch (System.Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=699

// using System;
// using System.IO;

// public class Program
// {
//     private static void Main(string[] args)
//     {
//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");

//         int n = int.Parse(sr.ReadLine());
//         string[] array = sr.ReadLine().Split();
//         int k = int.Parse(sr.ReadLine());

//         int result = 0;
//         for (int i = 0; i < n - 1; i++)
//         {
//             if (k <= int.Parse(array[i]) & k > int.Parse(array[i + 1]))
//                 result = i + 2;
//         }
        
//         if (k > int.Parse(array[0]))
//             result = 1;

//         if (k <= int.Parse(array[n-1]))
//             result = n + 1;

//         sw.WriteLine(result);
//         sr.Close();
//         sw.Close();
//     }
// }