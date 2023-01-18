using static System.Console;
Clear();

Write ("Введите число a:");
int numberA = int.Parse(ReadLine());
Write ("Введите число b:");
int numberB = int.Parse(ReadLine());
AB(numberA,numberB);


void AB(int a, int b)
{
    int result = 1;
    for (int i=1; i <= b; i++)
    {
        result = result*a;
        
    }
    WriteLine(result);

}