# **Описание работы программы**
Проект Program.cs состоит из 3-ех методов:
+ Main()
+ ClearedArray()
+ PrintArray()
## **Алгоритм**
1. Запуск программы происходит из метода *Main()*, в котором
первоначально считывается ввод массива:
```C#
string[] Array = Convert.ToString(Console.ReadLine()).Split(new[] { ',' });
```
2. После того, как массив сохранен в переменной *Array*, значение переменной передается в метод *ClearedArray()*,
результат которого будет передан в метод *PrintArray()*.
В методе *ClearedArray()* происходит отбор нужных строк, подходящих под условие _**длина <= 3**_, после метод возвращает новый строковый массив с отобранными строками, или же пустой массив, если не было выполнено условие.
```C#
PrintArray(ClearedArray(Array)); 
```


3. Результат метода *ClearedArray()* передается в метод *PrintArray()*, который выводит указанный результат(массив) на экран в квадратных скобках.