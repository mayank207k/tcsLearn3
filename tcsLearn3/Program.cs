using System;

namespace tcsLearn2
{

    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                Console.WriteLine("Enter your choice from 1-4 to perform action");
                var ch = Console.ReadLine();
                var choice = Convert.ToInt16(ch);

                int A = 0, B = 0;

                Class1 obj = new Class1();

                do
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the first number A:");
                            A = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the second number B:");
                            B = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result of Addition is {0} ", obj.add(A, B));
                            break;

                        case 2:
                            Console.WriteLine("Enter the first number A:");
                            A = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the second number B:");
                            B = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result of subtraction is {0} ", obj.subtract(A, B));
                            break;

                        case 3:
                            Console.WriteLine("Enter the first number");
                            double firstnum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the second number");
                            double secondnum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Result of multiplication is {0} ", obj.multiply(firstnum, secondnum));
                            break;

                        case 4:
                            Console.WriteLine("Enter the first number");
                            double firstnumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the second number");
                            double secondnumber = Convert.ToInt32(Console.ReadLine());
                            var result = obj.divide(firstnumber, secondnumber);
                            if (result == 0)
                            {
                                Console.WriteLine("Divisor cannnot be 0");
                            }
                            else
                            {
                                Console.WriteLine("Result of division is {0} ", result);
                            }
                            break;

                        default:
                            Console.WriteLine("Please Enter valid input");
                            break;
                    }
                    Console.WriteLine("Enter Your choice as below");
                    Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                    ch = Console.ReadLine();
                    choice = Convert.ToInt16(ch);
                } while (choice != 0);
                Console.WriteLine("Thank for using Calculator");
            }
            catch (Exception e)
            {
                Console.WriteLine(" Sorry Something went wrong, Please try again later");
            }
        }
        int add(int a, int b)
        {
            return a + b;
        }
        int subtract(int a, int b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }

        double multiply(double a, double b)
        {
            return a * b;
        }

        double divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }

    }
}