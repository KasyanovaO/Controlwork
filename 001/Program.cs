﻿/*/Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами/*/

class Program
{
    static void PrintArray(string[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length-1)
            {
                Console.Write(arr[i] + "");
            }
            else
            {
                Console.Write(arr[i] + ", ");
            }
        }
        Console.Write("]");

    }
    static void Main(string[] args)
    {
        string[] array = new string [4] {"hello", "2", "world", ":-)"};
        string[] newarray  = new string[array.Length];
        Console.WriteLine("Массив");
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine("Новый массив ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newarray[count]=array[i];
                count++;
            }
        }
        PrintArray2(newarray);
    }
    static void PrintArray2(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i <= array.Length - i - 1; i++)
        {
            if (i == (array.Length - 1) / 2)
            {
                Console.Write(array[i] + "");
            }
            else
            {
                Console.Write(array[i] + ", ");
            }

        }
        Console.Write("]");
    }
}



