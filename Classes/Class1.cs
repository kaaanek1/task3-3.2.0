using System;

namespace task3-3
{
    sealed class OneDim: Parent, IOneDim
    {
        private int[] array;
        
        public OneDim(int l, bool fill = false)
        {
            array = new int[l];
            
            if (fill)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void Uniqal()
        {
            int[] newArray = new int[array.Length];
            int uniq = 1;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUniq = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUniq = false;
                    }
                }
                if (isUniq)
                {
                    newArray[uniq - 1] = array[i];
                    uniq++;
                }
            }
            
            Console.WriteLine(String.Join(" ", newArray));
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
            }
        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент {i}: ");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
        }

        public override void Average()
        {
            int s = 0;
            foreach (int el in array)
            {
                s += el;
            }
            Console.WriteLine(s / array.Length);
        }


        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1) { Console.WriteLine($"{array[i]}"); }
                else { Console.Write($"{array[i]} "); }
            }
        }
    }
}