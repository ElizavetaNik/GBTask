using static System.Console;
Clear();

Write ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];

ArrayRandom (numbers);
PrintArray(numbers);

int Sum = 0;
for (int i = 1; i < numbers.Length; i+= 2)
{
   Sum  += numbers[i]; 
}

Write(Sum);

void ArrayRandom (int [] array)
{
    
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next (-100,101);      
        
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
