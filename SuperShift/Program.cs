// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// Выходные данные
// В выходной файл OUTPUT.TXT выведите полученную последовательность

// Блок 1. Код для запуска в Visual Studio Code
Console.Clear();
Console.Write("Введите через запятую элементы массива: ");
string[] array = Console.ReadLine()!.Split(',');
Console.Write("Введите количество необходимых сдвигов элементов: ");
int k = Convert.ToInt32(Console.ReadLine()!);
string message = string.Empty;

if (k < 0)
{
    message = string.Format("на {0} эл. влево", k);
    k = -k;
    k %= array.Length;
}
else
{
    message = string.Format("на {0} эл. вправо", k);
    k %= array.Length;
    k = array.Length - k;
}

Console.Write($"Сдвиг элементов массива {message}: ");
for (int i = k; i < array.Length; i++)
{
    Console.Write(int.Parse(array[i]) + " ");
}

for (int i = 0; i < k; i++)
{
    Console.Write(int.Parse(array[i]) + " ");
}


// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702
// using System;
// using System.IO;

// public class Program
// {
//     private static void Main(string[] args)
//     {
//         StreamReader sr = new StreamReader("input.txt");
// 		StreamWriter sw = new StreamWriter("output.txt");

// 		int n = int.Parse(sr.ReadLine()!);
// 		string[] array = sr.ReadLine()!.Split();
// 		int k = int.Parse(sr.ReadLine()!);

//         if (k < 0)
//         {
//             k = -k;
//         	k %= n;
//         }
//         else
//         {
//             k %= n;
//             k = n - k;
//         }

//         for (int i = k; i < n; i++)
//         {
//             sw.Write(int.Parse(array[i]) + " ");
//         }

//         for (int i = 0; i < k; i++)
//         {
//             sw.Write(int.Parse(array[i]) + " ");
//         }

// 		sr.Close();
// 		sw.Close();
//     }
// }
