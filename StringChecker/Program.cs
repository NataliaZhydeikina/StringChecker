using System;

namespace StringChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteResult(CheckString(ReadString()));
        }

        static string ReadString()
        {
            Console.WriteLine("Please enter string:");
            return Console.ReadLine();
        }

        static string CheckString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ' &&
                    (i + 1 < charArray.Length && charArray[i + 1] != ' ') &&
                    (i > 0 && charArray[i - 1] != ' '))
                {
                    charArray[i] = '%';
                }
            }
            str = new string(charArray);

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ' && i+1 < str.Length && str[i + 1] == ' ')
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }

        static void WriteResult(string str)
        {
            Console.WriteLine("String:");
            Console.WriteLine(str);
        }
    }
}
