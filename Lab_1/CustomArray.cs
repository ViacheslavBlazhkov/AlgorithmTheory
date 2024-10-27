using System;
using System.Linq;

namespace Lab_1
{
    public class CustomArray
    {
        public int[] numbers;
        public int count;

        public CustomArray(int count, StartedOrder order)
        {
            SetNumbers(count, order);
        }

        private void SetNumbers(int count, StartedOrder order)
        {
            this.count = count;
            if (order == StartedOrder.Ascending) numbers = Enumerable.Range(1, count).ToArray();
            else if (order == StartedOrder.Descending) numbers = Enumerable.Range(1, count).Reverse().ToArray();
            else if (order == StartedOrder.Random)
            {
                int[] numbers = Enumerable.Range(1, count).ToArray();
                Random random = new Random();
                this.numbers = numbers.OrderBy(x => random.Next()).ToArray();
            }
        }

        public void InsertingSort()
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
                    }
                }
            }
        }

        public void BubbleSort()
        {
            while (true)
            {
                bool withReplacements = false;
                for (int i = 1; i < count; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        int tmp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = tmp;
                        withReplacements = true;
                    }
                }
                if (!withReplacements)
                {
                    break;
                }
            }
        }
    }
}
