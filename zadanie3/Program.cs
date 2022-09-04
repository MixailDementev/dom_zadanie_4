// Задача 29
// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение.
// надо заполнить массив рандомными данными от минимального до максимального значение. 
// И важное уточнениее , делать все в методе который возвращает массив.

int[] EnterArray()
{
    Console.Write("Enter length of array: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min element of array: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max element of array: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    
    return arr;
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine($"You array: {String.Join(", ", array)}");
}

SelectionSort(EnterArray());