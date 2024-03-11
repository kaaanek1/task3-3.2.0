using System;

namespace task3-3
{
    class Program
    {
        static void Main()
        {
            IParent[] array = new IParent[3];
    
            Console.Write("Будешь заполнять массивы сам?(true/false)");
            bool fill = bool.Parse(Console.ReadLine());
            Console.WriteLine();
    
            Console.Write("Введите длину одномерного массива: ");
            int l1 = int.Parse(Console.ReadLine());
            OneDim arr1 = new(l1, fill);
            array[0] = arr1;
            Console.WriteLine();
    
            Console.Write("Введите a двумерного массива:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b для двумерного массива:");
            int b = int.Parse(Console.ReadLine());
            TwoDim arr2 = new(b, a, fill);
            array[1] = arr2;
            Console.WriteLine();
    
            Console.WriteLine("Введите длину ступенчатого массива:");
            int l2 = int.Parse(Console.ReadLine());
            JagDim arr3 = new(l2, fill);
            array[2] = arr3;
    
            
            for (int i = 0; i < 3; i++)
            {
                array[i].Print();
                Console.WriteLine("Среднее арифметическое:");
                array[i].Average();
            }
        }
    }
}
