using System;
using System.Linq;
using System.Threading.Tasks;

namespace _1_add
{
    class Program
    {//Создайте массив чисел размерностью в 1 000 000 или более. Используя генератор случайных
     //  чисел, проинициализируйте этот массив значениями.Создайте PLINQ запрос, который
     //   позволит получить все нечетные числа из исходного массива.
        static void Main()
        {
            int[] array = new int[10000000];

            Random random = new Random(); 

            Parallel.For( 0, 10000000, (i) => array[i] = random.Next(-99, +99) );


            //ParallelQuery<int> negatives = from element in array.AsParallel()
            //                               where element < 0
            //                               select element;

            //PLINQ запрос, который
     //     позволит получить все нечетные числа из исходного массива

            ParallelQuery<int> negatives = from element in array.AsParallel()
                                           where element % 2 != 0
                                           select element;

            foreach (int element in negatives)
                Console.Write(element + "   ");

         
            Console.ReadKey();
        }
    }
}
