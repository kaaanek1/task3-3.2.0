using System;

namespace task3-3
{
    sealed class JagDim: Parent, IJagDim
    {
        private int[][] array;

        public JagDim(int l, bool fill = false)
        {
            array = new int[l][];
            
            if(fill)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void SwapOnInd()
        {
            int[][] arr = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = array[i][j];
                    if (x % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }

                    else
                    {
                        arr[i][j] = x;
                    }
                }
            }
            PrintIn(arr);
        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Длина {i} массива: ");
                int l = int.Parse(Console.ReadLine());
                array[i] = new int[l];
                for (int j = 0; j < l; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    int x = int.Parse(Console.ReadLine());
                    array[i][j] = x;
                }
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Длина {i} массива: ");
                int l = int.Parse(Console.ReadLine());
                array[i] = new int[l];
                for (int j = 0; j < l; j++)
                {
                    int x = rnd.Next(-1000, 1000);
                    array[i][j] = x;
                }
            }
        }

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j == array[i].Length - 1)
                    {
                        Console.WriteLine(array[i][j]);
                    }
                    else
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                }
            }
        }

        private void PrintIn(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (j == arr[i].Length - 1)
                    {
                        Console.WriteLine(arr[i][j]);
                    }
                    else
                    {
                        Console.Write($"{arr[i][j]} ");
                    }
                }
            }
        }

        public override void Average()
        {
            int sum = 0;
            int el = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = array[i][j];
                    sum += x;
                    el++;
                }
            }
            Console.WriteLine($"Среднее арифметическое целого массива: {sum / el}");
        }
    }
}