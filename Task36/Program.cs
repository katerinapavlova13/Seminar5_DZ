// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = rnd.Next(1, 10);
    }
    return arrays;
}

int[] res = RandArray(lenght);

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

int[] arr = RandArray(lenght);
int oddNumberCount = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) oddNumberCount += arr[i];
}
Console.WriteLine($"-> {oddNumberCount}");