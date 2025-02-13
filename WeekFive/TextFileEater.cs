

namespace WeekFive;
/**

James Vernon

Objects, Lists, Arrays, Text Proccessing, and Looping demo

TextFileEater Program
    <summary>
        1. Program loop should accept a text file as an argument
        2. Program should create an object which can then be handled in the loop to
            a. Print entire contents
            b. Count Lines -> store as int
            c. Count words -> store in dict<string, int> (word, count of word)
            d. Count upper letters -> store in array 
            e. Count lower letters -> store in List
            f. Count puncations -> store in array or list
            g. Count white space (tabs, spaces, newlines, or non printing char) -> store in array or list
        3. User enters stop to stop the program
    </summary>
    */
class TextFileEater
{

    static void Main(string[] args)
    {
        /// Main shoud check that args[0]  is a text file and not empty
        /// Then create a TextFileInfo object
        /// Loop through the commands that are available
        /// Quit when user tells us too
        Console.WriteLine("Hello, World!");
    }

}

enum CharType
{
    /// <summary>
    /// (int) CharType.UPPER == 0
    /// </summary>
    UPPER, //0
    LOWER,//1
    PUNCTATION,//2
    WHITE_SPACE//3
}
class CharCount
{
    private char _theChar;
    private int count = 0;
    public CharCount(char theChar)
    {
        count++;
    }
    public char GetChar { get { return _theChar; } }
    public int Count { get { return count; } }

    public void addOne()
    {
        count++;
    }

}

class TextEaterInfo
{

    private char _currByte;
    private CharType _currByteType;

    private CharCount[] _upperLetters;
    private CharCount[] _lowerLetters;

    private List<char> _puncations;

    private List<char> _whiteSpaces;

    public TextEaterInfo(FileStream openFile)
    {
        ///when the file stream is open
        ///the file should be read byte by byte
        ///test each byte and determine its type

        do
        {
            _currByte = (char)openFile.ReadByte();

            if (Char.IsUpper(_currByte))
            {
                _currByteType = CharType.UPPER;
                addToArray(_currByte);
            }
            else if (Char.IsLower(_currByte))
            {
                _currByteType = CharType.LOWER;
            }
            else if (Char.IsPunctuation(_currByte))
            {
                _currByteType = CharType.PUNCTATION;
            }
            else if (Char.IsWhiteSpace(_currByte))
            {
                _currByteType = CharType.WHITE_SPACE;
            }


        } while (openFile.CanRead);

    }
    private void addToArray(CharCount c)
    {
        if (_currByteType == CharType.UPPER)
        {
            if (_upperLetters != null)
            {
                _upperLetters = new char[25];
            }

        }

    }
}

