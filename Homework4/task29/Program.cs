using static System.Console;
Clear();

int [] rendomArray = new int[8];
for (int i = 0; i < rendomArray.Length;i++)
{
    rendomArray[i] = new
    Random().Next(1,9);
     Write(rendomArray[i]+" ");

}

    

