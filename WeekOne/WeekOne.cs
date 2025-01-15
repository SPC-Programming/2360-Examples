namespace WeekOne;

class WeekOne
{
    static int counter = 0; //integer counter int data type
    static double doubleCounter = 0.0; //double deals with non integers

    static decimal decimalCounter = 0; //decimal datatype

    static char charCounter = 'A';//char data type

    static bool boolValue = false; //bool

    static string stringValue = "This is a string";//string

    static void Main(string[] args)
    {
        // Console.WriteLine(stringValue + " " + "This is a string literal" + 5);//a variable containing a string, a string literal, a numeric literal
        // Console.WriteLine(counter);
        // counter++;
        // //Console.WriteLine(counter + counter-- + counter);
        //Console.WriteLine(counter.ToString() + counter--.ToString() + counter.ToString());
        Console.WriteLine($"This is the value of counter {counter} value of decimal counter + 5 * 4: {decimalCounter += (decimalCounter + 5) * 4}");//string interlopation
        Console.WriteLine($"{counter} {decimalCounter}");
    }
}

