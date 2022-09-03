var rand = new Random();


void CutArray()
{

    int arrayLength = rand.Next(3, 15);
    Console.WriteLine(arrayLength);
    string[] array = new string[arrayLength];
    PrintArray(array);
    array = FillArray(array, arrayLength);
    PrintArray(array);
    string newArray[]
    for (int i = 0)
}



string[] FillArray(string[] array, int arrayLength, int currentIndex = 0, string currentAnswer = "firstAnswer") // Метод заполнения массива пользователем
{
    Console.Write("Введите элемент массива:");
    currentAnswer = Console.ReadLine();
    array[currentIndex++] = currentAnswer;
    if (String.IsNullOrEmpty(currentAnswer) || currentIndex >= arrayLength)
    {
        return array;
    }
    else
    {
        return FillArray(array, arrayLength, currentIndex, currentAnswer);
    }
}

// string[] ShortValies(string[] array, int length)
// {
//     int arrayLength = array.Length;
//     string[] newArray = new string[arrayLength];
//     int j = 0;
//     for (int i = 0; i < arrayLength; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             newArray[j++] = array[i];
//         }
//     }
//     Array.Resize(newArray, j + 1);
//     return newArray;
// }




void PrintArray(string[] array) // метод печати массива
{
    Console.WriteLine(string.Join(" ", array));
}


CutArray(); // запуск программы