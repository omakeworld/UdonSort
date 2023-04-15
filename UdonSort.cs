using UdonSharp;

public static class UdonSort
{
    public static void Sort(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }

    [RecursiveMethod]
    static void QuickSort(int[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int num = array[start];

        int i = start, j = end;

        while (i < j)
        {
            while (i < j && array[j] > num)
            {
                j--;
            }

            array[i] = array[j];

            while (i < j && array[i] < num)
            {
                i++;
            }

            array[j] = array[i];
        }

        array[i] = num;
        QuickSort(array, start, i - 1);
        QuickSort(array, i + 1, end);
    }
}

