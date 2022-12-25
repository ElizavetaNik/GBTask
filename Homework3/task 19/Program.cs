using static System.Console;
Clear();
Write ("Введите число n:");
int n = Convert.ToInt32 (ReadLine());

int a = n/10000;
int b = n/1000%10;
int c = n%100/10;
int d = n%10;
WriteLine (a==d && b==c ? "ДА":"НЕТ");

