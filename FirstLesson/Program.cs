

using System;

namespace FirstLesson
{
    class Program{

        static void Main(string[] args){
            ex4();
        }

        //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
static void ex2(){
    Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 > num2)
        Console.WriteLine("The largest number: "+ num1 + " \nThe smallest number: " + num2);
    else Console.WriteLine("The largest number: "+ num2 + " \nThe smallest number: " + num1);
}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
static void ex4(){
    Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("Enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third number");
    int num3 = Convert.ToInt32(Console.ReadLine());

    if(num1 >= num2 && num1 >= num3)
        Console.WriteLine("The largest number: "+ num1);
    else if(num2 >= num1 && num2 >= num3)
        Console.WriteLine("The largest number: "+ num2);
    else Console.WriteLine("The largest number: "+ num3);
}
    }



}









