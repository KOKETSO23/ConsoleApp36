namespace ConsoleApp36
{
    using System;

    public class NumberToWordsConverter
    {
        // Main function to demonstrate conversion
        public static void Main(string[] args)
        {
            // Output examples
            Console.WriteLine(NumberToWords(149)); // Output: One Hundred Forty-Nine
            Console.WriteLine(NumberToWords(1149)); // Output: One Thousand One Hundred Forty-Nine
            Console.WriteLine(NumberToWords(42)); // Output: Forty-Two
            Console.WriteLine(NumberToWords(890)); // Output: Eight Hundred Ninety
        }

        // Function to convert number to words
        public static string NumberToWords(int number)
        {
            // Check for zero
            if (number == 0)
                return "Zero";

            // Handle negative numbers
            if (number < 0)
                return "Minus " + NumberToWords(Math.Abs(number));

            string words = "";

            // Process thousands place
            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            // Process hundreds place
            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            // Process tens and units place
            if (number > 0)
            {
                if (words != "")
                    words += "And ";

                // Array for units and teens
                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                // Array for tens
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                // Process numbers less than 20
                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            // Return the final word representation
            return words.Trim();
        }
    }


}
