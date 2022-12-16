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