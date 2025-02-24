namespace ToDo;
public class Sort<T> : ISort<T> where T : IComparable<T>
{
    public static void BubbleSort(T[] data)
    {
        if (data == null || data.Length <= 1) return;
        bool swap = true;
        int until = 1;
        while(swap){
            swap = false;
            for (int i = 0; i < data.Length-until; i++){
                if (data[i].CompareTo(data[i+1]) > 0){
                    (data[i], data[i+1]) = (data[i+1], data[i]);
                    swap = true;
                }
            }
            until++;
        }

    }

    public static void InsertionSort(T[] data)
    {
        if (data == null || data.Length <= 1) return;
        int prev;
        for (int ind = 1; ind < data.Length; ind++){
            T key = data[ind];
            prev = ind - 1;
            while(prev >= 0 && data[prev].CompareTo(key) > 0){
                data[prev+1] = data[prev];
                prev--;
            }
            data[prev+1] = key;
        }
    }


    public static void MergeSort(T[] array, int low, int high)
    {
        if (array == null || array.Length <= 1 || low >= high) return;
        int middle = (low+high)/2;
        MergeSort(array, low, middle);
        MergeSort(array, middle+1, high);
        Merge(array, low, middle, high);
    }

    public static void Merge(T[] array, int low, int middle, int high)
    {
        int finalSize = high + 1;;
        int secondStart = middle+1;

        for (int i = 0; i < finalSize; i++){
            if (secondStart >= finalSize || array[low] <= array[secondStart]){
                array[i] = array[low];
                low++;
            }
            else if (low > middle || array[secondStart] < array[low]){
                array[i] = array[secondStart];
                secondStart++;
            }
        }
    }
}