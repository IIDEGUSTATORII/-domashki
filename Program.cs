 
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
