using System;

namespace Encryption
{
    public class Class1
    {
        public static string GetEncryption(string input)
        {
            Array inputstrings = input.Split(" ");

            string solution = "";

            foreach (string strings in inputstrings)
            {
                
                if (strings.Length == 1)
                {

                    int ASCIIesc = (int)strings[0];

                    solution += $"{ASCIIesc}" + " ";
                    // do the above if string is only one char long.
                }
                else if (strings.Length == 2)
                {
                    string copy = (string)strings.Clone();

                    int ASCIIval = (int)strings[0];

                    solution += $"{ASCIIval}" + $"{strings[1]}" + " ";
                }
                else if(strings.Length > 2)
                {
                    string copy = (string)strings.Clone();

                    int ASCIIval = (int)strings[0];

                    string removeLastString = copy.Substring(2);

                    string nonFirstChar = removeLastString.Remove(removeLastString.Length - 1);

                    solution += $"{ASCIIval}" + $"{strings[^1]}" + nonFirstChar + $"{strings[1]}" + " ";
                }
            }

            return solution.Trim();
        }
    }
}
