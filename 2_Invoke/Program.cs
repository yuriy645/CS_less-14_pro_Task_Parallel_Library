using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2_Invoke
{//Создайте два метода, которые будут выполняться в рамках параллельных задач. Организуйте
  //  вызов этих методов при помощи Invoke таким образом, чтобы основной поток программы
 //   (метод Main) не остановил свое выполнение.

    //Invoke- это из класса Parallel
    class Program
    {
        static void MyTask1()
        {
            Console.WriteLine("MyTask1: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("+");
            }
            Console.WriteLine("MyTask1: завершен.");
        }

        static void MyTask2()
        {
            Console.WriteLine("MyTask2: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            Console.WriteLine("MyTask2: завершен.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");
            

            // Action action = new Action(() => Parallel.Invoke(MyTask1, MyTask2));
            // Task.Factory.StartNew(action);

            Task.Factory.StartNew(() => Parallel.Invoke(MyTask1, MyTask2)); //  то же самое

            Console.WriteLine("Основной поток завершен.");

            Console.ReadKey();
        }
    }
}
