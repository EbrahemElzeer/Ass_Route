using System.ComponentModel.Design;

namespace C44_G02_doki_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ass1


            //int number;
            //bool isParse;
            //do
            //{
            //    Console.Write("enter your number");
            //    isParse = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParse);
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i);

            //}



            //input: Console.WriteLine("enter Your number");
            //   if(int.TryParse(Console.ReadLine(),out int number)){

            //        for(int i = 0; i < number; i++)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }else goto input;




            #endregion
            #region Ass2

            //  bool isParse;
            //  int number;
            //  do
            //  {
            //      Console.Write("inter your int number: ");
            //      isParse = int.TryParse(Console.ReadLine(), out number);
            //  }
            //  while (!isParse);
            //for( int i=1;i<13; i++)
            //  {
            //      Console.WriteLine(number*i);
            //  }



            #endregion

            #region Ass3

            //int number;
            //bool isParse;
            //do
            //{
            //    Console.Write("enetr your integer num ");
            //    isParse =int.TryParse(Console.ReadLine(),out number);
            //}
            //while (isParse==false);
            //for(int i = 2; i < number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ass4

            //int num1;
            //int num2;
            //bool isParse;
            //do
            //{
            //    Console.WriteLine("enter your integer 2number");
            //    isParse=int.TryParse(Console.ReadLine(),out num1);
            //    isParse=int.TryParse(Console.ReadLine(),out num2);
            //}while(!isParse);
            //double result = Math.Pow(num1,num2);
            //Console.WriteLine( result);


            #endregion

            #region Ass5
            //int number;
            //int number1;
            //int number2;
            //int number3;
            //int number4;
            //bool isParse;
            //do
            //{
            //    Console.WriteLine("enter your integer 5 marks : ");
            //    isParse =int.TryParse(Console.ReadLine(), out number);
            //    isParse =int.TryParse(Console.ReadLine(), out number1);
            //    isParse =int.TryParse(Console.ReadLine(), out number2);
            //    isParse =int.TryParse(Console.ReadLine(), out number3);
            //    isParse =int.TryParse(Console.ReadLine(), out number4);
            //}while(!isParse);

            //int sum = 0;
            //int average=0;
            //double presentage = 0;


            //sum=   number+= number1 + number2 + number3 + number4;
            //average = sum / 5;
            //    presentage = (double)sum / 500 * 100; // Assuming each mark is out of 100


            //Console.WriteLine($"the sum of 5 marks is {sum}");
            //Console.WriteLine($"the average of 5 marks is {average}");
            //Console.WriteLine($"the presentage of 5 marks is {presentage}");


            #endregion

            #region Ass6
            //string st = "";
            //string input = "";

            //do
            //{
            //    Console.WriteLine("Enter your string: ");
            //     input = Console.ReadLine();
            //}while (string.IsNullOrEmpty(input));

            //for (int R = input.Length-1; R >=0; R--)
            //    {
            //        st += input[R];


            //    }

            //Console.WriteLine(st);
            //Console.WriteLine("--------");

            #endregion

            #region Ass7
            //bool isParse;
            //int number;
            //string reverse = "";

            //do
            //{
            //    Console.WriteLine("enter int number");
            //    isParse = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!isParse);
            //string num = number.ToString();

            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    reverse += num[i];
            //}

            //int reversedNumber = int.Parse(reverse);
            //Console.WriteLine(reversedNumber);
            #endregion




            #region ass8
            // int start = 0;
            // int end = 0;
            // bool isparse;

            // do
            // {
            //     Console.WriteLine("enter number 1");
            //     Console.WriteLine("enter number 2");
            //     isparse = int.TryParse(Console.ReadLine(), out start);
            //     isparse =isparse&& int.TryParse(Console.ReadLine(), out end);
            // } while (!isparse);

            // for (int num = start; num < end; num++)
            // {
            //     if (num <= 1)
            //     {
            //         continue;
            //     }

            //     bool isPrime = true;
            //     for (int i =2;i<num;i++)
            //     {


            //         if (num % i == 0)
            //         {isPrime= false;
            //             break;
            //         }

            //     }


            //if(isPrime)
            //     {
            //         Console.WriteLine(num);
            //     }
            // }
            #endregion



            #region ASS9
            //string binary = "";
            //string result = "";

            //int number = 0;
            //bool isParse;

            //do
            //{
            //    Console.WriteLine("enter your number");
            //    isParse = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParse);
            //for (int i = number; i > 0;i/=2)
            //{

            //    binary = $"{i % 2}";
            //       result = binary+result;

            //}Console.WriteLine(result);

            #endregion



            #region 10

            //int x1=0; int y1 = 0;
            //int x2=0; int y2 = 0;
            //int x3=0; int y3 = 0;

            //bool isParse;
            //do
            //{
            //    Console.WriteLine("enter x1");
            //    isParse = int.TryParse(Console.ReadLine(), out x1);
            //    Console.WriteLine("enter y1");
            //    isParse = isParse && int.TryParse(Console.ReadLine(), out y1);
            //    Console.WriteLine("enter x2");
            //    isParse = isParse && int.TryParse(Console.ReadLine(), out x2);
            //    Console.WriteLine("enter y2");
            //    isParse = isParse && int.TryParse(Console.ReadLine(), out y2);
            //    Console.WriteLine("enter x3");
            //    isParse = isParse && int.TryParse(Console.ReadLine(), out x3);
            //    Console.WriteLine("enter y3");
            //    isParse = isParse && int.TryParse(Console.ReadLine(), out y3);
            //} while (!isParse);

            //int left= (x2 - x1) * (y3 - y1);
            //int right = (x3 - x1) * (y2 - y1);
            //bool res = (left, right) switch
            //{

            //    var (l, r) when l == r => true,
            //    _ => false



            //}; Console.WriteLine(res ? "The points are collinear." : "The points are not collinear.");

            #endregion

            #region 11
            //int number = 0;
            //bool isParse;
            //do
            //{
            //   Console.WriteLine("enter your number");
            //    isParse = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParse);
            //for(int i = 0; i <= number; i++)
            //{
            //    for(int j=0; j <= number; j++)
            //    {
            //        Console.Write(j==i?1:0);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }

    }
}