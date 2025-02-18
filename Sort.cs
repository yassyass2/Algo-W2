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
                if (data[i] > data[i+1]){
                    (data[i], data[i+1]) = (data[i+1], data[i]);
                    swap = true;
                }
            }
            until++;
        }

    }

    public static void InsertionSort(T[] data)
    {
        throw new NotImplementedException(); //ToDo
    }


    public static void MergeSort(T[] array, int low, int high)
    {
        throw new NotImplementedException(); //ToDo
    }

    public static void Merge(T[] array, int low, int middle, int high)
    {
        throw new NotImplementedException(); //ToDo
    }
}