Console.Write("Enter count columns in array: ");
int n = InputNum();
Console.Write("Enter count rows in array: ");
int m = InputNum();
Console.Write("Enter the minimum value in the array: ");
int min = InputNum();
Console.Write("Enter the maximal value in the array: ");
int max = InputNum();
double[,] array = new double[n,m];

FillArray2D(array);
PrintArray2D(array);


int InputNum()
{
    int num = int.Parse(Console.ReadLine());
    return num;
}
void PrintArray2D(double[,] arr)
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



double[,] FillArray2D(double[,] tabl)
{
    Random rnd = new Random();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i,j] = Math.Round(((rnd.NextDouble()) * rnd.Next(min, max)), 1);
        }
    }
    return tabl;
}