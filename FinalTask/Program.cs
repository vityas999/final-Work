string[] ArrayWithIf(string[] array1, string[] array2)
{
    int count = 0;
    int stop = 3;
    for (int i = 0; i < array2.Length; i++)
    {
        if (i < array2.Length && array1[i].Length <= stop)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    int lengthResultArray = count;
    string[] resultArray = new string[lengthResultArray];
    for (int i = 0; i < lengthResultArray; i++)
    {
        resultArray[i] = array2[i];
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        string thing = ", ";
        if (i == 0 && array.Length == 1) Console.Write("[" + array[i] + "]");
        else if (i == 0 && array.Length != 1) Console.Write("[" + array[i] + thing);
        else
        {
            if (i != array.Length - 1) Console.Write(array[i] + thing);
            else Console.Write(array[i] + "]");
        }
    }
    Console.WriteLine();
}

void main()
{
    string[] array = new string[6] { "124", "that", "000000", "88005553535", "it", "not" };
    string[] sortArray = new string[array.Length];
    string[] result = ArrayWithIf(array, sortArray);
    PrintArray(array);
    PrintArray(result);
}

main();