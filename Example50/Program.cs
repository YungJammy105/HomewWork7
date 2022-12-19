Console.Clear();
Console.Write("Enter the row index into the array: ");
int indexRow = int.Parse(Console.ReadLine());
Console.Write("Enter the column index into the array: ");
int indexColumn = int.Parse(Console.ReadLine());

int[,] array = new int[6,8];

FillArray2D(array);
Console.WriteLine();
PrintArray2D(array);
Console.WriteLine();
FindNumByIndexInArray();





void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]);
            Console.Write(" ");

        }
        Console.WriteLine();
    }
}


int[,] FillArray2D(int[,] tabl)
{
    Random rnd = new Random();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i,j] = rnd.Next(10,100);
        }
    }
    return tabl;
}

void FindNumByIndexInArray()
{
    if (indexRow < 0 | indexRow > array.GetLength(0) - 1 | indexColumn < 0 | indexColumn > array.GetLength(1) - 1)
    {
        Console.WriteLine("Element does not exist");
    }
    else
    {
        Console.WriteLine("Array element value = {0}", array[indexRow, indexColumn]);
    }    
}