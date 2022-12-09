 
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
            