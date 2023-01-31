namespace Deliverable__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 100");
            
            
            try
            { 
                int input = int.Parse(Console.ReadLine());

                if (input >= 0 && input <= 100)
                {

                    Console.WriteLine("Specify the series type: Odd or Even");


                    string series = Console.ReadLine();


                    if (series.ToLower() == "odd")
                    {
                        Console.WriteLine("You have selected:" + series);
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    else if (series.ToLower() == "even")
                    {
                        Console.WriteLine("You have selected:" + series);
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }

                    }

                    else
                    {
                        Console.WriteLine("Please specify either 'Odd' or 'Even'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 0 & 100");
                }
            }

            catch
            {
                Console.WriteLine("Please enter an interger");
            }
        }
    }
}