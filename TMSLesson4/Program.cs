using System;
using System.Linq;

namespace TMSLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            //task1
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task2
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task3
            Console.Write("Введите целое положительное число: ");
            int numberTaskThree = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int resultTaskThree = 0;

            while (k <= numberTaskThree)
            {
                resultTaskThree += k;
                k++;
            }

            Console.WriteLine($"Сумма чисел от 1 до {numberTaskThree} равна {resultTaskThree}");
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task4
            int number = 0;

            while (number < 98)
            {
                number += 7;
                Console.WriteLine(number);
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task5
            int u = 10;
            int resultTaskFive = 0;

            do
            {
                Console.WriteLine(resultTaskFive);
                resultTaskFive -= 5;
                u--;
            }
            while (u > 0);

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task6
            int j = 10;

            do
            {
                Console.WriteLine(Math.Pow(j, 2));
                j++;
            }
            while (j <= 20);

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();
            #endregion

            #region part2
            //arrayTask0
            int[] arrayTaskZero = { 71, 2, 14, 5, 7, 78, 9, 43, 6, 898, 54 };

            Console.Write("Начальный массив: ");
            foreach (var item in arrayTaskZero)
            {
                Console.Write($"{item} ");
            }

            Console.Write("\nВведите число для поиска: ");
            int numberArrayTaskZero = Convert.ToInt32(Console.ReadLine());

            if (Array.Exists(arrayTaskZero, item => item == numberArrayTaskZero))
            {
                Console.WriteLine($"Число {numberArrayTaskZero} входит в массив");
            }
            else
            {
                Console.WriteLine($"Число {numberArrayTaskZero} не входит в массив");
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //arrayTask1
            int[] arrayTaskOne = { 41, 24, 4, 35, 7, 78, 9, 43, 6, 88, 54, 4 };

            Console.Write("Начальный массив: ");
            foreach (var item in arrayTaskOne)
            {
                Console.Write($"{item} ");
            }

            Console.Write("\nВведите число для удаления: ");
            int numberArrayTaskOne = Convert.ToInt32(Console.ReadLine());

            if (!Array.Exists(arrayTaskOne, item => item == numberArrayTaskOne))
            {
                Console.WriteLine($"Число {numberArrayTaskOne} не входит в массив");
            }
            else
            {
                int[] resultArray = Array.FindAll(arrayTaskOne, item => item != numberArrayTaskOne);

                foreach (var item in resultArray)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //arrayTask2
            Console.Write("Введите размер массива: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arrayTaskTwo = new int[arrayLength];
            Random rand = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                arrayTaskTwo[i] = rand.Next(1, 1000);
            }

            Console.WriteLine($"Максимальное значение в массиве: {arrayTaskTwo.Max()}");
            Console.WriteLine($"Минимальное значение в массиве: {arrayTaskTwo.Min()}");
            Console.WriteLine($"Среднее значение в массиве: {arrayTaskTwo.Average()}");
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //arrayTask3
            Random randTaskThree = new Random();
            int[] arrayOne = new int[5];
            int[] arrayTwo = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arrayOne[i] = rand.Next(1, 1000);
                arrayTwo[i] = rand.Next(1, 1000);
            }

            double averageArrayOne = arrayOne.Average();
            double averageArrayTwo = arrayTwo.Average();

            Console.Write("Первый массив: ");
            foreach (var item in arrayOne)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Второй массив: ");
            foreach (var item in arrayTwo)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            if (averageArrayOne > averageArrayTwo)
            {
                Console.WriteLine($"Среднее значение элементов первого массива ({averageArrayOne}) больше среднего значения элементов второго массива ({averageArrayTwo})");
            }
            else if (averageArrayOne < averageArrayTwo)
            {
                Console.WriteLine($"Среднее значение элементов второго массива ({averageArrayTwo}) больше среднего значения элементов первого массива ({averageArrayOne})");
            }
            else
            {
                Console.WriteLine("Средние значения элементов обоих массивов равны");
            }

            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();
            #endregion

            #region part3
            //additionalTask1
            int valueOne = 0;
            int valueTwo = 0;
            int summary;

            for (int i = 0; i <= 11; i++)
            {
                if (i == 1)
                {
                    summary = 1;
                }
                else
                {
                    summary = valueOne + valueTwo;
                }

                valueOne = valueTwo;
                valueTwo = summary;
                Console.Write($"{summary} ");
            }

            Console.WriteLine("\n\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //additionalTask2
            Console.Write("Введите сумму вклада: ");
            float depositAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите срок вклада в месяцах: ");
            int depositDuration = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= depositDuration; i++)
            {
                depositAmount += depositAmount * 0.07F;
            }

            Console.Write($"После {depositDuration} месяцев сумма вклада составит {depositAmount}");
            Console.WriteLine("\n\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

        //additionalTask4
        inputValue:
            Console.Write("Введите размер массива (от 6 до 10): ");
            int arrayLengthATFour = Convert.ToInt32(Console.ReadLine());

            if (arrayLengthATFour <= 5 || arrayLengthATFour > 10)
            {
                Console.WriteLine($"Число {arrayLengthATFour} выходит за пределы допустимого диапазона\n");
                goto inputValue;
            }

            int[] arrayATFour = new int[arrayLengthATFour];
            Random randATFour = new Random();

            for (int i = 0; i < arrayLengthATFour; i++)
            {
                arrayATFour[i] = randATFour.Next(1, 1000);
            }

            Console.Write("Начальный массив: ");
            foreach (var item in arrayATFour)
            {
                Console.Write($"{item} ");
            }

            int[] resultArrayAT4 = Array.FindAll(arrayATFour, item => item % 2 == 0);

            Console.Write("\nИтоговый массив из четных чисел: ");
            foreach (var item in resultArrayAT4)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //additionalTask5
            int arrayLengthATFive = 9;
            int[] arrayATFive = new int[arrayLengthATFive];
            Random randATFive = new Random();

            for (int i = 0; i < arrayLengthATFive; i++)
            {
                arrayATFive[i] = randATFive.Next(1, 1000);
            }

            Console.Write("Начальный массив:\t");
            foreach (var item in arrayATFive)
            {
                Console.Write($"{item}\t");
            }

            for (int i = 1; i < arrayATFive.Length; i += 2)
            {
                arrayATFive[i] = 0;
            }

            Console.Write("\nИтоговый массив:\t");
            foreach (var item in arrayATFive)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\n\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //additionalTask6
            string[] stringArray = { "Anna", "John", "Oleg", "Nina", "Eugene", "Mark", "Lily" };

            Console.Write("Начальный массив: ");
            foreach (var item in stringArray)
            {
                Console.Write($"{item} ");
            }

            Array.Sort(stringArray);

            Console.Write("\nИтоговый массив: ");
            foreach (var item in stringArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //additionalTask7
            int arrayLengthATSeven = 16;
            int[] arrayATSeven = new int[arrayLengthATSeven];
            Random randATSeven = new Random();

            for (int i = 0; i < arrayLengthATSeven; i++)
            {
                arrayATSeven[i] = randATSeven.Next(1, 1000);
            }

            Console.Write("Массив до сортировки: ");
            foreach (var item in arrayATSeven)
            {
                Console.Write($"{item} ");
            }

            foreach (var item in arrayATSeven)
            {
                for (int i = 0; i < arrayLengthATSeven - 1; i++)
                {
                    if (arrayATSeven[i] > arrayATSeven[i + 1])
                    {
                        var tempValue = arrayATSeven[i];
                        arrayATSeven[i] = arrayATSeven[i + 1];
                        arrayATSeven[i + 1] = tempValue;
                    }
                }
            }

            Console.Write("\nМассив после сортировки: ");
            foreach (var item in arrayATSeven)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();

            ////accidentally
            //int arrayLengthATEight = 9;
            //int[] arrayATEight = new int[arrayLengthATEight];
            //Random randATEight = new Random();

            //for (int i = 0; i < arrayLengthATEight; i++)
            //{
            //    arrayATEight[i] = randATEight.Next(1, 1000);
            //}

            //Console.Write("\nМассив до сортировки: ");
            //foreach (var item in arrayATEight)
            //{
            //    Console.Write($"{item} ");
            //}

            //for (int i = 0; i < arrayLengthATEight - 1; i++)
            //{
            //    for (int r = i + 1; r < arrayLengthATEight; r++)
            //    {
            //        if (arrayATEight[r] < arrayATEight[i])
            //        {
            //            var tempValue = arrayATEight[i];
            //            arrayATEight[i] = arrayATEight[r];
            //            arrayATEight[r] = tempValue;
            //        }
            //    }
            //}

            //Console.Write("\nМассив после сортировки: ");
            //foreach (var item in arrayATEight)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
        }
    }
}