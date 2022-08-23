// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) 
{
    double[] array = new double[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min; 
    }
    return array;   
}
void PrintArray(int[] res1)
{
    Console.Write($"[");
    for (int i = 0; i < res1.Length; i++)
    {
        Console.Write($"{res1[i]},");
    }
    Console.Write($"{res1[res1.Length - 1]}]");
}
PrintArray(res);
