


public class LinearSearch
{
    public int UsingSearch(int[] array, int n, int searchValue)
    {

        for (int i = 0; i < n; i++)
            if (array[i] == searchValue) return 1;

        return -1;
    }

    public int UsingSenitalSearch(int[] array, int n, int searchValue)
    {
        int last = array[n - 1];
        array[n - 1] = searchValue;
        int i = 0;
        while (array[i] != searchValue)
            i++;
        if ((i < n - 1) && (array[n - 1] == searchValue)) return 1;
        return -1;
    }

    public int UsingSortedSearch(int[] sortedArray, int n, int searchValue)
    {
        return -1;
    }

}