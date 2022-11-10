Console.Clear();
Console.WriteLine(@"Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на
старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры: [""hello"", ""2"", ""world"", "":-)""] -> [""2"", "":-)""] 
[""1234"", ""1567"", ""-2"", ""computer science""] -> [""-2""]
[""Russia"", ""Denmark"", ""Kazan""] -> []");

Console.WriteLine();
string[] array = new string[4] { "hello", "2", "world", ":-)" };//Пример для задачи
const int len = 4; //Длина строки по условию

int size = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < len) size++;
}
string[] modded = new string[size];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < len)
    {
        modded[j] = array[i];
        j++;
    }
}
PrintArray(array);
Console.Write(" -> ");
PrintArray(modded);

void PrintArray(string[] argument1) //Метод печати массива
{
    Console.Write("[" + String.Join("; ", argument1) + "]");
}