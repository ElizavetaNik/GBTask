using static System.Console;
Clear();

Write ("Введите числа:");
int[]numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int Sum = 0;
for (int i = 1; i < numbers.Length; i++)
{  if (numbers[i]>0)

{
     Sum++;
}
   
}
 WriteLine();
 WriteLine($"-> = {Sum}");

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length;i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

int[]numbers = new int [count];
int index = 0;

for (int i = 0; i < input.Length;i++)
{
    string temp = "";

    while (input[i] !=',' )
    {
        if (i != input.Length-1)
        {
            temp +=input[i].ToString();
            i++;
        }
        else
        {
           temp +=input[i].ToString();
            break; 
        }

    }
    numbers[index] = Convert.ToInt32(temp);
    index++;
}
 return numbers;
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
