string[] ClearedArray(string[] Array)
{
    string str = string.Empty;
    foreach (var item in Array)
    {
        if (item.Length <= 3)
        {
            str += item + ",";
        }
    }
    if(str.Length > 1)
        {str = str.Substring(0, str.Length - 1);}
    else
        {str = string.Empty;}
    string[] ArrayNew = str.Split(',');
 
    return ArrayNew;
}
void PrintArray(string[] Array)
{
    string str = string.Empty;
    foreach (var item in Array)
    {
        str += item + ",";
    }
    if(str.Length > 1)
        {str = str.Substring(0, str.Length - 1);}
    else
        {str = string.Empty;}
    str = "[" + str + "]";
    Console.Write(str);
}
void Main()
{
    Console.WriteLine("Введите массив строк через запятую: ");
    string[] Array = Convert.ToString(Console.ReadLine()).Split(new[] { ',' });
    PrintArray(ClearedArray(Array)); 
}
Main();