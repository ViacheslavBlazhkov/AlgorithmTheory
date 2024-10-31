using Lab_1;
using Lab_2;

namespace Lab_3
{
    public class InversionArray : CustomArrayWithMerge
    {
        public int inversionCount = 0;

        public InversionArray(CustomArray array, StartedOrder order) : base(array, order)
        {
        }

        protected override int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                    inversionCount += array1.Length - i;
                }
            }
            while (i < array1.Length)
            {
                mergedArray[k++] = array1[i++];
            }
            while (j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }
            return mergedArray;
        }

        public override void InsertingSort()
        {
            for (int i = 1; i < count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = tmp;
                        inversionCount++;
                    }
                }
            }
        }
    }
}
