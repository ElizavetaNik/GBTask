using static System.Console;
Clear();

Write ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [size];

ArrayRandom (numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];
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


WriteLine($"-> {max-min:f2}");

void ArrayRandom (double [] array)
{
    
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;     
        
    }
   
}
void PrintArray(double [] array)
{
    Write("["); 
    for (int i=0; i < array.Length-1; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length-1]}] "); 
}

