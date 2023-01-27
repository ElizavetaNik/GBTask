using static System.Console;
Clear();
Write("Введите размер матрицы и диапазон значений через пробел:");
string[]parmaters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parmaters[0]),int.Parse(parmaters[1]),int.Parse(parmaters[2]),int.Parse(parmaters[3]));
PrintMatrixArray(array);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns ; j++)
        {
            resultArray[i,j]=rnd.Next(minValue,maxValue+1);
        }
    }
    return resultArray;
}
void PrintMatrixArray(int[,] inArray)
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