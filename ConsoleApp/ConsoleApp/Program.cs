using System.Text.RegularExpressions;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "29535123p48723487597645723645";
            string input = args[0];
            string inputSub = input;
            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                Regex rx = new Regex($@"^{inputSub[0]}\d+?{inputSub[0]}");
                string match = rx.Match(inputSub).Value;
                inputSub = inputSub.Substring(1, inputSub.Length - 1);

                if (match == "")
                {
                    continue;
                }
                else
                {
                    Console.Write(input);
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(match);
                    Console.ForegroundColor = ConsoleColor.White;

                    sum += Convert.ToInt64(match);
                }
            }
            Console.WriteLine($"sum of all matches: {sum.ToString()}");
        }
    }
}