namespace Utilis
{
    public class QuickSort
    {
        static void swap(ref List<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int partition(ref List<int> arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(ref arr, i, j);
                }
            }
            swap(ref arr, i + 1, high);
            return (i + 1);
        }

        public static void quickSort(ref List<int> arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(ref arr, low, high);

                quickSort(ref arr, low, pi - 1);
                quickSort(ref arr, pi + 1, high);
            }
        }
    }
}