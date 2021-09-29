namespace Lesson_06_SortingMethods
{
    public interface ISorting
    {
        int Sort(int[] numbers, int i, int k);
    }

    public class QuickSorter : ISorting
    {
        public QuickSorter()
        {

        }
        public int Sort(int[] numbers, int i, int k)
        {
            int l = 0;
            int h = 0;
            int midPoint = 0;
            int pivot = 0;
            int temp = 0;
            bool done = false;

            midPoint = i + (k - i) / 2;
            pivot = numbers[midPoint];
            l = i;
            h = k;
            while (!done)
            {
                while (numbers[l] < pivot)
                {
                    ++l;
                }
                while (pivot < numbers[h])
                {
                    --h;
                }
                if (l >= h)
                {
                    done = true;
                }
                else
                {
                    temp = numbers[l];
                    numbers[l] = numbers[h];
                    numbers[h] = temp;

                    ++l;
                    --h;
                }
            }
            return h;
        }

        void QuickSort(int[] numbers, int i, int k)
        {
            int j = 0;

            if (i >= k) { return; }
            Sort(numbers, i, k);
            QuickSort(numbers, i, j);
            QuickSort(numbers, j + 1, k);

            return;
        }
    }

    public class MergeSorter : ISorting
    {
        public MergeSorter()
        {

        }
        public int Sort(int[] numbers, int begin, int end)
        {
            if (begin < end)
            {
                int mid = begin + (end - begin) / 2;

                Sort(numbers, begin, mid);
                Sort(numbers, mid + 1, end);

                Merge(numbers, begin, mid, end);
            }
            return 0;
        }
        void Merge(int[] numbers, int begin, int mid, int end)
        {
            int n1 = mid - begin + 1;
            int n2 = end - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = numbers[begin + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = numbers[mid + 1 + j];
            }

            i = 0;
            j = 0;

            int k = begin;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    numbers[k] = L[i];
                    i++;
                }
                else
                {
                    numbers[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                numbers[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                numbers[k] = R[j];
                j++;
                k++;
            }

        }
    }

}
