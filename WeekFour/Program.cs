using System.Runtime.InteropServices;

namespace WeekFour
{
    class Program
    {
        //appliaction entry point
        static void Main(string[] args)
        {
            MethodDemo md = new("Week Four");
            Console.WriteLine($"currstring {md.CurrString}");
            md.printCurrentString();
            Console.WriteLine(md.SecondString + "\t" + md.SecondStringLength);
            md.SecondString = $"new string called from Program.cs";
            Console.WriteLine(md.SecondString + "\t" + md.SecondStringLength);
        }
    }

    public class MethodDemo
    {
        //backing field
        private string _currentString = string.Empty;


        public MethodDemo()
        {
            _currentString = "Default Contstructor used";
            SecondString = "Second Default String";
        }

        public MethodDemo(string i)
        {
            _currentString = i;
            SecondString = "Second parameter String";
            
        }
        //property
        public int CurrentStringCount
        {
            get
            {
                if (_currentString.Length > 0)
                {
                    return _currentString.Length;
                }
                else
                {
                    return -1;
                }
            }
        }

        public int SecondStringLength { get { return SecondString.Length; } }

        public string SecondString { get; set; }
        
        public string CurrString { get { return _currentString;}}
        //method
        public int getCurrentCount()
        {
            return _currentString.Length;
        }
        public void printCurrentString()
        {
            if (_currentString == string.Empty)
            {
                Console.WriteLine("ERROR EMPTY STRING");
            }
            else
            {
                Console.WriteLine($"_currentString Value {_currentString}");
            }

        }

    }
}