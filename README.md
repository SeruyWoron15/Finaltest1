# Описание

Метод для ввода значений. Выводит сообщение в консоль и ждет ввода
```
    public static string Print(string message)
    { 
        Console.WriteLine(message);
        string value =Console.ReadLine();
        return value;
    }
```
Печатает массив в консоль
```
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
```
Метод для ввода массива. Для введеного количесива элементов вызывает ввод значений
```
    public static string[] InputArray(int leght)
    { 
        string[] array = new string[leght];
        for(int i=0; i<leght; i++)
        {
          array[i]=Print($"Введите {i+1} элемент");
        }
        return array;
    }
```
Получение массива с результатом. ТК листом пользоваться нельзя, сначала узнаем количество строк<3, создаем новый массив с этой размерностью и вторым циклом заполняем его
```
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
```
Запрашиваем количество элементов во входном массиве
Заполняем масив строк
Выводим входной массив в консоль
Расчитываем массив результата
Выводим результат в консоль
```
    public static void Main(string[] args)
    {
        int leght= Convert.ToInt32( Print($"Введите количество элементов"));
        string[] array = InputArray(leght);
        Console.WriteLine($"Массив на входе");
        PrintArray(array);
        Console.WriteLine($"Результат");
        PrintArray(GetResult(array));
    }
```
