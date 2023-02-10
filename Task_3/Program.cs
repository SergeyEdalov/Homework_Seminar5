// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("Enter array size: ");
double[] array = new double[Convert.ToInt32(Console.ReadLine())];

void Fillarray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 20, 2);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
Fillarray(array);

Console.WriteLine(Math.Round(array.Max() - array.Min(),2));
