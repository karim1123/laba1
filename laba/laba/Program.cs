using System;


namespace first_task
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 0, 14343.5, 3.9, 5.1, 45, 53.543, 5.32, 43.432, -43242.4, -34.43 };
            Console.WriteLine("Массив до вызова метода: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            double[] arr1 = Array(arr);
            Console.WriteLine("\nМассив после вызова метода: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

        }

        public static double[] Array(double[] myArr)
        {
            double max = 0;
            double min = myArr[0];
            double arifm = 0;
            int MaxIndex = 0;
            int MinIndex = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > max)
                {
                    max = myArr[i];
                    MaxIndex = i;
                }

                else if (myArr[i] < min)
                {
                    min = myArr[i];
                    MinIndex = i;
                }

                arifm += myArr[i];
            }

            arifm /= myArr.Length;

            if (MinIndex > MaxIndex)
            {
                int a;
                a = MinIndex;
                MinIndex = MaxIndex;
                MaxIndex = a;
            }
            for (int i = MinIndex + 1; i < MaxIndex; i++)
            {
                myArr[i] = arifm;
            }

            return myArr;
        }


    }
}

