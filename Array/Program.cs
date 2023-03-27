internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, -1, 0, 2, 3, -4, 5, 4, -8, 7, 11 };
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) Console.Write($"{arr[i]} ");
        }
        Console.WriteLine("");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) Console.Write($"{arr[i]} ");
        }
    }
}