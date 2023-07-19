// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = new int[11];
int length = array.Length;
int sum = 0;

void fullMass(int[] a)
{
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(0, 26);
        Console.Write($"{a[i]}; ");
    }
    Console.WriteLine();
}

fullMass(array);

for (int j = 1; j < length; j +=2)
{
    sum = sum + array[j];
}

Console.WriteLine($"Сумма чисел на нечетных индексах массива: {sum}");
