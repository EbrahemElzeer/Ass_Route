using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace C44_G02_doki_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double hours;
            //Console.WriteLine("enter your hours");
            //if(double.TryParse(Console.ReadLine(),out  hours))
            //{
            //    string massage = hours switch
            //    {
            //        < 2 => "is consider highly efficient.",
            //        >= 2 and < 3 => "is instructed to increase this speed.",
            //        >= 3 and < 4 => "is provided with training to enhance this speed.",
            //        >= 4 and < 5 => "is required to leave the company.",

            //        _=> "Invalid input."
            //    };
            //    Console.WriteLine(massage);

            //}
            //Console.WriteLine("invalid number format");


            //double hours;
            //bool isparse;
            //do
            //{
            //    Console.WriteLine("enter your hours");
            //    isparse = double.TryParse(Console.ReadLine(), out hours);
            //    if (hours <= 1)
            //        Console.WriteLine("inter hours >1");
            //} while (!isparse);


            //switch (hours)
            //{
            //    case < 2:
            //        Console.WriteLine("is consider highly efficient.");
            //        break;
            //    case >= 2 and < 3:
            //        Console.WriteLine("is instructed to increase this speed.");
            //        break;
            //    case >= 3 and < 4:
            //        Console.WriteLine("is provided with training to enhance this speed.");
            //        break;
            //    case >= 4 and < 5:
            //        Console.WriteLine("is required to leave the company.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input.");
            //        break;
            //}

            //if (hours >= 2 && hours <= 3)
            //    Console.WriteLine(" is consider highly efficient. ");
            //else if (hours >= 3 && hours <= 4)
            //    Console.WriteLine(" is instructed to increase this speed. . ");
            //else if (hours > 4 && hours <= 5)
            //    Console.WriteLine(" is provided with training to enhance this speed. ");
            //else if (hours > 5)
            //    Console.WriteLine("is required to leave the company. ");

            #endregion


            #region Q2

            //int  number;
            //bool isParse;
            //do
            //{
            //    Console.Write("enter your number: ");
            //    isParse = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParse);


            //    for (int i = 0; i < number; i++)
            //    {
            //        for (int j = 0; j < number; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }

            //        Console.WriteLine();

            //    }
            #endregion

            #region Q3

            //int[] arr = [1, 2, 3, 4, 5, 6];
            //int sum = 0;
            //foreach (int item in arr)
            //{
            //    sum += item;

            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //int [] arr1 = { 1, 3, 5, 7, 9 };
            //int[] arr2 = { 2, 4, 6, 8, 10 };

            //int[] merge = new int[arr1.Length + arr2.Length];
            //arr1.CopyTo(merge, 0);
            //arr2.CopyTo(merge, arr1.Length);
            //Array.Sort(merge);
            //foreach (int item in merge)
            //{
            //    Console.Write(item );
            //}

            //or
            //Console.WriteLine(string.Join(", ",merge));






            #endregion



            #region 5- Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 2, 2, 3, 3, 3, 4, 5 };
            //int count = 1;
            //int current = arr[0];

            //Array.Sort(arr);
            //for (int i = 1; i < arr.Length; i++)
            //{

            //    if (arr[i] == current)
            //    {
            //        count++;


            //    }
            //    else
            //    {
            //        Console.WriteLine($"{current}: {count}");
            //        current = arr[i];
            //        count = 1; 


            //    }

            //}
            //Console.WriteLine($"{current}: {count}");

            #endregion

            #region 6- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = [5, 6, 8, 2, 6, 7, 1];
            //Array.Sort(arr);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[arr.Length-1]);


            #endregion

            #region 7- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = [5, 6, 8, 2, 6, 7, 1];
            //Array.Sort(arr);

            //Console.WriteLine(arr[arr.Length-2]);
            #endregion


            #region -. Consider an Array of Integer values with size N, having values as    

            //int[] arr = [];
            //bool isParse;

            //   Console.WriteLine("Enter the size of the array (1,2,8,7): ");
            //  string input=Console.ReadLine();
            //    string[] inputArray = input.Split(',');

            //    arr= new int[inputArray.Length];
            //    for (int i = 0; i < inputArray.Length; i++)
            //    {
            //        arr[i] = input[i];
            //    }


            //int length=0;
            //int current = arr[0];
            //int max = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{

            //   for(int j = arr.Length - 1; j > i; j--)
            //    {

            //        if (arr[i] == arr[j])
            //        {
            //            length=j-i-1;
            //            if (length > max)
            //            {
            //                max = length;
            //            }

            //            break;
            //        }
            //    }


            //}
            //Console.WriteLine(max);
            #endregion
            #region Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("inter your string");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ",words));
            #endregion

            #region Write a program to create two multidimensional

            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,] arrFirst = new int[rows, cols];
            int[,] arrSecond = new int[rows, cols];
            Console.WriteLine("enter your element");
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine($"enter{i+1} ");
                string[] elements = Console.ReadLine().Split(' ');
                for(int j = 0; j < cols; j++)
                {
                    arrFirst[i, j] = int.Parse(elements[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arrSecond[i, j] = arrFirst[i, j];
                }
            }

          
            Console.WriteLine("\nSecond Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arrSecond[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}