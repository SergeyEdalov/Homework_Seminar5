﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Write("Enter array size: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];


void Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
Console.WriteLine($"[{string.Join(", ", array)}]");
}
Fillarray(array);

void EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count +=1;
    }
Console.WriteLine(count);
}

EvenCount(array);