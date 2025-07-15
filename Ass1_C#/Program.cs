using System.Threading.Channels;

namespace Ass1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Q1


            //Console.Write("enter your Number");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int result))
            //{
            //    Console.WriteLine($"the Number is {result}");
            //}
            //else Console.WriteLine("Invalid Value");
            //#endregion


            //#region Q2

            //string text = "hfd35";
            //if (int.TryParse(text, out int num))
            //{
            //    Console.WriteLine(text);
            //}
            //else Console.WriteLine("Invalid Value");
            ////مش هيعرف يحولها عشان فيها string

            //#endregion


            #region Q3

            //Console.WriteLine("Enter Number 1");
            //string? num1 = Console.ReadLine();
            //Console.WriteLine("Enter Number 1");
            //string? num2 = Console.ReadLine();
            //if (float.TryParse(num1, out float number1) && float.TryParse(num2, out float number2) )
            //    {  float result = number1 + number2;
            //    Console.WriteLine($"the Result={result}");


            //} else Console.WriteLine("invalid value");


            #endregion

            #region Q4
            //Console.WriteLine("enter string");
            //string input = Console.ReadLine();
            //int start = 0;
            //    int length = 7;
            //if (length < input.Length)
            //    Console.WriteLine(input.Substring(start, length));
            //else Console.WriteLine("invalid vlaue");

            #endregion

            #region Q5

            //float x = 1553.55f;
            //int y =(int) x;
            //Console.WriteLine(y);
            //Expicilt cating علي مسؤليتي 
            // من الاكبر للاصغر يعني اما لو العكس ف مش هيحصل عادي  int ل float بص ياععم هنا هو هيطبع ال الرقم الصحيح فقط عشان انا بحول من 
            #endregion

            #region Q6

            //object ob1 = "Ebarhem";
            //Object ob2 = "Hema";
            //ob2 = ob1;//ob1 هنا هو بقي بءييشير للعنوان بتاع ال 
            //Console.WriteLine(ob2);// ob1عشان بقي بيشير ل نفس عنوان ال  Ebrahem  هنا هو هيطلع   
            //ob1 = "emad";
            //Console.WriteLine(ob2);// ob1عشان بقي بيشير ل نفس عنوان ال  emad  هنا هو هيطلع   
            // value  وreferanceوده الفرق بين ال   
            #endregion

            #region Q7
            //Console.WriteLine("enter your fname ");
            //string? fname = Console.ReadLine();
            //Console.WriteLine("enter your lname ");
            //string? lname = Console.ReadLine();

            //Console.WriteLine($"welcome: {fname} {lname}");

            #endregion

            #region Q8
            //Console.WriteLine("enter principal");
            //string? principal = Console.ReadLine();

            //Console.WriteLine("enter rate ");
            //string? rate = Console.ReadLine();

            //Console.WriteLine("enter Time(in ,month) ");
            //string? time = Console.ReadLine();
            //if (double.TryParse(principal, out double princ)
            //    && double.TryParse(rate, out double rated) &&
            //    double.TryParse(time, out double timed))

            //{
            //    double interest = (princ * rated * timed) / 100;
            //    Console.WriteLine(interest);

            //}
            //else Console.WriteLine("invalid");


            #endregion


            #region Q9


            //Console.WriteLine("enter your weight :");
            //string weight = Console.ReadLine();
            //Console.WriteLine("enter your Height (Meter)  :");
            //string Height = Console.ReadLine();

            //if (double.TryParse(weight, out double weightd)
            //    && double.TryParse(Height, out double Heightd))
            //{
            //    if (weightd <= 0 && Heightd <= 0) return;
            //    double BMI = (weightd) / (Heightd * Heightd);
            //    Console.WriteLine(BMI);
            //}
            //else Console.WriteLine("invalid");


            #endregion



            #region 10

            //Console.Write("enter temperature ");
            //string? temp = Console.ReadLine();
            //if (int.TryParse(temp, out int value))
            //{
            //    if (value < 10)
            //        Console.WriteLine("Just Cold");
            //    else if (value > 30) Console.WriteLine("Just Hot");
            //    else Console.WriteLine("Just Good");


            //}
            //else Console.WriteLine("invalid");
            #endregion


            #region 11

            //Console.Write("Enter Your date:");
            //    string date= Console.ReadLine();
            //if (DateTime.TryParse(date, out var date2)) {

            //    int year = date2.Year;
            //    int month = date2.Month;
            //    int day = date2.Day;
            //    Console.WriteLine($"Today’s date :{day},{month},{year}");
            //    Console.WriteLine($"Today’s date :{day}/{month}/{year}");
            //    Console.WriteLine($"Today’s date :{day}_{month}_{year}");


            //}else Console.WriteLine("invalid");

            #endregion



            #region 12
            //       Console.WriteLine("enter your number");
            //string? number = Console.ReadLine();
            //if(int.TryParse(number,out int num))
            //{
            //    if (num % 3 == 0 &&  num % 4 == 0) {
            //        Console.WriteLine("yes");
            //            }
            //    else Console.WriteLine("no");
            //} else Console.WriteLine("invalid");

            #endregion
            #region 13
            //Console.Write("insert your number");
            //string? number = Console.ReadLine();
            //if (int.TryParse(number, out int num))
            //{
            //    if (num < 0)
            //    {
            //        Console.WriteLine("negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("postive");
            //    }

            //}

            #endregion

            #region 14

            //Console.WriteLine("enter your 3 number");
            //string number1 = Console.ReadLine();
            //string number2 = Console.ReadLine();
            //string number3 = Console.ReadLine();
            //if (int.TryParse(number1, out int num1) &&
            //    int.TryParse(number2, out int num2) &&
            //    int.TryParse(number3, out int num3))
            //{
            //    int max = num1;
            //    int min = num1;
            //    if(num2>max)
            //        max = num2;
            //    if(num3>max)
            //        max = num3;

            //    if(num2<min)
            //        min = num2;
            //    if(num3<min)
            //        min = num3;

            //    Console.WriteLine($"max element{max}");
            //    Console.WriteLine($"min element{min}");



            //}


            #endregion

            #region 15
            //Console.Write("enter Your number ");
            //string? number1 = Console.ReadLine();
            //if(int.TryParse(number1,out int num))
            //{
            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine("Even ");
            //    }
            //    else Console.WriteLine("odd ");
            //}

            #endregion

            #region 16

            // Console.Write("enter Your char ");
            //string input = Console.ReadLine();
            // if (!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsLetter(input[0]))
            // {
            //     char let = char.ToLower(input[0]);
            //     if (let == 'a' || let == 'e' || let == 'i' || let == 'o' || let == 'u')
            //         Console.WriteLine("vowel");
            //     else Console.WriteLine("consonant");
            // }
            // Console.WriteLine("Invalid input. Please enter a single alphabetic character.");
            #endregion


            #region 17

            Console.Write("enter Your number ");
            string? number1 = Console.ReadLine();
            if (int.TryParse(number1, out int num))
            {
                switch (num)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.Write("Days 31 ");
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.Write("Days 30  ");
                        break;

                    case 2: Console.Write("Days 29 or 28 ");
                        break;
                    default: Console.WriteLine("Invalid month number! Please enter a number between 1 and 12.");
                        break;
                }

            }
            else Console.WriteLine("Invalid input! Please enter a valid integer.");
            #endregion
        }
    }
}
