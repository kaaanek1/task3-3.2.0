using System;

namespace task3-3
{
    sealed class TwoDim: Parent, ITwoDim
    {
        private int[,] array;
        public TwoDim(int a, int b, bool fill = false)
        {
            array = new int[a, b];

            if(fill)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void Snake()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
            }
        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Элемент ({i},{j}): ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-1000, 1000);
                }
            }
        }

        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public override void Average()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine($"Среднее арифметическое: {sum / (array.GetLength(0) * array.GetLength(1))}");
        }
    }
}