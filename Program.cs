namespace FactorsMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to find its factors: ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                Console.WriteLine($"Factors of {number}: ");
                // for loop to show all the numbers in desending order 
                for (int i = number; i>=1; i--)
                {
                    //check if i is a factor of the number entered 
                    if (number%i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                //handling invalid input
                Console.WriteLine("Please enter a valid postive integer! ");
            }

            Console.ReadKey();

        }
    }
}
