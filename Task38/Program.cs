/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
 * между максимальным и минимальным элементов массива.
Пример
[3 7 22 2 78] -> 76 */

Console.Write("Введите размер массива:  ");
    int size = int.Parse(Console.ReadLine());

double[] Nums = CreateArray(size);

Console.WriteLine($"Создан массив: {ArrayToString(Nums)} ");

double diff = Math.Round(MaxNumberFind(Nums) - MinNumberFind(Nums),2);
Console.WriteLine($"Разница между максимальным ({MaxNumberFind(Nums)}) и минимальным ({MinNumberFind(Nums)}) равна: {diff}");

#region CreateNewArray // Создание массива чисел
double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random random = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble()*random.Next(int.MinValue,int.MaxValue),2);
    }
    return array;
}
#endregion

#region MaxNumberFind /Макс. элемент массива
double MaxNumberFind(double[] array)
{
    double MaxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i]> MaxNumber)
        {
            MaxNumber = array[i];
        }

    }
    return MaxNumber;
}
#endregion

#region MinNumberFind /Мин. элемент массива
// Найти минимальный элемент массива
double MinNumberFind(double[] array)
{
    double MinNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
        }

    }
    return MinNumber;
}

#endregion

#region ArrayToString /Вывод массив на экран
string ArrayToString(double[] array)
{
    string result = "[";

    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
        {
            result += $"{array[i]} ";
        }
        else
        {
            result += $"{array[i]}; ";
        }

    result += "]";
    return result;
}
#endregion