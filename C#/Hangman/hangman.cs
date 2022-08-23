// See https://aka.ms/new-console-template for more information


string f = " ____";
string e = "|";
string d = "    | ";
string c = "\n|    O";
string b = "\n|   /|\\";
string a = "\n|   / \\";
string g = "\n ______\n";
// Console.WriteLine(f);
// Console.Write(e);
// Console.Write(d);
// Console.Write(c);
// Console.Write(b);
// Console.Write(a);
// Console.Write(g);

/*
welcome screen
*/

string word;
Console.Write("Welcome to the Hangman Game. ");
System.Threading.Thread.Sleep(5000);
Console.Clear();
Console.Write("Please enter a word: ");
word = Console.ReadLine();
Console.Clear();
//cleared console
int wordLength = word.Length;
    //string lineLength = String.Concat(Enumerable.Repeat("_ ", wordLength));
string wordLower = word.ToLower();
ConsoleKeyInfo guessWord = new ConsoleKeyInfo();
int tries = 0;
int success = 0;
string[] result = new string[word.Length];
string[] alphabet = new string[word.Length+10];
Console.WriteLine(f);
Console.Write(e);
Console.Write(d);
Console.Write(c);
Console.Write(b);
Console.Write(a);
Console.Write(g+"\n\nLets guess the word!\n");
Console.WriteLine("\n\n"+lineLength+"\n\n");
Console.WriteLine("\nPlease enter a character: ");
//real game
while(true)
{
    guessWord = Console.ReadKey();
    if(success == word.Length) //if amount of success attempts matches word length, exit game
    {
        break;
    }
    else if(word.IndexOf(guessWord.KeyChar) != -1) //if the character is in the word, it gives an index not equal to -1
    {
        gameStatement;
        success++;
    }
    else //fails
    {
        gameStatement;
        tries++;

    }
    if( tries == 7)
    {
        Console.WriteLine("You have failed!\nGoodbye!");
        System.Threading.Thread.Sleep(5000);
        return 0;
    }
}
return 0;   



public string gameStatement(tries)
{
    switch(tries)
    {
    case 1:  
    return Console.WriteLine("\n"+e+d+c+b+a+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    case 2:
    return Console.WriteLine("\n"+d+c+b+a+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    case 3:
    return Console.WriteLine("\n"+c+b+a+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    case 4:
    return Console.WriteLine("\n"+b+a+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    case 5:
    return Console.WriteLine("\n"+a+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    case 6:
    return Console.WriteLine("\n"+g+"\n\n"+lineLength+"\n\n"+"Please enter a character: ");
    break;
    }
}