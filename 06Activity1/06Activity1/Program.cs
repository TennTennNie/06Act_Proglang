using System;
    class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                int num1, num2, lastnum, mod;

                Console.WriteLine("Enter Six Digit Numbers: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                num2 = num1 / 10;
                lastnum = (num1 % 10);
                mod = (num2 % 7);

                if (lastnum == mod)
                {
                    Console.WriteLine("True\n");
                }
                else
                {
                    Console.WriteLine("False\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}


