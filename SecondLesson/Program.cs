using System;

namespace FirstLesson
{
    class Program
    {

        static void Main(string[] args){
                ex15();
        }


        static void ex10(){
            Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            Console.WriteLine("Enter a three-digit number");
            int threeDigit = Convert.ToInt32(Console.ReadLine());

            if(threeDigit <= 999 && threeDigit >= -999){
                int res = threeDigit / 10 % 10;
                Console.WriteLine(res);
            }
            else  Console.WriteLine("You entered a non-three-digit number");  
        }

        static void ex13(){
            Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
            Console.WriteLine("Enter  number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result;

            if (number >= 100)
            {
                while (number > 999)
                {
                    number /= 10;
                }
                result = number % 10;
                Console.WriteLine(result);
            }
            else Console.WriteLine("There is no third digit");
           
        }
    
        static void ex15(){
            Console.WriteLine("Программа,  которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
            Console.WriteLine("Enter  number");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number){
                case 1: case 2: case 3: case 4: case 5:
                    Console.WriteLine("Is not a weekend");
                break;
                case 6: case 7:
                    Console.WriteLine("Is a weekend");
                break;

                default:
                    Console.WriteLine("The number does not correspond to the day of the week");
                break;
            }

        }
    }


}
