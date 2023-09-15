// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int length, int min, int max)
{
    int[] arr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rand.Next(min, max + 1);
    return arr;
}

int[] array = GetArray(10, 1, 10);
System.Console.WriteLine(string.Join(' ', array));

int Sum (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i%2 ==1)
        sum = sum + array[i];
    }
    return sum;
}

int result = Sum(array);
System.Console.WriteLine($"Сумма чисел с нечетным индексом равна {result}");
