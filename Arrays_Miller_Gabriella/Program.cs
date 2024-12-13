namespace Arrays_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number please.");
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"Sum of the array is {sum}");

            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}