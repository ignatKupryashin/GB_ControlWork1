string[] FillArray(string[] array, int arrayLength, int currentIndex = 0, string currentAnswer = "firstAnswer") // Метод заполнения массива пользователем
{
    Console.Write("Введите элемент массива:");
    currentAnswer = Console.ReadLine();
    if (String.IsNullOrEmpty(currentAnswer) == false && currentIndex < arrayLength)
    {
        array[currentIndex++] = currentAnswer;
        return FillArray(array, arrayLength, currentIndex, currentAnswer);
    }
    else
    {
        if (currentIndex < arrayLength)
        {
            Array.Resize(ref array, currentIndex);
        }
        return array;
    }
}

string[] ShortValies(string[] array, int length) // метод, которыей создаёт новый массив только из строк заданной длинны
{
    int arrayLength = array.Length;
    string[] newArray = new string[arrayLength];
    int j = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j++] = array[i];
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

void PrintArray(string[] array) // метод печати массива
{
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine(string.Join(" ", array));
    Console.WriteLine("");//пустая строка для красоты
}

void CutArray()
{
    Console.Write("Введите первоначальную длинну массива: ");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[arrayLength];
    array = FillArray(array, arrayLength);
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine("Длинна парвоначального массива: " + array.Length);
    Console.Write("Первоначальный массив: ");
    PrintArray(array);
    Console.WriteLine("");//пустая строка для красоты
    string[] newArray = ShortValies(array, 3);
    Console.WriteLine("Итоговая длинна массива: " + newArray.Length);
    Console.Write("Итоговый массив: ");
    PrintArray(newArray);
}

CutArray(); // запуск программы