using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_3
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
            IOneDim arr1 = new OneDim(l1, fill);
            array[0] = arr1;
            Console.WriteLine();
    
            Console.Write("Введите a двумерного массива:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b для двумерного массива:");
            int b = int.Parse(Console.ReadLine());
            ITwoDim arr2 = new TwoDim(b, a, fill);
            array[1] = arr2;
            Console.WriteLine();
    
            Console.WriteLine("Введите длину ступенчатого массива:");
            int l2 = int.Parse(Console.ReadLine());
            IJagDim arr3 = new JagDim(l2, fill);
            array[2] = arr3;
            Console.WriteLine();
    
            
            for (int i = 0; i < 3; i++)
            {
                array[i].Print();
                Console.WriteLine($"Среднее арифметическое: {array[i].Average()}");
                if (array[i] is IOneDim oneDim)
                {
                    Console.WriteLine("Массив без дубликатов:");
                    oneDim.Uniqal();
                }
                else if (array[i] is ITwoDim twoDim)
                {
                    Console.WriteLine("Массив змейкой:");
                    twoDim.Snake();
                }
                else if (array[i] is IJagDim jagDim)
                {
                    Console.WriteLine("Массив с заменой четных значений:");
                    jagDim.SwapOnInd();
                }

                Console.WriteLine();
            }

            IPrinter days = new Week();
            Console.WriteLine("Дни недели");
            days.Print();
        }
    }
}
