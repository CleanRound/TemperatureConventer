internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.WriteLine("Enter your choice (1 or 2):");

        if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
        {
            Console.WriteLine("Enter the temperature:");
            if (double.TryParse(Console.ReadLine(), out double temperature))
            {
                double convertedTemperature = (choice == 1) ? FahrenheitToCelsius(temperature) : CelsiusToFahrenheit(temperature);
                string fromUnit = (choice == 1) ? "Fahrenheit" : "Celsius";
                string toUnit = (choice == 1) ? "Celsius" : "Fahrenheit";

                Console.WriteLine($"{temperature} {fromUnit} is equal to {convertedTemperature} {toUnit}");
            }
            else
            {
                Console.WriteLine("Error: Invalid temperature input.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid choice. Please enter 1 or 2.");
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}