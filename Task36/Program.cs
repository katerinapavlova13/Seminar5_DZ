// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

FillArrayRandomNumbers(array);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0) sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine($"Cумма элементов на нечётных позициях -> {sum}");
