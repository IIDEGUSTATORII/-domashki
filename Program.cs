
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
            if (num1 > num2)
            {
                Console.WriteLine("max = " + num1);
            }
            else
            {
                Console.WriteLine("max = " + num2);
            }
            }
          


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int m = num1;

            if (num2 > m)
            {
                m = num2;
            }

            if (num3 > m)
            {
                m = num3;
            }

            Console.WriteLine("max = " + m);
         
         // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
         
int num;
            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("нет");
            }
    
     // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int a = 1 , num ;
            bool b = true;

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от: до " + num);
            while (a <= num)
            {
                if (a % 2 != 1)
                {
                    Console.Write(a + ", ");
                    b = false;
                }
                a++;
            }

            if (b)
            {
                Console.WriteLine("Четных числе нет");
            }

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int amount = n.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число или оно отрицательное");
}
else
{
    int a = n/10;
    a = a % 10;
    Console.WriteLine(a);
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int amount = n.ToString().Length;
if (amount < 3)
{
    Console.WriteLine("В числе нет 3-ей цифры");
}
else {
    
    if (n >= 100)
            {
                while (n > 999)
                {
                    n = n / 10;
                }
                n = n % 10;
               Console.WriteLine(n);
            }
          
        }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число дня недели: ");
            int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7) {
    Console.WriteLine("Вы ввели неверное число");
    }
    else { 
        if (n > 5) {
            Console.WriteLine("Выходной");
        }
        else {
            Console.WriteLine("Будний день");
        }

    }

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int a = n.Length;

if (a == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"{n} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{n} - Не палнидром");
    }
}
else
{
    Console.WriteLine($" {n} - Не является пятизначным");
}

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите количество кубов");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{ 
    Console.Write($"{i*i*i} ");
}

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень");
int b = Convert.ToInt32(Console.ReadLine());
int s = a;

for (int i = 1; i < b; i++) 
{
s = s * a;
}
Console.WriteLine(s);

 //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int s = 0;

while (i > 0)
{
int n = i % 10;
i = i / 10;
s = s + n;
}
Console.WriteLine("сумма цифр = " + s);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] n = new int[8];
Console.Write("[");

for (int i = 0; i < n.Length; i++)
 {
    n [i] = new Random().Next(0, 9999);
    Console.Write(Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return n[a];
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
int a = 0;
FillArrayRandomNumbers(n);
PrintArray(n);


for (int i = 0; i < n.Length; i++)
{
    if (n[i] % 2 == 0)
    a++;
}


Console.WriteLine($"количество чётных чисел -> {a} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{  Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
int s = 0;
FillArrayRandomNumbers(n);
PrintArray(n);

for (int i = 1; i < n.Length; i += 2)
{
    s += n[i];
}
Console.Write("Сумма элементов, стоящих на нечётных позициях:"+s);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] array)
{ Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] n = new double[size];
FillArrayRandomNumbers(n);
PrintArray(n);

double max = n[0];
double min = n[0];

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > max)
    {
        max = n[i];
    }
    else if (n[i] < min)
    {
        min = n[i];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 1000)+ new Random().NextDouble();
    }
}


void PrintArray(double[] array)
{ Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
} 
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа (через пробел)");
int[] n = StringToNum(Console.ReadLine());
PrintArray(n);
int s = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
        s++;
    }
}
Console.WriteLine();
Console.WriteLine($"Чисел больше 0: {s}");
int[] StringToNum(string a)
{
    int count = 1;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ' ')
        {
            count++;
        }
    }

    int[] n = new int [count];
    int index = 0;

    for (int i = 0; i < a.Length; i++)
    {
        string temp = "";

        while (a [i] != ' ')
        {
        if(i != a.Length - 1)
        {
            temp += a [i].ToString();
            i++;
        }
        else
        {
            temp += a [i].ToString();
            break;
        }
        }
        n[index] = Convert.ToInt32(temp);
        index++;
    }
    return n;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
} 
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
if ((k1 == k2) && (b1 == b2)) 
{
 Console.WriteLine("Прямые совпадают");
}
else 
     {if (k1 == k2)
     {
      Console.WriteLine("Прямые параллельны");
     }
     else
     {
     double x = (b2- b1) / (k1 - k2);
     double y = k1 * x + b1;
     Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");}}
     
     //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
int r = ReadInt("Введите кол-во строк: ");
int c = ReadInt("Введите кол-во столбцов: ");
double[,] n = new double[r, c];
FillArray(n);
PrintArray(n);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int r = ReadInt("Введите индекс строки: ");
int c = ReadInt("Введите индекс столбца: ");
int[,] n = new int[6, 8];
FillArray(n);
PrintArray(n);

if (r < n.GetLength(0) && c < n.GetLength(1)) Console.WriteLine(n[r, c]);
else Console.WriteLine($"{r} {c}  такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int r = ReadInt("Введите кол-во строк: ");
int c = ReadInt("Введите колв-во стобцов: ");
int[,] n = new int[r, c];
FillArray(n);
PrintArray(n);

double[] a = new double[n.GetLength(1)];

for (int i = 0; i < n.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < n.GetLength(0); j++)
    {
        result += n[j, i];
    }
    a[i] = result / n.GetLength(0);
}
PrintArray(a);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] n = new int[10, 10];
FillArray(n);
PrintArray(n);
Console.WriteLine("Преобразованный массив: ");
soortirovka(n);
PrintArray(n);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void soortirovka(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] n = new int[3, 3];
FillArray(n);
PrintArray(n);
Console.WriteLine();
soortirovka(n);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void soortirovka(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < n.GetLength(1); i++)
    {
        minRow += n[0, i];
    }
    for (int i = 0; i < n.GetLength(0); i++)
    {
        for (int j = 0; j < n.GetLength(1); j++) sumRow += n[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int r = 10;

int[,] fm = new int[m, n];
FillArray(fm);
Console.WriteLine($"Первая матрица:");
PrintArray(fm);

int[,] sm = new int[n, p];
FillArray(sm);
Console.WriteLine($"Вторая матрица:");
PrintArray(sm);

int[,] rm = new int[m,p];

preobr(fm, sm, rm);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(rm);

void preobr(int[,] fm, int[,] sm, int[,] rm)
{
  for (int i = 0; i < rm.GetLength(0); i++)
  {
    for (int j = 0; j < rm.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < fm.GetLength(1); k++)
      {
        sum += fm[i,k] * sm[k,j];
      }
      rm[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(r);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();

int[,,] n = new int[x, y, z];
FillArray(n);
PrintArray(n);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray (int[,,] n)
{
  for (int i = 0; i < n.GetLength(0); i++)
  {
    for (int j = 0; j < n.GetLength(1); j++)
    {
      for (int k = 0; k < n.GetLength(2); k++)
      {
        Console.Write( $"{n[i,j,k]}({i}, {j}, {k})");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillArray(int[,,] n)
{
  int[] temp = new int[n.GetLength(0) * n.GetLength(1) * n.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < n.GetLength(0); x++)
  {
    for (int y = 0; y < n.GetLength(1); y++)
    {
      for (int z = 0; z < n.GetLength(2); z++)
      {
        n[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int s = 4;
int[,] n = new int[s, s];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n.GetLength(0) * n.GetLength(1))
{
  n[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= n.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > n.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(n);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}