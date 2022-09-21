using System;
// ---------------------------------------------------------------
/*
Условия задачи:
Написать программу, которая из массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 

Пример:
[hello; 2; world; :-)] -> [2; :-)]

*/
// ---------------------------------------------------------------

Console.Write("Введите через пробел массив строк: ");
string[] array = Console.ReadLine().Split();
int size = array.Length;
string[] arraytemp = new string[size];
int k = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        arraytemp[k] = array[i];
        k++;
    }
}

string[] ArrayResize(string[] array)
{
    string[] arrayresult = new string[k];

    for (int i = 0; i < k; i++)
    {
        arrayresult[i] = array[i];
    }
    return arrayresult;
}

Console.WriteLine();
Console.WriteLine($"Первоначальный массив строк: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Результирующий массив строк: [ {String.Join("; ", ArrayResize(arraytemp))} ]");

