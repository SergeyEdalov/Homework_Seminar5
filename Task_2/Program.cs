﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter array size: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

void Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
Console.WriteLine($"[{string.Join(", ", array)}]");
}
Fillarray(array);

void Sumodd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
Console.WriteLine(sum);
}
Sumodd(array);
