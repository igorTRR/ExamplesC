 // Генератор случ.чисел мин/макс

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

 int n = array.Length; // ищем позицию числа по индексу

 int find = 1;
int index = 0;

while ( index < n )
{
    if(array[index] == find) 
    {
       Console.WriteLine(index);  
        break;  // команда - break;- останавлиает цикл при первом нахождении (индекса) заданного числа (если схожих чисел в [] более1 )
    }             
    index ++;  // index= index+1
}






    


