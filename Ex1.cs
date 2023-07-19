// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = new int[10];
int length = array.Length;
int count = 0;

void fullMass(int[] a)
{
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(100, 1000);
        Console.Write($"{a[i]}; ");
    }
    Console.WriteLine();
}

fullMass(array);

for (int j = 0; j < length; j++)
{
    if (array[j] % 2 == 0) count++;
}

Console.WriteLine($"Количество четных чисел: {count}");
