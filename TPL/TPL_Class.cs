using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    public static class TPL
    {
        public static void ParallelVectorByNumber()
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rnd = new Random();
            int SomeNumber = rnd.Next(20, 200);
            List<Task> Tasks = new List<Task>();
            BlockingCollection<int> Vector = new BlockingCollection<int>();
            for (int i = 0; i < 10; i++)
            {
                Tasks.Add(new Task(() =>
                {
                    for (int i = 0; i < 100000; i++)
                        Vector.Add(rnd.Next(1, 10000) * SomeNumber);
                }));
            }
            Console.WriteLine(Tasks[0].Status);
            stopwatch.Start();
            foreach (var task in Tasks)
                task.Start();
            Task.WaitAll(Tasks.ToArray());
            stopwatch.Stop();
            Console.WriteLine(Tasks[0].Status);

            Console.WriteLine("Количество тактов при использовании Task: " + stopwatch.ElapsedTicks);
        }

        public static void ParallelVectorByNumberWithTocken()
        {
            Random rnd = new Random();
            int SomeNumber = rnd.Next(20, 200);
            List<Task> Tasks = new List<Task>();
            List<int> Vector = new List<int>();
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            for (int i = 0; i < 10; i++)
            {
                Tasks.Add(new Task(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {

                    }
                }, tokenSource.Token));

            }
            foreach (var task in Tasks)
            task.Start();
            tokenSource.Cancel();
            Console.WriteLine("Status: " + Tasks[5].Status);
        }

        public static void Continuation()
        {
            Task<double> task1 = Task.Run(() => { return Math.Pow(2, 16); });
            Task<double> task2 = task1.ContinueWith(x => { return Math.Pow(264, 5) * x.Result; });
            Task task3 = task2.ContinueWith(x => { Console.WriteLine("Ответ: " + x.Result * 12); });
            task3.GetAwaiter().GetResult();

        }
        public static void ParallelFor()
        {
            BlockingCollection<int> Arr = new BlockingCollection<int>();
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Parallel.For(0, 1000000, i => { Arr.Add(rnd.Next(1, 1000)); });
            stopwatch.Stop();

            Console.WriteLine("Parallel.For: \t" + stopwatch.ElapsedTicks + " тактов");

            stopwatch.Reset();
            stopwatch.Start();
            List<int> Array = new List<int>();
            for (int i = 0; i < 1000000; i++)
                Array.Add(rnd.Next(1, 1000));
            stopwatch.Stop();

            Console.WriteLine("For:\t\t" + stopwatch.ElapsedTicks + " тактов");
        }
        public static void ParallelInvoke()
        {
            Parallel.Invoke(() => { Console.WriteLine("First function"); }, () => { Console.WriteLine("Second function"); }, () => { Console.WriteLine("Third function"); });
        }
        public static void Shop()
        {
            Dictionary<int?, string> Product = new Dictionary<int?, string>();
            Product.Add(0, "Диван");
            Product.Add(1, "Стул");
            Product.Add(2, "Стол");
            Product.Add(3, "Постер");
            Product.Add(4, "Табурет");
            Product.Add(5, "Ленолиум");
            Product.Add(6, "Кровать");
            Product.Add(7, "Обои");
            Product.Add(8, "Люстра");
            Product.Add(9, "Окно");

            BlockingCollection<int> Warehouse = new BlockingCollection<int>();
            for (int i = 0; i < 5; i++)
            {
                Task.Run(() =>
                {
                    Random rnd = new Random();
                    while (true)
                    {
                        Thread.Sleep(rnd.Next(1000, 5000));

                        int Counter = 0;
                        Warehouse.Add(rnd.Next(0, 9));
                        Console.WriteLine("Склад: ");
                        foreach (var product in Warehouse)
                        {
                            Console.WriteLine(Product[product]);
                            Counter++;
                        }
                        if (Counter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Ничего");
                            Console.ResetColor();
                        }

                        Console.WriteLine("-------------------");
                        Thread.Sleep(rnd.Next(1000, 5000));
                    }
                });
            }
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    Random rnd = new Random();
                    while (true)
                    {
                        Thread.Sleep(rnd.Next(1000, 5000));
                        foreach (var product in Warehouse)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(Product[product] + " куплен");
                            Console.ResetColor();
                            Console.WriteLine("-------------------");

                            int i = product;
                            int Counter = 0;
                            Warehouse.TryTake(out i);
                            Console.WriteLine("Склад: ");
                            foreach (var productt in Warehouse)
                            {
                                Console.WriteLine(Product[productt]);
                                Counter++;
                            }
                            if (Counter == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Ничего");
                                Console.ResetColor();

                            }
                            else
                                Counter = 0;
                            Console.WriteLine("-------------------");
                            break;
                        }
                    }
                });
            }
            Thread.Sleep(5000);
        }

        public static void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello World");
        }
        public static async void AsyncDemonstration()
        {
            await Task.Run(() => Print());
        }
    }
}
