// Итоговая контрольная работа по основному блоку
string[] array1 = new string[8] { "12ii3", "45", "ygtfdgh", "ytr", "tre455", "on", "uyt", "767" };


int SaizArray(string[] array1)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            n++;
        }
    }
    return n;
}

string[] array2 = new string[SaizArray(array1)];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FilledArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
PrintArray(array1);
FilledArray(array1, array2);
PrintArray(array2);