public class Algorithms
{
    public static int[] SortNumbersArray(int[] numbers)
    {
        int lastIndex = numbers.Length - 1;
        int previousIndex = lastIndex - 1;
        bool isPositionChanged = false;

        while (true)
        {
            if (previousIndex < 0)
            {
                if (!isPositionChanged)
                {
                    lastIndex = lastIndex - 1;
                    if (lastIndex == 0)
                        break;
                }

                previousIndex = lastIndex - 1;
                isPositionChanged = false;
            }

            if (numbers[lastIndex] < numbers[previousIndex])
            {
                ReplaceIndex<int>(ref numbers, lastIndex, previousIndex);
                isPositionChanged = true;
            }
            
            previousIndex--;
        }

        return numbers;
    }


    private static void ReplaceIndex<T>(ref T[] array, int first, int second)
    {
        T firstValue = array[first];
        T secondValue = array[second];

        array[first] = secondValue;
        array[second] = firstValue;
    }
}

public class Program
{
    

    public static void Main(string[] args)
    {
        var sortedNumbers = Algorithms.SortNumbersArray(new int[] { 5, 2, 4, 7 });
        Console.WriteLine(string.Join(",", sortedNumbers));

        Console.ReadLine();
    }
}
