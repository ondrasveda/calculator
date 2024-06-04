using System.Collections;

public class Calculator
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                ArrayList numbers = new ArrayList();
                Console.WriteLine("choose desired operation: \n" +
                                  "1. addition \n" +
                                  "2. subtraction \n" +
                                  "3. multiplication \n" +
                                  "4. division \n" +
                                  "5. power \n" +
                                  "6. root \n" +
                                  "7. sine \n" +
                                  "8. cosine \n" +
                                  "9. tangent \n" +
                                  "10. logarithm (base 10) \n" +
                                  "11. natural logarithm \n" +
                                  "12. factorial \n" +
                                  "13. close calculator");
                int operation = Convert.ToInt32(Console.ReadLine());


                Boolean validOperation = true;
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("You chose addition");
                        break;
                    case 2:
                        Console.WriteLine("You chose subtraction");
                        break;
                    case 3:
                        Console.WriteLine("You chose multiplication");
                        break;
                    case 4:
                        Console.WriteLine("You chose division");
                        break;
                    case 5:
                        Console.WriteLine("You chose power (first choose number, then the power)");
                        break;
                    case 6:
                        Console.WriteLine("You chose root (first choose number, then the root)");
                        break;
                    case 7:
                        Console.WriteLine("You chose sine");
                        break;
                    case 8:
                        Console.WriteLine("You chose cosine");
                        break;
                    case 9:
                        Console.WriteLine("You chose tangent");
                        break;
                    case 10:
                        Console.WriteLine("You chose logarithm (base 10)");
                        break;
                    case 11:
                        Console.WriteLine("You chose natural logarithm");
                        break;
                    case 12:
                        Console.WriteLine("You chose factorial (use non decimal numbers)");
                        break;
                    case 13:
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid operation, please try again");
                        validOperation = false;
                        break;
                }

                int count;

                if (operation >= 4 && operation <= 6)
                {
                    count = 2;
                }
                else if (operation >= 7 && operation <= 12)
                {
                    count = 1;
                }
                else if (operation >= 1 && operation <= 3)
                {
                    Console.WriteLine("Choose how many numbers you want:");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    count = 0;
                }

                if (count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Choose number " + (i + 1) + ":");
                        if (operation >= 1 && operation <= 11)
                        {
                            numbers.Add(Convert.ToDouble(Console.ReadLine()));
                        }
                        else if (operation == 12)
                        {
                            numbers.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                    }

                    Console.WriteLine("You have entered the following numbers:");
                    foreach (var number in numbers)
                    {
                        Console.Write(number + " ");
                    }

                    double result = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        switch (operation)
                        {
                            case 1:
                                result += (double)numbers[i];
                                break;
                            case 2:
                                result -= (double)numbers[i];
                                break;
                            case 3:
                                result *= (double)numbers[i];
                                break;
                            case 4:
                                if ((double)numbers[i] == 0)
                                {
                                    Console.WriteLine("error, you cant divide by zero");
                                    validOperation = false;
                                    break;
                                }

                                result /= (double)numbers[i];
                                break;
                            case 5:
                                result = Math.Pow((double)numbers[0], (double)numbers[1]);
                                break;
                            case 6:
                                result = Math.Pow((double)numbers[0], (1 / (double)numbers[1]));
                                break;
                            case 7:
                                result = Math.Sin((double)numbers[i]);
                                break;
                            case 8:
                                result = Math.Cos((double)numbers[i]);
                                break;
                            case 9:
                                result = Math.Tan((double)numbers[i]);
                                break;
                            case 10:
                                result = Math.Log10((double)numbers[i]);
                                break;
                            case 11:
                                result = Math.Log((double)numbers[i]);
                                break;
                            case 12:
                                result = factorial((int)numbers[i]);
                                break;
                        }
                    }

                    if (validOperation)
                    {
                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine();
                                break;
                            case 2:
                                
                                break;
                            case 3:

                                break;
                            case 4: 
                                
                                break;
                            case 5:
                                
                                break;
                            case 6: 
                                
                                break;
                            case 7:

                                break;
                            case 8:

                                break;
                            case 9:

                                break;
                            case 10:

                                break;
                            case 11:

                                break;
                            case 12:

                                break;
                        }

                        Console.WriteLine("The result is: " + result);
                    }
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                Console.WriteLine("enter a valid value");
            }
        }

        static double factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}