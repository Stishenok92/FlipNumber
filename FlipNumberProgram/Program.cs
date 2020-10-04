using System;
using System.ComponentModel.DataAnnotations;
using static FlipNumberLibrary.FlipNumber;

namespace FlipNumberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task \"Flip number\"\n");

            try
            {
                Console.Write("Enter natural number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Answer: " + FlipIntNumber(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}