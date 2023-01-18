using static System.Console;
Clear();

Write ("Введите число a:");
int numberA = int.Parse(ReadLine());
int b = Numberlen(numberA);
SUM (numberA,b);

int Numberlen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SUM(int n, int b)
{
    int result = 0;
    for (int i=1; i <= b; i++)
    {
        result = result+n%10;
        n/=10;
        
    }
    WriteLine(result);

}