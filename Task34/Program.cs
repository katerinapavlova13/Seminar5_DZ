// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
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

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int oddnumcount = 0;
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            oddnumcount++;
    }
}
Console.WriteLine($"-> {oddnumcount} ");
