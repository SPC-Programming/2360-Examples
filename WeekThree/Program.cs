/*
James Vernon

COP 2360 WeekThree examples - 1
*/
namespace WeekThree;

class Program
{
    static readonly string multiLine ="""
    This is how you can declare a string on 
    mutiple lines
    
    Printing non printing chars should print \n 

    on each empty line
    """;//multi line string

    static readonly string regString = "Regular String";//regular string

    static readonly string quoteString ="""Using three double quotes you can embed " " """;//second Three Doubles

    static string uniCodeString  = "\\01C4";//defined with \UNICODE CODE

    static string verbatimString = @"Everything in between the quotes will ignore escapes \n \t etc";//uses @

    static char curChar = Char.MinValue;

    static void Main(string[] args)
    {
        int i = 0;
        foreach (char c in multiLine)
        {
            
            Console.WriteLine($"Char pos {i++} \t char:{((short)c)} \t char code:{c.ToString()} ");
        }
    }
}
