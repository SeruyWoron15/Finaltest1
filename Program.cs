using System;
/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
public class Answer
{
    public static string Print(string message)
    { 
        Console.WriteLine(message);
        string value =Console.ReadLine();
        return value;
    }

    public static void PrintArray(string[] array)
    {
    string res="";
    for (int i=0; i< array.Length-1; i++)
      {
        res=res+array[i]+", ";
      }
      res=res+array[array.Length-1];
      Console.WriteLine("["+res+"]");
    }

    public static string[] InputArray(int leght)
    { 
        string[] array = new string[leght];
        for(int i=0; i<leght; i++)
        {
          array[i]=Print($"Введите {i+1} элемент");
        }
        return array;
    }

    public static string[] GetResult(string[] array)
    { 
      int count=0;
        for(int i=0; i<array.Length; i++)
        {
          if (array[i].Length<4)
           count++;
        }
        string[] res = new string[count];
        count=0;
        for(int i=0; i<array.Length; i++)
        {
          if (array[i].Length<4)
          {
           res[count]=array[i];
           count++;
          }
        }
        return res;
    }

    public static void Main(string[] args)
    {
        int leght= Convert.ToInt32( Print($"Введите количество элементов"));
        string[] array = InputArray(leght);
        Console.WriteLine($"Массив на входе");
        PrintArray(array);
        Console.WriteLine($"Результат");
        PrintArray(GetResult(array));
    }
}