using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1");
            Console.Write(Environment.NewLine);
            //int[] arr = new int[5] { 2, 2, 2, 2, 2 };
            //Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]}]");
            Console.WriteLine($"Final Score: {Challenge1.Grade(Challenge1.CheckArray(), Challenge1.ChooseNumber())}");
            Console.Write(Environment.NewLine);

            Console.WriteLine("Challenge 2");
            Console.Write(Environment.NewLine);
            Console.WriteLine(Challenge2.LeapYear());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Challenge 3");
            Console.Write(Environment.NewLine);
            int[] test = new int[3] { 1, 3, 2 };
            Console.WriteLine(Challenge3.CheckSequence(test));
            Console.Write(Environment.NewLine);

            Console.WriteLine("Challenge 4");
            Console.Write(Environment.NewLine);
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                Console.Write("[");
                for (int i = 0; i < myArray.GetLength(1); i++)
                {
                    Console.Write(string.Format("{0}", myArray[x, i]));
                    if (i < myArray.GetLength(1) - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Sum of Each Row");
            Console.WriteLine("[" + string.Join(",", Challenge4.RowSum(myArray)) + "]");
        }
    }
    class Challenge1
    {
        public static int Grade(int[] numbers, int selection)
        {
            int times = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (selection == numbers[i])
                {
                    times++;
                }
            }
            int score = selection * times;
            return score;
        }
        public static int[] CheckArray()
        {
            Console.WriteLine("Select 5 Numbers between 1-10");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                int arrSpot = i + 1;
                Console.WriteLine($"Choose number {arrSpot}");
                var input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                arr[i] = num;
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]}]");
            Console.Write(Environment.NewLine);
            return arr;
        }
        public static int ChooseNumber()
        {
            Console.WriteLine("Pick a number to be checked");
            var input = Console.ReadLine();
            int selection = Convert.ToInt32(input);
            return selection;
        }

    }
    class Challenge2
    {
        public static string LeapYear()
        {
            Console.WriteLine("Enter a year");
            var input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            string yes = year + " is a leap year.";
            string no = year + " is not a leap year.";
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return no;
                }
                else
                {
                    return yes;
                }
            }
            else
                return no;
        }
    }
}

class Challenge3
{
    public static string CheckSequence(int[] arr)
    {
        Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]}]");
        int theSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            theSum = theSum + arr[i];
        }
        int theProduct = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            theProduct = theProduct * arr[i];
        }
        Console.WriteLine($"Sum: {theSum}");
        Console.WriteLine($"Product: {theProduct}");
        if (theSum == theProduct)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
}
class Challenge4
{
    public static int[] RowSum(int[,] arr)
    {
        int[] result = new int[3];
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            int sum = 0;
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                sum = sum + arr[m, n];
            }
            result[m] = sum;
        }
        return result;
    }
}
