namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputChars = "29535123p48723487597645723645";
            string validChars = "123456789";

            for (int i = 0; i < InputChars.Length; i++) //InputChars loop
            {
                for (int k = 0; k < validChars.Length; k++) // validChars loop
                {
                    if (InputChars[i] == validChars[k]) 
                    {
                        int index = InputChars.IndexOf(validChars[k], i + 1);
                        if (index == -1) continue;
                        string match = InputChars.Substring(i, index - i + 1);

                        foreach (char c in match)
                        {
                            if (!Char.IsDigit(c))
                            {
                                bool nonDigit = true;
                            }
                        }

                        /*
                        foreach (char c in match)
                        {
                            if (!Char.IsDigit(c))
                            {
                                goto LoopEnd;
                            }
                        }
                        */
                        Console.Write(InputChars);
                        Console.SetCursorPosition(i, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(match);
                        Console.ForegroundColor = ConsoleColor.White;
                        LoopEnd:;
                    }
                }
            }
        }
    }
}

/*
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "0123456789";
            string input = "29535123p48723487597645723645";
            string output = string.Empty;
            int firstIndex = 0;
            int lastIndex = -1;
            int sum = 0;
            string sumString = string.Empty;

            for(int i = 0; i < numbers.Length; i++)
            {
                firstIndex = 0;
                lastIndex = -1;
                while (true)
                {
                    firstIndex = input.IndexOf(numbers[i], lastIndex + 1);
                    if (firstIndex == -1) break;

                    lastIndex = input.IndexOf(numbers[i], firstIndex + 1);
                    if (lastIndex == -1) break;

                    for (int j = firstIndex; j <= lastIndex; j++)
                    {
                        output += Convert.ToString(input[j]);
                        if (numbers.IndexOf(input[j]) == -1)
                        {
                            break;
                        }
                    }

                    Console.Write(input);

                    Console.SetCursorPosition(firstIndex, Console.CursorTop);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(output);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("");
                    sumString += output;
                    output = "";
                }
            }
            for(int i = 0; i < sumString.Length; i++)
            {
                sum += Convert.ToInt32(sumString[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
*/