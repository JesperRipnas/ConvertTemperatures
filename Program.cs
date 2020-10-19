using System;

namespace ConvertTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Menu
                MainMenu();

                while (true)
                {
                    //Input
                    double converted;
                    Console.Write("\nSelect an option: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    // If user picks option 7, the program ends
                    if (userInput == 7)
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                    // Switch to check what option and method user wants to use
                    Console.Write("\nEnter value to convert: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            converted = CelciusToFahrenheit(value);
                            Console.WriteLine($"{value}°C is {converted}°F");
                            break;
                        case 2:
                            converted = FahrenheitToCelcius(value);
                            Console.WriteLine($"{value}°F is {converted}°C");
                            break;
                        case 3:
                            converted = CelciusToKelvin(value);
                            Console.WriteLine($"{value}°C is {converted.ToString("F2")}K");
                            break;
                        case 4:
                            converted = FahrenheitToKelvin(value);
                            Console.WriteLine($"{value}°F is {converted.ToString("F2")}K");
                            break;
                        case 5:
                            converted = KelvinToCelcius(value);
                            Console.WriteLine($"{value}K is {converted.ToString("F2")}°C");
                            break;
                        case 6:
                            converted = KelvinToFahrenheit(value);
                            Console.WriteLine($"{value}K is {converted.ToString("F2")}°F");
                            break;
                    }
                    Console.ReadKey();
                }
            }
            // Menu method
            static void MainMenu()
            {
                Console.Clear();
                Console.WriteLine("(1) Convert from Celsius to Fahrenheit");
                Console.WriteLine("(2) Convert from Fahrenheit to Celcius");
                Console.WriteLine("(3) Convert from Celcius to Kelvin");
                Console.WriteLine("(4) Convert from Fahrenheit to Kelvin");
                Console.WriteLine("(5) Convert from Kelvin to Celcius");
                Console.WriteLine("(6) Convert from Kelvin to Fahrenheit");
                Console.WriteLine("(7) Exit");

            }
            // Methods to calculate input vs the option user picks
            static double CelciusToFahrenheit(double userInput)
            {
                return (userInput / 5) * 9 + 32;
            }
            static double FahrenheitToCelcius(double userInput)
            {
                return (userInput - 32) * 5 / 9;
            }
            static double CelciusToKelvin(double userInput)
            {
                return userInput + 273.15;
            }
            static double FahrenheitToKelvin(double userInput)
            {
                return (userInput + 459.67) * 5 / 9;
            }
            static double KelvinToCelcius(double userInput)
            {
                return userInput - 273.15;
            }
            static double KelvinToFahrenheit(double userInput)
            {
                return userInput * 9 / 5 - 459.67;
            }
        }
    }
}
