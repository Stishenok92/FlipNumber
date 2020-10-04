using System;
using System.ComponentModel.DataAnnotations;

namespace FlipNumberLibrary
{
    public class FlipNumber
    {
        public static int MIN_NATURAL_NUMBER = 1;

        public static bool ValidationNumber(int number)
        {
            return number >= MIN_NATURAL_NUMBER;
        }

        public static int FlipIntNumber(int number)
        {
            if (!ValidationNumber(number))
            {
                throw new ValidationException();
            }

            int result = 0;

            while (number != 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }

            return result;
        }
    }
}