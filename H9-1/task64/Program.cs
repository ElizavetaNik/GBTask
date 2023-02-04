using static System.Console;
Clear();

Write ("Введите число N:");
int numberN = Convert.ToInt32 (ReadLine());
int count = 1;
PrintNumbers(numberN,count);


void PrintNumbers(int num, int count)
{
    
    if ( count>num)
    {
        return;
    }
    else
    {
       
       PrintNumbers(num,count+1);
       Write (count + " "); 
    }
   

}