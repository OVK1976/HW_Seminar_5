/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
 * Найдите сумму элементов, стоящих на нечётных позициях.
Пример
[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размер массива:  ");
    int size = int.Parse(Console.ReadLine());

Console.Write("Задайте минимальное значение диапазона чисел :  ");
    int StartNum = int.Parse(Console.ReadLine());

Console.Write("Задайте максимальное значение диапазона чисел :  ");
    int EndNum = int.Parse(Console.ReadLine());

int[] Nums = CreateArray(size, StartNum, EndNum+1); 
/* Увеличиваем максимальное число диапазона на 1, 
т.к. пользователь скорее всего расчитывает что начальное 
и конечное значения входят в диапазон */

Console.WriteLine($"Создан массив: {ArrayToString(Nums)} ");

Console.WriteLine($"Сумма элементов на нечетных позициях: {CountSumNumber(Nums)} ");

#region CreateNewArray // Создание массива чисел
int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}
#endregion

#region CountEvenNumber

int CountSumNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count +=array[i];
        }

    }
    return count;
}
#endregion

#region WriteArrayToString // Вывод элементов массив на экран
string ArrayToString(int[] array)
{
    string result = "[";

    for ( int i = 0; i < array.Length; i++)
        if (i == array.Length-1)
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