/* Задача 34: Задайте массив заполненный случайными положительными 
 трёхзначными числами. Напишите программу, которая покажет 
 количество чётных чисел в массиве.
Пример
[345, 897, 568, 234] -> 2 */

Console.Write ("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine());
int [] Nums = CreateArray(size, 100, 1000);
Console.WriteLine($"Создан массив: {ArrayToString(Nums)} ");
Console.WriteLine($"Количество четных чисел в массиве: {CountEvenNumber(Nums)} ");

#region CreateNewArray // Создание массива чисел
int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new ();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}
#endregion

#region CountEvenNumber

int CountEvenNumber(int [] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }           
        
    }
return count;
}
#endregion

#region WriteArrayToString // Вывод элементов массив
string ArrayToString(int[] array)
{
    string result = "[";

    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
        {
            result += $"{array[i]}";
        }
        else
        {
            result += $"{array[i]}, ";
        }

    result += "]";
    return result;
}

#endregion