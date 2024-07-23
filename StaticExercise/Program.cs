using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Fahrenheit to convert to Celsius: ");
            bool isValidFahrenheit = double.TryParse(Console.ReadLine(), out double userTempF);
            if (isValidFahrenheit)
            {
                var celsius = TempConverter.FahrenheitToCelsius(userTempF);
                Console.WriteLine($"Converted temperature: {celsius} degrees Celsius");
            }
            else
            {
                Console.WriteLine("Invalid input for Fahrenheit temperature.");
            }

            Console.WriteLine("Enter a temperature in Celsius to convert to Fahrenheit: ");
            bool isValidCelsius = double.TryParse(Console.ReadLine(), out double userTempC);
            if (isValidCelsius)
            {
                var fahrenheit = TempConverter.CelsiusToFahrenheit(userTempC);
                Console.WriteLine($"Converted temperature: {fahrenheit} degrees Fahrenheit");
            }
            else
            {
                Console.WriteLine("Invalid input for Celsius temperature.");
            }
        }
    }
}
