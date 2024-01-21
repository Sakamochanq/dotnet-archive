using System;

namespace Sample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var Add = 10+10;
            Console.WriteLine($"{10} + {10} = {Add}");

            var Sub = 10-10;
            Console.WriteLine($"{10} - {10} = {Sub}");    

            var Mul = 10*10;
            Console.WriteLine($"{10} * {10} = {Mul}");

            var Div = 10/10;
            Console.WriteLine($"{10} / {10} = {Div}");

            string str1, str2;
            Console.Write("> ");
            str1 = Console.ReadLine();
            Console.Write("> ");
            str2 = Console.ReadLine();
            Console.WriteLine($"{str1} + {str2} = {str1+str2}");

            //Calc
            int num1, num2;
            Console.Write("num1 > ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 > ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1+num2}");

            string name = "Dorores";
            Console.WriteLine($"Hello {name}");

            double num3, num4;
            Console.Write("num3 > ");
            num3 = double.Parse(Console.ReadLine());
            Console.Write("num4 > ");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num3} % {num4} = {num3%num4}");

            int num5;
            Console.Write("> ");
            num5 = int.Parse(Console.ReadLine());
            if(num5 > 0){
                Console.WriteLine($"{num5} は、正の数です。");
            }
            else{
                Console.WriteLine($"{num5} は、負の数です");
            }

            Console.Write("1～3 の数字を入力してください。> ");
            int num6 = int.Parse(Console.ReadLine());
            if(num6 == 1){
                Console.WriteLine("one");
            }
            else if(num6 == 2){
                Console.WriteLine("two");
            }
            else if(num6 == 3){
                Console.WriteLine("three");
            }
            else{
                Console.WriteLine("No");
            }
            
            Console.Write("1～3の数字を入力してください。> ");
            int num7 = int.Parse(Console.ReadLine());
            switch(num7){
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
            
            Console.Write("文字列を入力してください。> ");
            string s = Console.ReadLine();
            if(s.Equals("Hello", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Helloです。");
            }
            else{
                Console.WriteLine("Helloではありません。");
            }

            Console.Write("H20の温度 > ");
            double temperature = double.Parse(Console.ReadLine());
            if(temperature >= 100){
                Console.WriteLine("気体");
            }
            else if(temperature > 0.0){
                Console.WriteLine("液体");
            }
            else{
                Console.WriteLine("個体");
            }
        }
    }
}