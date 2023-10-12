// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.Write("Working hours = ");
Int32 w = Int32.Parse(Console.ReadLine());

Console.Write("Unit price = ");
Int32 u = Int32.Parse(Console.ReadLine());

Console.WriteLine("Your salary = " + (w*u));

Console.Write("Enter to continue: ");
Console.ReadKey();
// -----------------------------------------------
Console.Clear();

Console.Write("Amount of money = ");
Int32 Amt = Int32.Parse(Console.ReadLine());
Console.WriteLine("");

int oneDollar, twoDollars, fiveDollars, tenDollars, twentyDollars, fiftyDollars, hundredDollars;

hundredDollars = Amt / 100;
Amt = Amt - hundredDollars*100;
fiftyDollars = Amt / 50;
Amt = Amt - fiftyDollars*50;
twentyDollars = Amt / 20;
Amt = Amt - twentyDollars*20;
tenDollars = Amt / 10;
Amt = Amt - tenDollars*10;
fiveDollars = Amt / 5;
Amt = Amt - fiveDollars*5;
twoDollars = Amt / 2;
Amt = Amt - twoDollars*2;
oneDollar = Amt / 1;


Console.WriteLine("Hundred dollars = {0}\nFifty Dollars = {1}\nTwenty Dollars = {2}\nTen Dollars = {3}\nFive Dollars = {4}\nTwo Dollars = {5}\nOne Dollars = {6}", hundredDollars, fiftyDollars, twentyDollars, tenDollars, fiveDollars, twoDollars, oneDollar);