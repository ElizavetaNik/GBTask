using static System.Console;
Clear();
Write ("Введите число a:");
int a = int.Parse(ReadLine());
int i=1;
while (i < a+1)  
{
   WriteLine ($"Квадрат числа {i} = {Math.Pow(i,3)}"); 
   i++;
}






