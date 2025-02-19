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


    public static void MergeSort(T[] arr, int low, int high)
    {
        if (arr == null || arr.Length <= 1 || low >= high) return;
        int middle = (low+high)/2;
        MergeSort(arr, low, middle);
        MergeSort(arr, middle+1, high);
        Merge(arr, low, middle, high);
    }

    public static void Merge(T[] arr, int low, int middle, int high)
    {
        int finalsize = arr.Length;
        int secondStart = middle+1;

        for (int i = 0; i <= finalsize; i++){
            if (secondStart >= finalsize || arr[low] <= arr[secondStart]){
                arr[i] = arr[low];
                low++;
            }
            else if (low > middle || arr[secondStart] < arr[low]){
                arr[i] = arr[secondStart];
                secondStart++;
            }
        }
    }
}