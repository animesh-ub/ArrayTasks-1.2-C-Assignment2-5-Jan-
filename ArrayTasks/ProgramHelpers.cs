internal static class ProgramHelpers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }

        int average = 0;

        average = sum / size;

        Console.WriteLine($"Sum of array is: {sum}");
        Console.WriteLine($"Average of array is {average}");

    }
}