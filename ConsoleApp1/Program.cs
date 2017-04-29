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
            var NowClass = new Lesson12of20Sub();
            NowClass.Show();
        }

    }


    public class Lesson12of20Sub
    {

        public Lesson12of20Sub()
        {
            StreetAddress = "123 Main Street ";
            City = "Sometown";
            Country = "OH";
            PostalCode = "12345";
            State = "United States";

        }
        public void Show()
        {
            var PersonClass = new Person();
            PersonClass.FirstName = "John";
            PersonClass.LastName = "Doe";
            PersonClass.ShippingAddress();

            PersonClass.FirstName = "Ruby";
            PersonClass.LastName = "meol";
            PersonClass.ShippingAddress();

            var CompanyClass = new Company();
            CompanyClass.Name = "Acme, Inc.";
            CompanyClass.ShippingAddress();
        }

        public class Person : Lesson12of20Sub
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override void ShippingAddress()
            {
                Console.WriteLine($"{FirstName} {LastName}");
                Console.WriteLine($"{StreetAddress}");
                Console.WriteLine($"{City} , {Country} , {PostalCode}");
                Console.WriteLine($"{State}");
                Console.WriteLine("--------------------------------------");
            }
        }
        public class Company : Lesson12of20Sub
        {
            public string Name { get; set; }
            public override void ShippingAddress()
            {
                Console.WriteLine($"{Name} ");
                Console.WriteLine($"{StreetAddress}");
                Console.WriteLine($"{City} , {Country} , {PostalCode}");
                Console.WriteLine($"{State}");
            }
        }
        static string StreetAddress { get; set; }
        static string City { get; set; }
        static string State { get; set; }
        static string PostalCode { get; set; }
        static string Country { get; set; }
        public virtual void ShippingAddress() { }
    }






    public abstract class ShapeAbstract
    {
        public abstract String Perimeter();
    }
    public class ShapeAbstractSub : ShapeAbstract
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override String Perimeter()
        {
            return $"Height:{Height}  , Width:{Width}";
        }
    }
    public class Shape
    {
        int versionNumber = 123;
        public virtual int Perimeter()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"MyProgramName - Version {versionNumber}";
        }


    }
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Perimeter()
        {
            return (Height + Width) * 2;
        }
    }
    public class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public override int Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
    public class Speedometer
    {
        private int _currentSpeed;

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                if (value < 0) return;
                if (value > 120) return;

                // value is a keyword used in setters representing the new value
                _currentSpeed = value;
            }
        }

        public int GetCurrentSpeed()
        {
            return _currentSpeed;
        }
        public void SetCurrentSpeed(int newSpeed)
        {
            if (newSpeed < 0) return;
            if (newSpeed > 120) return;

            _currentSpeed = newSpeed;
        }

    }
    class OtherFun
    {

        public void TheWhileHomeWork()
        {
            for (int Si = 1; Si <= 4; Si++)
            {
                int Fi = Si;
                for (int i = 0; i <= 24; i = i + Fi)
                {
                    Console.Write($"{i},");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void LambdaFun2()
        {

            const int four = 4;
            Func<int, int> addOne = x => x + 1;
            Func<int, int, int> calcArea = (x, y) => x * y; // two parameters
            Func<int> twentyFive = () => calcArea(addOne(four), addOne(four)); // no parameters
            Console.WriteLine(twentyFive().PlusFive());

        }
        public void LambdaFun()
        {
            Func<int, int> addOne = x => x + 1; // this is the lambda expression
            Console.WriteLine(addOne(4));
        }
        public void Looping_collections()
        {
            var myary = new List<int>() { 2, 4, 6 };
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
            DisplayHeader();

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
                        AddFun(myary, itemStr);
                        break;
                    case "-":
                        DelFun(myary, itemStr);
                        break;
                    case "--":
                        ClrFun(myary);
                        break;
                    case "show":
                        ShowFun(myary);
                        break;
                    default:
                        Console.WriteLine($"You Input the : {Status}");
                        break;
                }


                LoopStatus = Status;
            }
        }

        static string StatusCheck(string Status)
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

        static void DisplayHeader()
        {
            Console.WriteLine("You can input + item , add Ary ");
            Console.WriteLine("You can input - item , del Ary ");
            Console.WriteLine("You can input -- , Clear Ary ");
            Console.WriteLine("You can input break , exit Loop ");
        }

        static void AddFun(List<string> myary, string itemStr)
        {
            myary.Add(itemStr);
            Console.WriteLine($"Ary add susses!:{itemStr}");
        }

        static void DelFun(List<string> myary, string itemStr)
        {
            if (myary.Count > 0)
            {
                myary.Remove(itemStr);
                Console.WriteLine($" {itemStr} : Ary del susses!");
            }
        }
        static void ClrFun(List<string> myary)
        {
            myary.Clear();
            Console.WriteLine($"Ary Clear susses!");
        }
        static void ShowFun(List<string> myary)
        {
            for (int i = 0; i < myary.Count; i++)
            {
                Console.WriteLine($"目前陣列:{myary[i]}");
            }
        }
    }

    public static class ExtensionMethods
    {
        public static int PlusFive(this int input)
        {
            return input + 5;
        }
    }
}


