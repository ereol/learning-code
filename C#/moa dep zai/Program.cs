// // See https://aka.ms/new-console-template for more information
// using System.Collections;

// Console.Write("Working hours = ");
// Int32 w = Int32.Parse(Console.ReadLine());

// Console.Write("Unit price = ");
// Int32 u = Int32.Parse(Console.ReadLine());

// Console.WriteLine("Your salary = " + (w*u));

// Console.Write("Enter to continue: ");
// Console.ReadKey();
// // -----------------------------------------------
// Console.Clear();

// Console.Write("Amount of money = ");
// Int32 Amt = Int32.Parse(Console.ReadLine());
// Console.WriteLine("");

// int oneDollar, twoDollars, fiveDollars, tenDollars, twentyDollars, fiftyDollars, hundredDollars;

// hundredDollars = Amt / 100;
// Amt = Amt - hundredDollars*100;
// fiftyDollars = Amt / 50;
// Amt = Amt - fiftyDollars*50;
// twentyDollars = Amt / 20;
// Amt = Amt - twentyDollars*20;
// tenDollars = Amt / 10;
// Amt = Amt - tenDollars*10;
// fiveDollars = Amt / 5;
// Amt = Amt - fiveDollars*5;
// twoDollars = Amt / 2;
// Amt = Amt - twoDollars*2;
// oneDollar = Amt / 1;


// Console.WriteLine("Hundred dollars = {0}\nFifty Dollars = {1}\nTwenty Dollars = {2}\nTen Dollars = {3}\nFive Dollars = {4}\nTwo Dollars = {5}\nOne Dollars = {6}", hundredDollars, fiftyDollars, twentyDollars, tenDollars, fiveDollars, twoDollars, oneDollar);



using System.Security.Cryptography.X509Certificates;

namespace cong_2_ma_tran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int[,] b;
            Console.WriteLine("nhap m = ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            a = new int[m, n];
            Input(a);
            Output(a);            
            Console.WriteLine("nhap x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap y = ");
            int y = int.Parse(Console.ReadLine());
            b = new int[x,y];
            Input(b);
            Output(b);

            Console.WriteLine("tong 2 ma tran  = ");
            TinhTong2MaTran(a, b);
        }
        static void Input(int[,]x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write($"nhap so [{i},{j}]: ");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Output(int[,]x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void TinhTong2MaTran(int[,]a, int[,]b)
        {
        
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            {
                Environment.Exit(0);
            }


            int[,]c = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1);j++)
                {
                    c[i,j] = a[i,j] + b[i,j];                         
                }
            }
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1);j++)
                {
                    Console.Write(c[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}

