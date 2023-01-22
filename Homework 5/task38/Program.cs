using static System.Console;
Clear();

Write ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];

ArrayRandom (numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
   if (numbers[i] > max)
   {
    max = numbers[i];
   }
   else if (numbers[i] < min)
   {
    min = numbers[i];
   }
}


WriteLine($"-> {max-min}");

void ArrayRandom (int [] array)
{
    
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next (1,101);      
        
    }
   
}
void PrintArray(int [] array)
{
    Write("["); 
    for (int i=0; i < array.Length-1; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length-1]}] "); 
}

