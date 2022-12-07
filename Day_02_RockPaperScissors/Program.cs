using System.Diagnostics;

namespace Day_02_RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerA = 0, playerB = 0;
            int scorePlayerA = 0, scorePlayerB = 0;

            var input = GetEntry();
            var inputArray = input
                .Select(p => p.ToArray())
                .ToArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < input.Length; i++)
            {
                playerA = GetSelectedScore(input[i][0]);
                playerB = GetSelectedScore(input[i][2]);

                scorePlayerA += playerA;
                scorePlayerB += playerB;

                if (playerA == playerB)
                {
                    scorePlayerA += 3;
                    scorePlayerB += 3;
                }
                else
                {
                    if (WinPlayerA(playerA, playerB))
                    {
                        scorePlayerA += 6;
                    }
                    else
                    {
                        scorePlayerB += 6;
                    }
                }                
            }
            
            int winner = scorePlayerA > scorePlayerB ? 1 : 2;

            Console.WriteLine($"Mi puntuacion es: {scorePlayerB} puntos.");
            stopwatch.Stop();

            Console.WriteLine($"ElapsedMilliseconds: {stopwatch.ElapsedMilliseconds}");

            Console.ReadKey();
        }

        static bool WinPlayerA(int a, int b)
        {
            //1 = Piedra, 2 = Papel, 3 = Tijeras

            if (a == 1 && b == 2) { return false; }
            if (a == 1 && b == 3) { return true; }


            if (a == 2 && b == 1) { return true; }
            if (a == 2 && b == 3) { return false; }


            if (a == 3 && b == 1) { return false; }
            if (a == 3 && b == 2) { return true; }
            
            return false;
        }

        static int GetSelectedScore(char p) => p switch
        {
            'A' => 1,
            'B' => 2,
            'C' => 3,
            'X' => 1,
            'Y' => 2,
            'Z' => 3,
        };

        static string[] GetEntry() => File.ReadAllLines("Input\\input_day_2.txt");
    }
}