namespace Assignment_3._2._4
{
    //Practice passing arrays as parameters and return variable
    //function takes 4 numbers as input to calculate the total and average
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = GetNumber();
            }

            double[] stats = MakeCalculations(numbers);

            Console.WriteLine($"The average of {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]} is: {stats[1]}");
            Console.WriteLine($"The total is {stats[0]}");
        }
        static double GetNumber()
        {
            double result = 0;
            while (!Double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid entry, please try again.");

            }
            return result;
        }

        static double[] MakeCalculations(double[] numbers)
        {
            double[] output = new double[2];
            double sum = 0;

            foreach (double d in numbers)
            {
                sum += d;
            }
            output[0] = sum;
            output[1] = sum / numbers.Length;


            return output;
        }
    }
}
