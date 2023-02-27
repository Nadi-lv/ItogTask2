string[] array1 = new string [5] {"1234", "1256", "-2", "world", ":-)"};
string[] array2 = new string [array1.Length];

void SecondArray (string[] array1, string[] array2)
{
    int count = 0;
    for (i = 0; i <= array1.Length; i++)
    {
        if (array1[i]<=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}