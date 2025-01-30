/*
James Vernon

COP 2360 WeekThree examples - 1
*/

using System.ComponentModel;
using System.Net.NetworkInformation;

namespace WeekThree;

class Program
{
    //multi line string
    static readonly string multiLine = """
    This is how you can declare a string on 
    mutiple lines
    
    Printing non printing chars should print \n 

    on each empty line
    """;

    //regular string
    static readonly string regString = "Regular String";
    //triple quote with embded doubles
    static readonly string quoteString = """Using three double quotes you can embed double quotes: { " " } """;
    //string defined unicode char //defined with \UNICODE CODE
    static string uniCodeString = "\\01C4";
    //verbatim string @ 
    static string verbatimString = @"Everything in between the quotes will ignore escapes \n \t \\ etc";
    //char variable to hold a char set to MinValue
    static char curChar = Char.MinValue;

    static void Main(string[] args)
    {
        //scoped variable integer counter
        Console.WriteLine($"multiLine length {multiLine.Length} variable currChar");
        //counters for each loop
        int aCount =0, eCount=0, iCount=0, oCount=0, uCount =0;
        foreach (char c in multiLine)
        {   
            switch(c.ToString().ToLower())
            {
                case  "a":
                    aCount++;
                    continue;
                case "e":
                    eCount++;
                    continue;
                case "i":
                    iCount++;
                    continue;
                case "o":
                    oCount++;
                    continue;
                case "u":
                    uCount++;
                    continue;
                default:
                    break;

            }
            Console.WriteLine($"A-{aCount}, E-{eCount}, I-{iCount}, O-{oCount}, U-{uCount}");
            // //top level loop
            // cCount++;    
            // foreach (char c1 in regString)
            // {
            //     //first nested for loop
            //     c1Count++;
            // }
            // Console.WriteLine($"R: cCount: {cCount}\t regString length {regString.Length} \tc1Count: {c1Count} ");  

            // foreach (char c2 in quoteString)
            // {
            //     c2Count++;
            // }
            // Console.WriteLine($"Q: cCount: {cCount}\t quoteString length {quoteString.Length} \tc2Count: {c2Count} ");  

            // foreach (char c3 in uniCodeString)
            // {
            //     c3Count++;

            // }
            // Console.WriteLine($"U: cCount: {cCount}\t UnicodeString length {uniCodeString.Length} \tc3Count: {c3Count} "); 
           
            //string interlopation start your sting with a $
            // Console.Write($"value of i:{i++}\t multiLine.Index:{multiLine.IndexOf(c)}\t Unicode Value:U\\{(int)c:X4}\t char to int cast:{(int)c}");
            // if (char.IsControl(c))
            //     Console.Write(" \t--non printing char detected--\n");
            // else
            //     Console.WriteLine();
        }


    }

}
