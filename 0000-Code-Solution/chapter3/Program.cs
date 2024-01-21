using System;

namespace Sample003
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=5; i++){
                Console.WriteLine(i);
            }

            for(int j=1; j<=2; j++){
                for(int k=1; k<=3; k++){
                    int l = j + k;
                    Console.WriteLine(j + "+" + k + "=" + l + " ");
                }
                Console.WriteLine();
            }

            int num1 = 0;
            while(num1 <= 500){
                Console.WriteLine(num1);
                num1++;
            }

            Random rnd = new Random();
            Console.WriteLine("100が出たら終了");
            while(true){
                int dice = rnd.Next(1, 999);
                Console.WriteLine(dice);
                if(dice == 100){
                    break;
                }
            }
            Console.WriteLine("終了");
            Console.Write("★の数 > ");
            int stars = int.Parse(Console.ReadLine());
            for(int n=0; n<stars; n++){
                Console.WriteLine("★");
            }
            int n = 0;
            while(n<stars){
                Console.WriteLine("★");
                n++;
            }
            
            Console.Write("正の整数 > ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++){
                if(n % i == 0){
                    Console.WriteLine(i);
                }
                else if (n==0){
                    //none
                }
            }
            
            Random rnd = new Random();
            int Result = rnd.Next(1, 10);
            //Count
            int n = 1;
            while(n<=3){
                Console.WriteLine($"{n}回目です。");
                int ans = int.Parse(Console.ReadLine());
                if(ans < Result){
                    Console.WriteLine("小さいです。");
                }
                else if (ans > Result){
                    Console.WriteLine("大きいです。");
                }
                else{
                    Console.WriteLine("正解です！");
                    break;
                }
                n++;
                
                if(n == 4){
                    Console.WriteLine($"正解は {Result} でした。");
                    break
                }
            }
            
            int max = 0;
            int min = 101;
            Random rnd = new Random();
            for(int i = 0; i<=10; i++){
                int n = rnd.Next(1,101);
                Console.WriteLine(n);
                if(n > max){
                    max = n;
                }
                else if(n < min){
                    min = n;
                }
            }
            Console.WriteLine($"最大値 : {max}");
            Console.WriteLine($"最小値 : {min}");
            
            double[] d = new double[3];
            d[0] = 1.2;
            d[1] = 3.7;
            d[2] = 4.1;

            double sum, avg;
            sum = 0.0;

            for(int i=0; i<d.Length; i++){
                Console.WriteLine(d[i]);
                sum += d[i];
            }
            avg = sum / d.Length;
            Console.WriteLine($"合計 : {sum}");
            Console.WriteLine($"平均 : {avg}");
            
            int[] n = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
            
            int[,] a = new int[3, 4];
            int m, n;

            for(m=0; m<3; m++){
                for(n=0; n<4; n++){
                    a[m,n] = m+n;
                }
            }
            for(m=0; m<3; m++){
                for(n=0; n<4; n++){
                    Console.WriteLine($"a[{m},{n}]={a[m,n]}");
                }
            }            
        }
    }
}