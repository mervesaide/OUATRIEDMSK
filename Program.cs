using System;
using System.Threading;

class Tetris
{
    static int width = 10;
    static int height = 20;
    static int score = 0;
    static int[,] field = new int[width, height];

    static ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen,
                                        ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow };

    static void Main(string[] args)
    {
        Console.Title = "Tetris";
        Console.CursorVisible = false;
        Console.SetWindowSize(width * 2, height + 2);

        while (true)
        {
            ResetField();
            DrawField();
            Console.SetCursorPosition(0, height);
            Console.WriteLine($"Score: {score}");

            Thread.Sleep(1000);
        }
    }

    static void ResetField()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                field[x, y] = 0;
            }
        }
    }

    static void DrawField()
    {
        Random random = new Random();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.SetCursorPosition(x * 2, y);

                if (field[x, y] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = colors[random.Next(colors.Length)];
                }

                Console.Write("  ");
            }
        }

        Console.BackgroundColor = ConsoleColor.Black;
    }
    (git config --global user.name "mervesaide"
git config --global user.email "saidemervekaplan@gmail.com"
)
}
