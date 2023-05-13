using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_7_Interface.Program;

namespace Homework_7_Interface
{
    internal class Program
    { 
        public class Array : ICalc, IOutput2, ICalc2
        {
            private int[] arr;
            public Array(int[] arr)
            {
                this.arr = arr;
            }
            
            public int Less(int valueToCompare) // возвращает количество значений меньших, чем valueToCompare
            {
                int count = 0;
                foreach (int num in arr)
                {
                    if (num < valueToCompare) 
                        count++;
                }
                return count;
            }
            public int Greater(int valueToCompare) // возвращает количество значений больших, чем valueToCompare.
            {
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > valueToCompare) count++;
                }
                return count;
            }
            public void ShowEven() // отображает четные значения из массива
            {
                foreach (int val in arr)
                {
                    if (val % 2 == 0)
                    {
                        Console.Write(val + " ");
                    }
                }
                Console.WriteLine();
            }
            public void ShowOdd() // отображает нечетные значения из массива.
            {
                foreach (int val in arr)
                {
                    if (val % 2 != 0)
                    {
                        Console.Write(val + " ");
                    }
                }
                Console.WriteLine();
            }
            public int CountDistinct() //  возвращает количество уникальных значений в массиве.
            {
                return arr.Distinct().Count();
            }
            public int EqualToValue(int valueToCompare) // возвращает количество элементов массива равных valueToCompare
            {
                //return arr.Count(val => val == valueToCompare);
                int count = 0;
                foreach (int num in arr)
                {
                    if (num == valueToCompare) 
                        count++;
                }
                return count;
            }
        } 
        static void Main(string[] args)
        {

            int[] nums = { 2, 1, 4, 3, 2, 5, 4, 3, 2 };
            Array arr = new Array(nums);

            Console.WriteLine("Mассив: " + string.Join(" ", nums) + "\n");
            Console.WriteLine("Значение менее 3: " + arr.Less(3));
            Console.WriteLine("Значение больше 3: " + arr.Greater(3));
            Console.Write("Четные числа: "); arr.ShowEven();
            Console.Write("Нечетные числа: "); arr.ShowOdd();
            Console.WriteLine("количество уникальных значений: " + arr.CountDistinct());
            Console.WriteLine("Количество значений, равных 2: " + arr.EqualToValue(2));
        }
    }
}
