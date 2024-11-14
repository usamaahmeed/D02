namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var numbers = new List<int>();

            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear The Whole List");
                Console.WriteLine("Q - Quit");
                Console.Write("==>");
                var input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                else if (input.ToLower() == "p")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (i == 0 && numbers.Count == 1)
                            {
                                Console.Write("[" + numbers[i] + "]\n");
                            }
                            else if (i == 0)
                            {
                                Console.Write("[" + numbers[i]);
                            }
                            else if (i == numbers.Count - 1)
                            {
                                Console.Write("," + numbers[i] + "]\n");
                            }
                            else
                            {
                                Console.Write("," + numbers[i]);
                            }
                            
                        }
                    }


                }
                else if (input.ToLower() == "a")
                {
                    Console.Write("Enter a number to add : ==> ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Number already exists");
                        continue;
                    }
                    numbers.Add(number);
                    Console.WriteLine($" {number} added");


                }
                else if (input.ToLower() == "m")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        var sum = 0;
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine("Mean is " + sum / numbers.Count);
                    }
                }
                else if (input.ToLower() == "s")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        var min = numbers[0];
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < min)
                            {
                                min = numbers[i];
                            }
                        }

                        Console.WriteLine("Smallest number is " + min);
                    }
                }
                else if (input.ToLower() == "l")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        var max = numbers[0];
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > max)
                            {
                                max = numbers[i];
                            }
                        }
                        Console.WriteLine("Largest number is " + max);
                    }

                }
                else if (input.ToLower() == "f")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        Console.Write("Enter a number to find : ==> ");
                        var number = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine($"Number {number} found at index {numbers.IndexOf(number)+1}");

                        }
                        else
                        {
                            Console.WriteLine("Number not found");
                        }

                    }

                }
                else if (input.ToLower() == "c")
                {
                    numbers.Clear();
                    Console.WriteLine("List cleared");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            } while (true);




        }
    }
}
