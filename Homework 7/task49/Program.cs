using static System.Console;
Clear();
Write("Введите размер матрицы:");
string[]parmaters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double[,] array=GetMatrixArray(int.Parse(parmaters[0]),int.Parse(parmaters[1]));
PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns)
{
    double[,] resultArray=new double[rows,columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns  ; j++)
        {
            resultArray [i,j]=Convert.ToDouble(new Random().Next(-100,100)) / 10; 
        }
    }
     return resultArray;
}


void PrintMatrixArray(double[,] inArray)
{
     for(int i = 0; i < inArray.GetLength(0); i++)
     {
       for(int j = 0; j < inArray.GetLength(1); j++)
       {
        Write ($"{inArray [i,j],5}");
       }
       WriteLine();
     }
} 
