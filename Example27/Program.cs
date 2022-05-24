﻿/*
**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter a count of numbers in a row Fibonacci");
int N = Convert.ToInt32(ReadLine());
WriteLine($"{N} -> {String.Join(" ", FibMeth(N))}");

int[] FibMeth(int num)
{
    int[] FibRow = new int[num];
    FibRow[1] = 1;
    for (int i = 2; i < num; i++) FibRow[i] = FibRow[i - 2] + FibRow[i - 1];
    return FibRow;
}