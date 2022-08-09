// Контрольная работа. Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArrayNew(string[] arrayOff, string[] arrayIn)
{
    int k = 0;
    for (int i = 0; i < arrayOff.Length; i++)
    {
        if (arrayOff[i].Length < 4)
        {
            arrayIn[k] = arrayOff[i];
            k++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NumberOfElementsTreeOrLess(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}