using System.Diagnostics.Metrics;
using System.Runtime.InteropServices.Marshalling;

namespace C44_G02_doki_C_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-	Explain the difference between passing 


            //  نفسه  variable انا هننا ببعت نسخة من الفاليو مش ال   value type parametrs  by value  بص ياعم  انل لو عملت 
            //  لما تخلص الفاليو ال فيها مش هيحصل فيها تغيير  functaion  بمعني لو عملت   
            //   نفسه ف هيحصل تتغير عليه  variable  هنا ببعت ال ref  عكس ال 

            //int  x = 5;
            //int y = 10;
            //sum(ref x, ref y); //  ف القيم اختلفت  ref  هنا  استخدمت ال    
            //Console.WriteLine( x);
            //Console.WriteLine( y);
            #endregion


            #region 2-	Explain the difference between passing 

            // ف فالحالتين التتغير هيسمع    adderss هيسمع  عشان هي شايلة ال  value  هيسمع لو انا ف حالة ال  reference بص هنا ف الحاليتين لو حصل تغغير ف ال  
            // نفسه reference  لو غيرت ال  

            //int[] arr = [1, 2, 3, 4];
            // ChangeElementArray(arr);
            //Console.WriteLine(arr[0]);
            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int num1 = 5;
            //int num2 = 3;
            //int sum=0, sub=0;

            //summationAndsubtracting(num1,num2,out sum, out  sub);
            //summationAndsubtracting(num1,num2,ref sum, ref  sub);

            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion

            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //    int number;
            //    do
            //    {
            //       Console.Write("Enter a number: ");
            //    } while (!int.TryParse(Console.ReadLine(), out number));

            //    Console.WriteLine(DigitSum(number));

            #endregion

            #region 5-	Create a function named "IsPrime"

            //int number;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));
            //Console.WriteLine(IsPrime(number));
            #endregion


            #region 6-	Create a function named MinMaxArray

            //int[] num = [1, 7, 8, 10, 31, 2];

            //int min = 0, max = 0;
            //MinMaxArray(ref num, ref min, ref max);
            //Console.WriteLine(max);
            //Console.WriteLine(min);


            #endregion
            #region factorial

            //Console.WriteLine(factorial(5));

            #endregion

            #region ChangeChar

            string str = "Hello World";
            int index = 0; 
            char newChar = 'M';
          
            Console.WriteLine(ChangeChar(str, index, newChar));


            #endregion

        }


        #region Q1
        //public static void sum(ref int a,  ref int b)
        //{
        //    a += 1;
        //    b += 1;
        //}
        #endregion

        #region Q2
        //public static void ChangeElementArray(int[] Array)
        //{
        //    Array = [0, 1, 2, 3, 4, 5];// هنا خليته يشاور ع ادريس تاني ف بتاالي مش هيحصل تغيير 
        //    Array[0] = 7;
        //}
        #endregion

        #region Q3
        //public static void summationAndsubtracting(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;
        //}
        //public static void summationAndsubtracting(int num1, int num2,ref int sum,ref int sub)
        //{
        //    sum =num1 + num2;
        //    sub = num1 - num2;
        //}
        #endregion


        #region Q4

        //public static int DigitSum( int num)
        //{
        //    int sum= 0;
        //   int number = Math.Abs(num);
        //    while (number >0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}


        #endregion


        #region Q5
        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}

        #endregion

        #region Q6

        //public static void MinMaxArray(ref int[] arr, ref int min, ref int max)
        //{
        //    if(arr ==null|| arr.Length == 0)
        //    {
        //        return;
        //    }

        //    max = arr[0];
        //    min = arr[0];
        //    foreach(var item in arr)
        //    {
        //        if(item<min) min= item;
        //        if(item>max) max = item;
        //    }
        //}

        #endregion

        #region Q7

        //public static int factorial (int num)
        //{
        //    int result = 1;


        //    for(int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //        return  result;

        //}


        #endregion


        #region ChangeChar

        public static object ChangeChar (string str,int index, char newCahr)
        {
             string result ="";
            if (!string.IsNullOrEmpty(str)) {

                for (int i = 0; i < str.Length; i++)
                {
                    if (i == index)
                      result+= newCahr; 
                    else
                        result += str[i];
                  
                }


            };
            
            return result;
        }

        #endregion

    }
}