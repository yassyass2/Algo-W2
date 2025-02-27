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
        if (array != null && array.Length > 1 && low < high){
            int middle = low + (high - low) / 2;
            MergeSort(array, low, middle);
            MergeSort(array, middle+1, high);
            Merge(array, low, middle, high);
        }
    }

    public static void Merge(T[] array, int low, int middle, int high)
    {
        int finalSize = high + 1;
        int secondStart = middle + 1;

        int firstArr = middle - low + 1;
        int secondArr = high - middle;

        T[] leftArr = new T[firstArr];
        T[] rightArr = new T[secondArr];

        for (int i = 0; i < leftArr.Length; i++)
        {
            leftArr[i] = array[low + i];
        }

        for (int j = 0; j < rightArr.Length; j++)
        {
            rightArr[j] = array[middle + 1 + j];
        }

        for (int k = 0; k < finalSize; k++){
            if (low > middle) { 
                array[k] = array[secondStart]; 
                secondStart++; 
            } 
            else if (secondStart > high || array[secondStart].CompareTo(array[low]) >= 0){
                array[k] = array[low];
                low++;
            }
            else if (array[secondStart].CompareTo(array[low]) < 0){
                array[k] = array[secondStart];
                secondStart++;
            }
        }
    }
}