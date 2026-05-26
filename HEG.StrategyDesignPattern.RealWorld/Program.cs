using HEG.StrategyDesignPattern.RealWorld.Strategy;

Sorter sorter = new(new BubbleSortStrategy());
int[] values = [8, 3, 6, 1, 7];

sorter.Sort(values);
sorter.SetStrategy(new QuickSortStrategy());
sorter.Sort(values);
sorter.SetStrategy(new MergeSortStrategy());
sorter.Sort(values);
