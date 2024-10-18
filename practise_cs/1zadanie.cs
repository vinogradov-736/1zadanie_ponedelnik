using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_cs
{
    internal class Program
    {
        public static void back()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any button to back to main?");
            Console.ReadLine();
            Console.Clear();
        }
        public static void firstTask()
        {
            try
            {
                Console.WriteLine("Enter first number");
                float gojo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                float b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter third number");
                float geto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter forth number");
                float d = Convert.ToInt32(Console.ReadLine());
                float result = (gojo + b + geto + d) / 4;
                Console.WriteLine("The answer is: " + result);
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void secondTask()
        {
            try
            {
                Console.WriteLine("Enter first number");
                float first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                float second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What you wanna do?");
                Console.WriteLine("a) add");
                Console.WriteLine("b) substract");
                Console.WriteLine("c) multiply");
                Console.WriteLine("d) devide");
                Console.WriteLine("e) remainder from division");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "a":
                        Console.WriteLine($"{first} + {second} = {first + second}");
                        break;
                    case "b":
                        Console.WriteLine($" {first} - {second} = {first - second}");
                        break;
                    case "c":
                        Console.WriteLine($" {first} * {second} = {first * second}");
                        break;
                    case "d":
                        Console.WriteLine($" {first} / {second} = {first / second}");
                        break;
                    case "e":
                        float answer = first % second;
                        Console.WriteLine($" {first} % {second} = {answer}");
                        break;
                    default:
                        Console.WriteLine("20:31 pribil Gojo Satoru");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("20:31 pribil Gojo Satoru");
            }
            back();
        }
        public static void thirdTask()
        {
            try
            {
                Console.WriteLine("Select the temperature input scale:");
                Console.WriteLine("1) Celsius");
                Console.WriteLine("2) Kelvin");
                Console.WriteLine("3) Fahrenheit");

                string firstDegreeType = Console.ReadLine();
                Console.WriteLine("Enter the temperature");
                float firstDegree = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select the temperature input scale:");
                Console.WriteLine("1) Celsius");
                Console.WriteLine("2) Kelvin");
                Console.WriteLine("3) Fahrenheit");
                string secondDegreeType = Console.ReadLine();
                if (firstDegreeType == secondDegreeType)
                {
                    Console.WriteLine();
                }
                else if (firstDegreeType == "1" && secondDegreeType == "2")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {273.15 + firstDegree}");
                }
                else if (firstDegreeType == "1" && secondDegreeType == "3")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {30 + (2 * firstDegree)}");
                }
                else if (firstDegreeType == "2" && secondDegreeType == "1")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {-273.15 + firstDegree}");
                }
                else if (firstDegreeType == "2" && secondDegreeType == "3")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {(firstDegree - 273.15) * 9 / 5 + 32}");
                }
                else if (firstDegreeType == "3" && secondDegreeType == "1")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {(firstDegree - 30) / 2}");
                }
                else if (firstDegreeType == "3" && secondDegreeType == "2")
                {
                    Console.WriteLine($" {firstDegree} Celsius in Kelvin = {(firstDegree - 32) / 9 / 5 + 273.15}");
                }
            }
            catch
            {
                Console.WriteLine("I LOVE U");
            }
            back();
        }
        public static void forthTask()
        {
            try
            {
                Console.WriteLine("Enter your path");
                string str = Console.ReadLine();
                string[] parts = str.Split('/');

                Console.WriteLine(parts[parts.Length - 1]);
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void fithTask()
        {
            try
            {
                Console.WriteLine("Enter your sentence");
                string str = Console.ReadLine();

                string[] parts = str.Split(' ');

                string maxlen = "";

                for (int i = parts.Length - 1; i >= 0; i--)
                {
                    string currentlen = parts[i];
                    if (maxlen.Length < currentlen.Length)
                    {
                        maxlen = parts[i];
                    }
                }
                Console.WriteLine("The longiest word is " + maxlen);
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void sixthTask()
        {
            try
            {
                Console.WriteLine("Enter you first arrey separetad be space");
                string str = Console.ReadLine();
                string[] firstArrey = str.Split(' ');
                Console.WriteLine("Enter you second arrey separetad be space");
                str = Console.ReadLine();
                string[] secondArrey = str.Split(' ');
                for (int i = 0; i < firstArrey.Length; i++)
                {
                    Console.Write($"{Convert.ToInt32(firstArrey[i]) * Convert.ToInt32(secondArrey[i])} ");
                }
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void seventhTask()
        {
            try
            {
                Console.WriteLine("Enter your five numbers separetad be space");
                string str = Console.ReadLine();
                string[] parts = str.Split(' ');
                int maxnum = -999999999;
                int minnum = 999999999;
                for (int i = 0; i < parts.Length; i++)
                {
                    if (maxnum < Convert.ToInt32(parts[i]))
                    {
                        maxnum = Convert.ToInt32(parts[i]);
                    }
                }

                for (int i = 0; i < parts.Length; i++)
                {
                    if (minnum > Convert.ToInt32(parts[i]))
                    {
                        minnum = Convert.ToInt32(parts[i]);
                    }
                }

                Console.WriteLine($"The max number is {maxnum}");
                Console.WriteLine($"The min number is {minnum}");
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void eightTask()
        {
            try
            {
                Console.WriteLine("Enter the number of steps");
                int steps = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                string pyromid = "";
                for (int i = 1; i <= steps; i++)
                {
                    pyromid += i;
                    Console.WriteLine(pyromid);
                }
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void partTwo()
        {
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write($"{i} x {j} = {i * j} | ");
                    }
                    Console.WriteLine("");

                }
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        public static void partThree()
        {
            try
            {
                Console.WriteLine("Choose the task in part 3");
                Console.WriteLine("1) integers up to 100");
                Console.WriteLine("2) integers from -100 to 5");
                Console.WriteLine("3) all even number from 1 to 100");
                string choose = Console.ReadLine();
                Console.Clear();
                switch (choose)
                {
                    case "1":
                        for (int i = 1; i <= 100; i++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("");
                        break;
                    case "2":
                        for (int i = -100; i <= 5; i++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("");
                        break;
                    case "3":
                        for (int i = 2; i <= 100; i += 2)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("You entered the wrong number");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("You entered the wrong value");
            }
            back();
        }
        static void Main(string[] args)
        {
            bool end = false;
            while (true)
            {
                Console.WriteLine("Choose the task");
                Console.WriteLine("1) awerage of numbers");
                Console.WriteLine("2) 'calculator'");
                Console.WriteLine("3) degree convertation");
                Console.WriteLine("4) 'pathfinder'");
                Console.WriteLine("5) longiest word");
                Console.WriteLine("6) arreys multiplying");
                Console.WriteLine("7) min max");
                Console.WriteLine("8) pyramid");
                Console.WriteLine("9) part 2, Multiplication table");
                Console.WriteLine("10) part 3, Chopse the range of integers");
                string choose = Console.ReadLine();
                Console.Clear();
                switch (choose)
                {
                    case "1":
                        firstTask();
                        break;
                    case "2":
                        secondTask();
                        break;
                    case "3":
                        thirdTask();
                        break;
                    case "4":
                        forthTask();
                        break;
                    case "5":
                        fithTask();
                        break;
                    case "6":
                        sixthTask();
                        break;
                    case "7":
                        seventhTask();
                        break;
                    case "8":
                        eightTask();
                        break;
                    case "9":
                        partTwo();
                        break;
                    case "10":
                        partThree();
                        break;
                    default:
                        Console.WriteLine("You killed satoru");
                        back();
                        break;
                }
            }
        }
    }
}
