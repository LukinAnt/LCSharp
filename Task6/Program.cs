// сем2
/*
int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);
//Console.WriteLine(arr[5]);

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
//они равны
int[] arr2 = { 1, 2, 3, 4, 5 };
*/
/*
int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < n)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
*/
/*
int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
*/
/*
//int n = 10;
int[] arr = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 }; ;
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
*/
/*
int n = 5;
int[] arr = { 2, 4, 7, 3, 9 };
int i = 0;
int max = arr[0];
while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = arr[0];
for (int j = 0; j < n; j++)
{
  if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine(max);

max = arr[0];
foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);
*/

//Лекция 3
/*
double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4);

Console.WriteLine(result);
*/
/*
void PrintSquares (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
*/



/*
void ZeroEventElements(int[] arr)
//обнулить четные элементы
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] array = { 1, 2, 3, 4, 5 };
ZeroEventElements(array);
PrintArray(array);
*/



// лекция 4




/* 
int[,] CreateMatrix(int rowCount, int columsCount)
{
   int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    } 
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) //вывод данных - интерполяция строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix); */

//-----------------------------------


/* 
int[,] CreateMatrix(int rowCount, int columsCount)
{
   int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    } 
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) //вывод данных - интерполяция строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if(InInteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
}
bool InInteresting(int value)
{
int sumOfDigits = GetSumOfDigits(value);
if(sumOfDigits % 2 == 0)
{
    return true;
}
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0; 
    while(value>0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
} */

/* string GetLettersFromStr(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
string str = Console.ReadLine();
string letters = GetLettersFromStr(str);
Console.WriteLine(letters); */