// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

double [] array = new double[10];
int length = array.Length;
double result = 0;
double min = 0;
double max = 0;

void fullMass(double[] a)
{
    for (int i = 0; i < length; i++)
    {
        a[i] = Math.Round((new Random().NextDouble() * (10 - 1) + 1), 2); // Рандомные вещественные числа от 0 до 10 с округлением
        Console.Write($"{a[i]}; ");
    }
    Console.WriteLine();
}

fullMass(array);

max = array[0];
min = array[length-1];

for (int j = 0; j < length; j++)
{
    if (max < array[j]) max = array[j];

    else if (min > array[j]) min = array[j];
}

result =Math.Round((max - min), 2);

Console.WriteLine($"Максимальное число в массиве: {max}; минимально число в массиве: {min}; Разность чисел равна: {result}");
