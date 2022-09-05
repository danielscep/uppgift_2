using System.Data.SqlTypes;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123456789";
            string input = "29535123p48723487597645723645";
            string output = string.Empty;
            int index = 0;
            int tempIndex = 0;

            int lastIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                index = 0;
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (input[i] == numbers[k])
                    {
                        tempIndex = input.IndexOf(numbers[k], i + 1);
                        if (tempIndex == -1) break;
                        index = tempIndex;
                        //Console.WriteLine(i);
                        //Console.WriteLine(index);
                        for (int x = i; x < index; x++)
                        {
                            output += input[x];
                        }
                        lastIndex = i;
                        break;
                    }
                }
                Console.Write(input);

                Console.SetCursorPosition(lastIndex, Console.CursorTop);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(output);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                //sumString += output;
                output = "";
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