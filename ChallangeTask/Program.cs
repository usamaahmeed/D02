namespace ChallangeTask
{
    internal class Program
    {
        static void NewFunction(int first , int second , string opration = "+")
        {
            
            int sum = 0;
            if (opration == "+")
            {
                sum = first + second;
                Console.WriteLine(sum);

            }
            else if (opration == "-")
            {
                sum = first - second;
                Console.WriteLine(sum);

            }
            else if (opration == "*")
            {
                sum = first * second;
                Console.WriteLine(sum);

            }


        }

        static void Main(string[] args)
        {
            int firstNum ;
            int secondNum ;
            string opreation;
            Console.Write("Enter first number:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation:");
            opreation = Console.ReadLine();
            Console.Write("Expected Output:");

            NewFunction(firstNum , secondNum ,opreation);


        }
    }
}
