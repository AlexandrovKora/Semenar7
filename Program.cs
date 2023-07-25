/* Двумерные массивы. ()
*/
/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

*/

/*
Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aij = i+j. Выведите полученный массив на экран.
*/
/*
int [,] Create2dArray(int rows, int columns)
{
    int[,]array = new int[rows, columns];
    for (int i = 0; i<rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array[i,j]=i+j;
        }
    } return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dArray(rows, columns);

Show2dArray(array);
*/
/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

void Transfor2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        if (i%2==0 && j%2==0) array[i,j]*=array[i,j];
    }
}


Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

Console.WriteLine();
Transfor2dArray(myArray);

Show2dArray(myArray);
*/

/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    
        for(int j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

int CountSum(int[,] array)
{
    int result = 0;
    for(int i = 0, j = 0; i<array.GetLength(0) && j<array.GetLength(1); i++ , j++)
    result = result + array[i,j];
    return result;
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

int result = CountSum(myArray);
Console.WriteLine(result);