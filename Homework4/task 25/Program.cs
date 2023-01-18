using static System.Console;
Clear();

Write ("Введите число a:");
int numberA = int.Parse(ReadLine());
Write ("Введите число b:");
int numberB = int.Parse(ReadLine());
ToDegree(numberA,numberB);


void ToDegree(int a, int b)
{
    int result = 1;
    for (int i=1; i <= b; i++)
    {
        result = result*a;
        
    }
    WriteLine(result);

}