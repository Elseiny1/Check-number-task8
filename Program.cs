using System;

namespace numbers
{
    public class program
    {
        public static void Main()
        {
            int j = 0;
            do
            {
                Console.Write("Enter 5 numbers: ");
                string number = Console.ReadLine();
                if (number.Length > 5 || number.Length < 5)
                {
                    Console.WriteLine("there is more than or less than 5 digits try again :)");
                }
                else if (number.Length == 5)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] != '0' || number[i] != '1' || number[i] != '2' || number[i] != '3' || number[i] != '4' || number[i] != '5' || number[i] != '6' || number[i] != '7' || number[i] != '8' || number[i] != '9')
                        {
                            Console.WriteLine("Invalid number try again :)");
                        }
                       
                    }
                }
                j++;
            } while (j != 50);
           


        }
    }
}