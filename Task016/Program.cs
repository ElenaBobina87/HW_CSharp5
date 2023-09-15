// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int length, int min, int max)
{
    double[] arr = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rand.Next(min, max) + rand.NextDouble();
    return arr;
}

double[] array = GetArray(10, -10, 10);
System.Console.WriteLine(string.Join(' ', array));

double Min(double[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
            min = i;
    }
    return array[min];
}

double minElement = Min(array);
System.Console.WriteLine($"Минимальный элемент массива равен {minElement}");

double Max(double[] array)
{
    int max = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[max])
            max = i;
    }
    return array[max];
}

double maxElement = Max(array);
System.Console.WriteLine($"Максимальный элемент массива равен {maxElement}");

System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {minElement - maxElement}");