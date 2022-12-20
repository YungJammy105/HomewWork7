double[,] collection = FillArray2D(4,4);
PrintArray2D(collection);
double[] average = ArithmeticMeanOfEachColumnInArray(collection);
Console.WriteLine($"The arithmetic mean of each column is: [{string.Join(", ", average)}]");

double[] ArithmeticMeanOfEachColumnInArray(double[,] arr2D)
{
    double[] coll = new double[arr2D.GetLength(1)];
    double sumAverage = 0;
    int index = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sumAverage = sumAverage + arr2D[j,i];
        }
        coll[index] = Math.Round(sumAverage / arr2D.GetLength(0), 2);
        index++;
        sumAverage = 0;
    }
    return coll;
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



double[,] FillArray2D(int row, int column)
{
    double[,] tabl = new double [row,column];
    Random rnd = new Random();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i,j] = rnd.Next(0,10);
        }
    }
    return tabl;
}