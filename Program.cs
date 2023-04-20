// See https://aka.ms/new-console-template for more information
using System;

namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public Stopwatch()
        {
            startTime = DateTime.Now;
            endTime = DateTime.Now;
        }

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan elapsed = endTime - startTime;
            return elapsed.TotalMilliseconds;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100000];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100000);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SelectionSort(numbers);

            stopwatch.Stop();

            Console.WriteLine("Selection sort took {0} milliseconds.", stopwatch.GetElapsedTime());

            Console.WriteLine("Sorted numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
                Console.WriteLine("Swapped {0} with {1}", arr[minIndex], arr[i]);

            }
        }
    }
}
