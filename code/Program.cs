string DataInput(string message)
{
    Console.Write(message);
    string word = Console.ReadLine();
    return word;
}

string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = DataInput("Введите слово: ");
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine($"'{array[array.Length - 1]}']");
}

string[] SelectedWords(string[] array)
{
    string text = String.Empty;
    foreach (string el in array)
    {
        if (el.Length <= 3)
        {
            text += el + " ";
        }
    }
    if (text.Length > 1)
    {
        text = text.Remove(text.Length - 1);
    }
    string[] selectArray = text.Split(" ");
    return selectArray;
}

Console.Clear();
Console.Write("Сколько слов будет в массиве? -> ");
int length = int.Parse(Console.ReadLine());
string[] words = FillArray(length);
Console.WriteLine();
PrintArray(words);
string[] selectWords = SelectedWords(words);
Console.WriteLine();
Console.Write("Слова в массиве с длиной до 3х символов: ");
PrintArray(selectWords);