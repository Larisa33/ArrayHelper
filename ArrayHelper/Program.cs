namespace ArrayHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu numarul de elemente ale array-ului: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array-ul este: { ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("}");

            int min = ArrayHelper.FindMinRecursive(numbers, 0, numbers[0]);

            Console.WriteLine("Minimul din array-ul dat este: " + min);

            int max = ArrayHelper.FindMaxRecursive(numbers, 0, numbers[0]);

            Console.WriteLine("Maximul din array-ul dat este: " + max);
        }
    }
}