using System;

namespace FirstLesson
{
    class Program
    {

        static void Main(string[] args)
        {
            ex2();
            ex4();
            ex6();
            ex8();
        }

       
        static void ex2()
        {
            Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("The largest number: " + num1 + " \nThe smallest number: " + num2);
            else Console.WriteLine("The largest number: " + num2 + " \nThe smallest number: " + num1);
        }

         static void ex4()
        {
            Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
                Console.WriteLine("The largest number: " + num1);
            else if (num2 >= num1 && num2 >= num3)
                Console.WriteLine("The largest number: " + num2);
            else Console.WriteLine("The largest number: " + num3);
        }

        static void ex6(){
            Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным.");
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
                Console.WriteLine("Even-numbered");
            else Console.WriteLine("Not even-numbered");

        }

        static void ex8(){
            Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i < num; i++){
                    if(i % 2 == 0)
                        Console.WriteLine(i);
                }
        }

    }

}




