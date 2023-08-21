string[] array1 = new string[10] {"Marx", "164", "Top","Task","Yes","No", "U2","Hello", "World", "rus"};
string[] array2 = new string[array1.Length];
void SelectFromArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SelectFromArray(array1, array2);
PrintArray(array2);
