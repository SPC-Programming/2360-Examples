
using System.Collections;
using System.ComponentModel.DataAnnotations;


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
        string path = @"J:\2360-code-examples\645\WeekFive\raven.txt";
        if (File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            TextEaterInfo te = new TextEaterInfo(fs);
            fs.Close();
            te.PrintContents();
        }
    }

}

enum CharType
{
    /// <summary>
    /// (int) CharType.UPPER == 0
    /// </summary>
    UPPER, //0
    LOWER,//1
    PUNCTUATION,//2
    WHITE_SPACE,//3

    UNKNOWN

}
class CharCount
{
    private readonly char _charInstance;
    private int _charCount;

    private CharType _charType;

    public CharCount(char c)
    {

        _charInstance = c;
        _charCount = 1;

        if (char.IsUpper(_charInstance))
        {
            _charType = CharType.UPPER;
        }
        else if (char.IsLower(_charInstance))
        {
            _charType = CharType.LOWER;
        }
        else if (char.IsPunctuation(_charInstance))
        {
            _charType = CharType.PUNCTUATION;
        }
        else if (char.IsWhiteSpace(_charInstance))
        {
            _charType = CharType.WHITE_SPACE;
        }
        else
        {
            _charType = CharType.UNKNOWN;
        }
    }

    public CharType GetCharType { get { return _charType; } }

    public char GetChar { get { return _charInstance; } }

    public int GetCount { get { return _charCount; } }

    public void AddCount()
    {
        ++_charCount;
    }


}



class TextEaterInfo
{
    private int _lineNumber = 0;
    private int _colPos = 0;
    private CharCount _currentChar;
    private List<CharCount> _allText = new List<CharCount>();
    private List<CharCount> _lowers = new List<CharCount>();
    private List<CharCount> _highers = new List<CharCount>();
    private Dictionary<char, int> _punctuations = new Dictionary<char, int>();

    private CharCount[]? _whiteSpaces;
    private char[][]? docMap;

    public TextEaterInfo(FileStream openFile)
    {
        ///when the file stream is open
        ///the file should be read byte by byte
        ///test each byte and determine its type

        do
        {
            _currentChar = new((char)openFile.ReadByte());
            CharCount inList = _allText.Find(c => c.GetChar.Equals(_currentChar.GetChar));
            if (inList == null)
            {
                _allText.Add(_currentChar);
            }
            else
            {
                inList.AddCount();
            }

        } while (openFile.Length != openFile.Position);
      

    }
    public void PrintContents()
    {
        foreach (CharCount c in _allText)
        {
            Console.WriteLine($"Char: {c.GetChar}, Type: {c.GetCharType}, count: {c.GetCount}");
        }
    }

}


