/*
James Vernon
COP 2360 WeekTwo practical example
23 Jan 2025

Collabration Statement: I got help from tutor. I asked a friend
I worked this alone

*/
using System.Diagnostics;
using System.Net;

namespace WeekTwo;

class Program
{
    //int variable
    static int varInt = 0;

    //this a double value initialized using .f
    static double varDoub = 0f;

    //holds a boolean value
    static bool varBool = false;

    static char varChar = '0';

    static string varString = "";
    static void Main(string[] args)
    {
        // Console.WriteLine($"Value of varInt is : {varInt}");
        // //increment and print varInt
        // varInt++;
        // Console.WriteLine($"Value of varInt is : {varInt}");
        // //increment inline
        // Console.WriteLine($"Inline value of ++varInt {++varInt} value of varInt++ {varInt++}");

        // Console.WriteLine($"Value of varDoub is : {varDoub}");
        // varDoub++;
        // Console.WriteLine($"Value of varDoub is : {varDoub}");
        // //increment inline
        // Console.WriteLine($"Inline value of ++varDoub {++varDoub} value of varDoub++ {varDoub++}");

        // Console.WriteLine($"Value of varChar is : {varChar}");
        // varChar++;
        // Console.WriteLine($"Value of varChar is : {varChar}");
        // //increment inline
        // Console.WriteLine($"Inline value of ++varChar {++varChar} value of varChar++ {varChar++}");
        varInt = 10;

        varDoub = 5.2;

        varChar = 'G';

        //loops

        //do-while loop it runs 1 or more times; test condition at the end of the loop
        // do
        // {
        //     Console.WriteLine($"Value of varInt {varInt--}");
        //     Console.WriteLine($"Value of varDoub {varDoub--}");
        //     Console.WriteLine($"Value of varChar {varChar--}");

        // }
        // while (varInt >= 3);

        //while loop test condition is at the begining runs 0 or more times
        // while (varInt <= 15)
        // {
        //     Console.WriteLine($"Value of varInt {++varInt}");
        //     Console.WriteLine($"Value of varDoub {++varDoub}");
        //     Console.WriteLine($"Value of varChar {++varChar}");

        // }

        string even = "", odd = "";
        //for loop 10 times
        for (int i = 0; i <= 23; i++)
        {
            Console.WriteLine($"Loop ittertation number: {i}:");
            Console.WriteLine($"Adding {varChar} to varString. \t\t Value:{varString}");
            //add operation
            varString += varChar;


            //even number
            if ((++varChar % 2) == 0)
            {
                even += varChar;
            }
            else //odd number
            {
                odd += varChar;
            }
        }
        Console.WriteLine($"VarString:\t {varString} \n Even: \t {even} \n Odd: \t{odd}");

    }
}
