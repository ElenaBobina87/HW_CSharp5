// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] GetArray(int length, int min, int max)
{
    int[] arr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rand.Next(min, max + 1);
    return arr;
}

int[] array = GetArray(10, 100, 999);
System.Console.WriteLine(string.Join(' ', array));
int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        count++;
    }
    return count;
}

int result = Even(array);
System.Console.WriteLine($"В массиве {result} четных чесел");