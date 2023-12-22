//Алгоритм ссортировки методом выбора

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; // Заводим массив, который будет отсортировывать

//выводим массив
void PrintArray(int[] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);

//Метод упорядочивающий массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        //Ищем мин элемент
        for (int j = i + 1; j < array.Length; j++)
        {
          if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i]; // присвоение рабочей позиции
        array[i] = array[minPosition]; //Вкладываем в позицию элемент. котрый нашли
        array[minPosition] = temporary;
    }
}
SelectionSort(arr);

PrintArray(arr);

