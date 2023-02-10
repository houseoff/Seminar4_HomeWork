// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел,
// причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.
// Требуется написать программу, производящую согласно утверждению Гольдбаха, 
// разложение заданного чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

// Входные данные
// Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).

// Выходные данные
// В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N. Первым выводится наименьшее число.

// Блок 1. Для запуска в Visual Studio Code
int SmallestSimpleDivider(int num)
{
    int result = 0;
    if (num == 4)
    {
        return 2;
    }

    for (int i = 3; i <= num; i += 2)
    {
        result = i;
        if (num % i == 0)
        {
            return result;
        }
    }
    return result;
}

bool IsTwoSimpleNumbers(int num1, int num2)
{
    if (SmallestSimpleDivider(num1) % num1 == 0 & SmallestSimpleDivider(num2) % num2 == 0)
        return true;
    return false;
}

Console.Clear();
Console.Write("Введите четноё число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n % 2 != 0)
{
    Console.Write("Вы ошиблись!\nВведите четноё число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

for (int i = 2; i < n;)
{
    if (IsTwoSimpleNumbers(i, n - i))
    {
        Console.WriteLine($"Пара чисел: {i} и {n - i}");
        break;
    }
    if (i == 2)
        i++;
    else
        i += 2;
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=117&id_problem=723&ins=1#solution
// using System;
// using System.IO;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int SmallestSimpleDivider(int num)
//         {
//             int result = 0;
//             if (num == 4)
//             {
//                 return 2;
//             }

//             for (int i = 3; i <= num; i += 2)
//             {
//                 result = i;
//                 if (num % i == 0)
//                 {
//                     return result;
//                 }
//             }
//             return result;
//         }

//         bool IsTwoSimpleNumbers(int num1, int num2)
//         {
//             if (SmallestSimpleDivider(num1) % num1 == 0 & SmallestSimpleDivider(num2) % num2 == 0)
//                 return true;
//             return false;
//         }

// 		StreamReader sr = new StreamReader("input.txt");
//     	StreamWriter sw = new StreamWriter("output.txt");
 
//     	int n = int.Parse(sr.ReadLine());  
        
//         for (int i = 2; i < n;)
//         {
//             if (IsTwoSimpleNumbers(i, n - i))
//             {
//                 sw.WriteLine($"{i} {n - i}");
//                 break;
//             }
            
//             if (i == 2)
//                 i++;
//             else
//                 i += 2;
//         }
        
//         sr.Close();
//     	sw.Close();
//     }
// }