// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] RandArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

double[] DiffNumber(double[] array)
{

    double maxnumber = array[0];
    double minnumber = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxnumber < array[i]) maxnumber = array[i];
        if (minnumber > array[i]) minnumber = array[i];
        difference = maxnumber - minnumber;
    }
    return new double[] { difference };
}

void PrintArray(double[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {Math.Round(array[i], 2, MidpointRounding.AwayFromZero)};");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
double[] arr = RandArray(10, 1, 20);
PrintArray(arr);
double[] diffNumber = DiffNumber(arr);
Console.Write($" -> {Math.Round(diffNumber[0], 2, MidpointRounding.AwayFromZero)}");

