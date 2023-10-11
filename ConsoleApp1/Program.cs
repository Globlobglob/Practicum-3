using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            




            /*Console.Write("Год");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 4 == 0)

            {

           Console.Write($"{a}високосный");

            }

            else {

                Console.Write("Год не високосный");

                    }*/



            /* Console.Write("Цена ноутбука");

             int a = Convert.ToInt32(Console.ReadLine());



             if(a>=20000 & a<=30000)

             {

                 Console.Write("Входит в диапазон");

             }

             else {

                 Console.WriteLine("Не входит");

             }

             Console.ReadKey();*/



            /*Console.WriteLine("Введите  балл ");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x <= 60)

                Console.WriteLine("неуд");

            if (x >= 60&x<=74)

                Console.WriteLine("удовл");

            if(x >= 75 & x <= 89)

                Console.WriteLine("хорошо");

            if(x >= 90& x <= 100)

                Console.WriteLine("отлично");

            */



            /* // Console.WriteLine("Enter a number");

              Random rnd = new Random();

              int number = rnd.Next(1,3);

              //int number = Convert.ToInt32(Console.ReadLine());

            

              if (number == 1)

                  Console.WriteLine("red");

              if (number == 2)

                  Console.WriteLine("green");

              if (number == 3)

                  Console.WriteLine("blue"); */

            /*
            Random rnd = new Random();
            int number = rnd.Next();

            if (number % 2 == 0)

            {
                Console.Write($" {number} четное ");

            }
            else
            {
                Console.Write($"{number}число не четное ");

            }

            if (number * number >0)
            {
                Console.Write($" {number}положительное");

            }
            else
            {
                Console.Write ($"{number} отриц ");
            }*/

            /*
            Console.Write("Enter week day= ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                 
                case 2:
                    Console.WriteLine(" tuesday");
                    break;
                case 3:
                    Console.WriteLine(" wednesday");
                    break;
                case 4:
                    Console.WriteLine(" thursday");
                    break;
                case 5:
                    Console.WriteLine(" friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine(" sunday");
                    break;
                default:
                    Console.WriteLine("error");
                    goto case 1;
                    
            }*/

            /*
            Console.Write("Login:  ");
            string log = Console.ReadLine();
            Console.Write("Password:  ");
            string pass = Console.ReadLine();

            Console.WriteLine("Проверка логина и пароля");

           way: Console.Write("Login :  ");
            string log1 = Console.ReadLine();
            if
                (log == log1)
            {
                Console.WriteLine("Done (^-^)");

            }

            else { Console.WriteLine("ERROR (-__-) "); goto way;  }
           way2: Console.Write("Password:  ");
            string pass1= Console.ReadLine();
          if
                (pass == pass1)
            { Console.WriteLine("Done ^-^"); }
            else { Console.WriteLine("ERROR (-__-) "); goto way2; }
            */
            /*
            Console.Write("Number a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите действие ");
            char act = Convert.ToChar(Console.ReadLine());

           

            switch (act) 
            { 
              case '+':Console.Write(a + b)  ;break;
                case '-': Console.Write(a - b); break;
                case '*': Console.Write(a * b); break;
                case '/': Console.Write(a / b); break;
                   
            }
      */
            Console.WriteLine("Age = ");
            byte age = Convert.ToByte(Console.ReadLine());

            string AgeGroup;
            switch (age)
            {
                case byte n when (n <= 0):
                    AgeGroup = "Некорректный возраст";
                    break;
                case byte n when (n <= 12&&n>=0):
                    AgeGroup = "Дети ";
                    break;
                case byte n when (n <= 18&&n>=12):
                    AgeGroup = "Подростки";
                    break;
                case byte n when (n <= 50&&n>=18):
                    AgeGroup = "Взрослые";
                    break;
                case byte n when (n <= 100&&n>=50):
                    AgeGroup = " Старики";
                    break;
                default:AgeGroup = "Неккоректный возраст";
                    break;

            }

            Console.WriteLine($"вы относитесь к {AgeGroup}  ");













        }
    }
    
}
