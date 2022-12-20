using static System.Console;
WriteLine ("Введите число a:");
int a = int.Parse(ReadLine());
WriteLine ("Введите число b:");
int b = int.Parse(ReadLine());
int max = a;
int min = b;

if (a>max) max=a;
if (b>max) max=b;

Write ("max=");
WriteLine(max);

if (a<min) min=a;
if (b<min) min=b;

Write ("min=");
WriteLine(min);

