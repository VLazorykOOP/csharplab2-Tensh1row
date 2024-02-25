namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
        }
    }
}
1.6
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмірність масиву:");
        int size = int.Parse(Console.ReadLine());

        // Одновимірний масив
        int[] array1D = new int[size];

        // Заповнюємо масив випадковими значеннями і виводимо його
        Console.WriteLine("Одновимірний масив:");
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            array1D[i] = rnd.Next(-100, 100); // Генеруємо випадкові числа від -100 до 100
            Console.Write(array1D[i] + " ");
        }
        Console.WriteLine();

        // Розраховуємо середнє арифметичне від'ємних елементів одновимірного масиву
        int sum1D = 0;
        int countNegative1D = 0;
        foreach (int num in array1D)
        {
            if (num < 0)
            {
                sum1D += num;
                countNegative1D++;
            }
        }
        double average1D = countNegative1D > 0 ? (double)sum1D / countNegative1D : 0;
        Console.WriteLine($"Середнє арифметичне від'ємних елементів одновимірного масиву: {average1D}");

        // Двовимірний масив
        int[,] array2D = new int[size, size];

        // Заповнюємо та виводимо двовимірний масив
        Console.WriteLine("Двовимірний масив:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                array2D[i, j] = rnd.Next(-100, 100);
                Console.Write(array2D[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Розраховуємо середнє арифметичне від'ємних елементів двовимірного масиву
        int sum2D = 0;
        int countNegative2D = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (array2D[i, j] < 0)
                {
                    sum2D += array2D[i, j];
                    countNegative2D++;
                }
            }
        }
        double average2D = countNegative2D > 0 ? (double)sum2D / countNegative2D : 0;
        Console.WriteLine($"Середнє арифметичне від'ємних елементів двовимірного масиву: {average2D}");

        Console.ReadLine();
    }
}
2.6
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмірність масиву:");
        int size = int.Parse(Console.ReadLine());

        double[] array = new double[size];

        // Введення елементів масиву
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        // Пошук номера першого мінімального елемента
        double min = array[0];
        int minIndex = 0;
        for (int i = 1; i < size; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }

        // Виведення результату
        Console.WriteLine($"Номер першого мінімального елемента: {minIndex + 1}");

        Console.ReadLine();
    }
}
3.6
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмірність масиву n:");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        // Заповнення масиву випадковими числами
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(10, 100); // Для прикладу, генеруємо числа від 10 до 99
            }
        }

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Поміняти рядки відповідно до умови
        int middleRow = n / 2;
        int[,] newArray = new int[n, n];
        if (n % 2 == 0) // Якщо кількість рядків парна
        {
            // Поміняти два середні рядки
            for (int j = 0; j < n; j++)
            {
                newArray[j, j] = array[(middleRow + j) % n, j];
                newArray[(middleRow + j) % n, j] = array[j, j];
            }
        }
        else // Якщо кількість рядків непарна
        {
            // Поміняти перший з середнім рядком
            for (int j = 0; j < n; j++)
            {
                newArray[j, j] = array[(middleRow + 1 + j) % n, j];
                newArray[(middleRow + 1 + j) % n, j] = array[j, j];
            }
        }

        // Виведення масиву після змін
        Console.WriteLine("Масив після змін:");
        PrintArray(newArray);

        Console.ReadLine();
    }

    // Функція для виведення масиву на екран
    static void PrintArray(int[,] arr)
    {
        int n = arr.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
4.6
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість рядків:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість елементів у кожному рядку:");
        int m = int.Parse(Console.ReadLine());

        // Створюємо східчастий масив
        int[,] array = new int[n, m];

        // Заповнюємо масив випадковими числами
        Random rnd = new Random();
        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i, j] = rnd.Next(-10, 10); // Генеруємо випадкові числа від -10 до 10
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Знаходимо перший додатній елемент для кожного стовпця і записуємо їх у новий масив
        int[] resultArray = new int[n];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i, j] > 0)
                {
                    resultArray[j] = array[i, j];
                    break;
                }
            }
        }

        // Виводимо новий масив
        Console.WriteLine("Новий масив з першими додатніми елементами з кожного стовпця:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(resultArray[i] + " ");
        }

        Console.ReadLine();
    }
}
