﻿ // Генератор случ.чисел мин/макс

Console.Clear();

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);   
    }
    return result;
}
int[] array = GetArray(10, -5, 18);
Console.WriteLine(String.Join(", ", array));


    


