using Lab_1;
using System;

namespace Lab_4
{
    public class QuickSortArray : CustomArray
    {
        public QuickSortArray(CustomArray array, StartedOrder order) : base(array.count, order)
        {
            count = array.count;
            numbers = array.numbers;
        }

        public void QuickSort() => ProcessQuickSort(numbers, 0, numbers.GetLength(0) - 1);
        public void RandomQuickSort() => ProcessRandomQuickSort(numbers, 0, numbers.GetLength(0) - 1);

        private void ProcessQuickSort(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Division(numbers, low, high);
                ProcessQuickSort(numbers, low, pivotIndex - 1);
                ProcessQuickSort(numbers, pivotIndex + 1, high);
            }
        }

        private void ProcessRandomQuickSort(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = new Random().Next(low, high + 1);
                Swap(numbers, pivotIndex, high);
                int divisionIndex = Division(numbers, low, high);
                ProcessRandomQuickSort(numbers, low, divisionIndex - 1);
                ProcessRandomQuickSort(numbers, divisionIndex + 1, high);
            }
        }

        private int Division(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];
            int index = low - 1;
            for (int j = low; j < high; j++)
            {
                if (numbers[j] <= pivot)
                {
                    index++;
                    Swap(numbers, index, j);
                }
            }
            Swap(numbers, index + 1, high);
            return index + 1;
        }

        private void Swap(int[] numbers, int first, int second)
        {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
