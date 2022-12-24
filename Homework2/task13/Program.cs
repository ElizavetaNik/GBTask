using static System.Console;
Clear();
Write ("Введите число a:");
int a = int.Parse(ReadLine());
int max =999;
while (a> max)  a=a/10;
int b=a%10;

WriteLine (b>0 && a>99? b:"третьей цифры нет");





