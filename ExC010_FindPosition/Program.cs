int[] array = {1,8,23,41,5,18,27,18};

int n = array.Length;

int find = 18;
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

