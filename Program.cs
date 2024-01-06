internal class Program
{
    private static void Main(string[] args)
    {
        // A for loop is used when a certain code block needs to run multiple times under specific conditions.
        // Print odd numbers up to the entered number.
        Console.Write("Please enter a number: "); // For example, when 20 is entered, it prints odd numbers up to 20.
        int limit = int.Parse(Console.ReadLine());
        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }

        // Calculate and print the sum of odd and even numbers separately between 1 and 1500.
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i <= 1500; i++)
        {
            if (i % 2 == 1)
                oddSum += i; // oddSum = oddSum + i;
            else
                evenSum += i; // evenSum = evenSum + i;
        }
        Console.WriteLine("Sum of Odds: " + oddSum);
        Console.WriteLine("Sum of Evens: " + evenSum);

        // Use of break statement to stop the loop when i equals 4.
        for (int i = 1; i < 10; i++)
        {
            if (i == 4)
                break; // Break is used to stop when i reaches 4.
            Console.WriteLine(i);
        }

        // Another example of break, stopping the loop when i equals 15.
        for (int i = 5; i < 30; i++)
        {
            if (i == 15)
                break;
            Console.WriteLine(i);
        }

        // Use of continue statement, which skips the iteration when i equals 4.
        for (int i = 1; i < 10; i++)
        {
            if (i == 4)
                continue; // Continue is used to skip the iteration when i equals 4.
            Console.WriteLine(i);
        }
    }
}
