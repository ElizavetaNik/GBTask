using static System.Console;
Clear();

Write ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];
int count = 0;
ArrayRandom (numbers);
PrintArray(numbers);

for (int i=0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}
WriteLine($"четных счисел -> {count}");


void ArrayRandom (int [] array)
{
    
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next (100,1000);      
        
    }
   
}
void PrintArray(int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
    WriteLine(); 
}