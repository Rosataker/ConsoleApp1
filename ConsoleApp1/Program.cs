using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var OtherFunClass = new OtherFun();
            OtherFunClass.LambdaFun2();

        }
    }
    

    class OtherFun
    {

        public void LambdaFun2()
        {

            const int four = 4;
            Func<int, int> addOne = x => x + 1;
            Func<int, int, int> calcArea = (x, y) => x * y; // two parameters
            Func<int> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters
            Console.WriteLine(twentyFive());
         
        }
        public void LambdaFun()
        {
            Func<int, int> addOne = x => x + 1; // this is the lambda expression
            Console.WriteLine(addOne(4));
        }
        public void Looping_collections(){
            var myary = new List<int>() {2,4,6};
            Console.WriteLine("Numbers: " + String.Join(" ", myary));
            Console.WriteLine("Sum:" + myary.Sum(x => Convert.ToInt32(x)));
        }
        static void CreatAryFun()
        {
            var myary = new List<string>() { "AAA", "BBB", "CCC", "4" };
            int i = 0;
            foreach (var Showstr in myary)
            {
                Console.WriteLine($"Now : {Showstr}");
            }

            while (i < myary.Count)
            {
                Console.WriteLine($"i:{i} , {myary[i]}");
                i++;
            }
            string output = String.Join(" | ", myary);
            Console.WriteLine(output);

        }
        static void LoopWhile()
        {
            int Numround = new Random().Next(1, 101);
            int CheckNum = 0;
            Console.WriteLine($"Guess the number is {Numround} ");
            while (Numround != CheckNum)
            {
                Console.WriteLine("Guess the number (1 to 100): ");
                CheckNum = int.Parse(Console.ReadLine());
                if (CheckNum > Numround)
                {
                    Console.WriteLine("Oops! too high! retry ");
                }
                if (CheckNum < Numround)
                {
                    Console.WriteLine("Oops! too low! retry ");
                }
            }
            Console.WriteLine("You Got it!");

        }

        static void InputText()
        {
            Console.WriteLine("try input 1~4 or nothing !");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("You input one !");
                    break;
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("You input two ~ four !");
                    break;
                default:
                    Console.WriteLine($"You input {answer} !");
                    break;
            }
        }

        static void Great(string name)
        {
            if (String.IsNullOrEmpty(name)) return;
            Console.WriteLine($"Hello, {name}!");
        }

        static void Sub1()
        {
            //一萬天可以過幾次生日
            DateTime mydate = new DateTime(2017, 12, 19);

            TimeSpan duration = mydate.AddYears(1) - mydate;
            var WdayiswhatDay = Math.Round(10000 / duration.TotalDays, 0);

            Console.WriteLine($"mydate:{mydate} , oneYearAfter: {duration.TotalDays}  , totalBdate:{WdayiswhatDay}");
        }
    }

    class DynamicAry
    {
        public void UserAPI()
        {

            var myary = new List<string>();
            Console.WriteLine("You can input + item , add Ary ");
            Console.WriteLine("You can input - item , del Ary ");
            Console.WriteLine("You can input -- , Clear Ary ");
            Console.WriteLine("You can input break , exit Loop ");

            string LoopStatus = "";
            string StatusStr = null, itemStr = null;

            while (LoopStatus != "break")
            {
                var Status = Console.ReadLine();

                if (Status.Length > 1)
                {
                    itemStr = Status.Substring(2);
                    StatusStr = StatusCheck(Status);
                }
                else
                {
                    Console.WriteLine($"輸入的字串太少!!!!");
                }

                switch (StatusStr)
                {
                    case "+":
                        myary.Add(itemStr);
                        Console.WriteLine($"Ary add susses!:{itemStr}");
                        break;
                    case "-":
                        if (myary.Count > 0)
                        {
                            myary.Remove(itemStr);
                            Console.WriteLine($" {itemStr} : Ary del susses!");
                        }
                        break;
                    case "--":
                        myary.Clear();
                        Console.WriteLine($"Ary Clear susses!");
                        break;
                    case "show":
                        for (int i = 0; i < myary.Count; i++)
                        {
                            Console.WriteLine($"目前陣列:{myary[i]}");
                        }
                        break;
                    default:
                        Console.WriteLine($"You Input the : {Status}");
                        break;
                }


                LoopStatus = Status;
            }
        }

        public string StatusCheck(string Status)
        {
            String StatusStr = Status;

            if (Status.IndexOf("+") == 0)
            {
                StatusStr = "+";
            }

            if (Status.IndexOf("-") == 0)
            {
                StatusStr = "-";
            }

            if (Status.IndexOf("--") == 0)
            {
                StatusStr = "--";
            }

            if (string.IsNullOrEmpty(StatusStr))
            {
                StatusStr = "Error";
            }
            return StatusStr;
        }
    }
}
