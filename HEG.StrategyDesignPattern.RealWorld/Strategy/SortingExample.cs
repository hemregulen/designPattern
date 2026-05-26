namespace HEG.StrategyDesignPattern.RealWorld.Strategy
{
    public interface ISortStrategy
    {
        int[] Sort(int[] data);
    }

    public class Sorter
    {
        private ISortStrategy _strategy;

        public Sorter(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sort(int[] data)
        {
            int[] sorted = _strategy.Sort((int[])data.Clone());
            Console.WriteLine($"{_strategy.GetType().Name}: {string.Join(", ", sorted)}");
        }
    }

    public class BubbleSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        (data[j], data[j + 1]) = (data[j + 1], data[j]);
                    }
                }
            }

            return data;
        }
    }

    public class QuickSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data)
        {
            Array.Sort(data);
            return data;
        }
    }

    public class MergeSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] data)
        {
            return MergeSort(data);
        }

        private static int[] MergeSort(int[] data)
        {
            if (data.Length <= 1)
            {
                return data;
            }

            int middle = data.Length / 2;
            int[] left = MergeSort(data[..middle]);
            int[] right = MergeSort(data[middle..]);
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> merged = new();
            int i = 0;
            int j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    merged.Add(left[i++]);
                }
                else
                {
                    merged.Add(right[j++]);
                }
            }

            merged.AddRange(left[i..]);
            merged.AddRange(right[j..]);
            return merged.ToArray();
        }
    }
}
