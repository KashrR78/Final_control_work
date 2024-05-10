// Итоговая контрольная работа по основному блоку
string[] array1 = new string[6] { "257", "45", "hello", "world", "res", "456" };


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

