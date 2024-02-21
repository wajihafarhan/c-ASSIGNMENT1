﻿// See https://aka.ms/new-console-template for more information


//Create a C# console application that calculates the final grade of a student based on the marks obtained in three subjects: Mathematics, Science, and English. The grading system is as follows:

//• Marks range from 0 to 100 for each subject.
//• The final grade is determined based on the average marks obtained.
//• Use the following grading scale:
//• A: 90 - 100
//• B: 80 - 89
//• C: 70 - 79
//• D: 60 - 69
//• F: Below 60

//Your program should:

//Prompt the user to input marks for Mathematics, Science, and English.

//Calculate the average marks.

//Determine the final grade based on the average marks using a switch case statement.

//Display the final grade to the user.
//Ensure the program handles invalid input gracefully.

//using System;

//namespace GradeCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to the Grade Calculator!");

//            // Prompting user for input
//            Console.Write("Enter marks for Mathematics: ");
//            int mathMarks = GetValidMarks();

//            Console.Write("Enter marks for Science: ");
//            int scienceMarks = GetValidMarks();

//            Console.Write("Enter marks for English: ");
//            int englishMarks = GetValidMarks();

//            // Calculating average marks
//            double averageMarks = (mathMarks + scienceMarks + englishMarks) / 3.0;

//            // Determining final grade
//            char finalGrade = CalculateGrade(averageMarks);

//            // Displaying final grade
//            Console.WriteLine($"Final Grade: {finalGrade}");

//            Console.WriteLine("Press any key to exit.");
//            Console.ReadKey();
//        }

//        static int GetValidMarks()
//        {
//            int marks;
//            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
//            {
//                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
//                Console.Write("Enter again: ");
//            }
//            return marks;
//        }

//        static char CalculateGrade(double averageMarks)
//        {
//            char grade;
//            switch ((int)averageMarks / 10)
//            {
//                case 10:
//                case 9:
//                    grade = 'A';
//                    break;
//                case 8:
//                    grade = 'B';
//                    break;
//                case 7:
//                    grade = 'C';
//                    break;
//                case 6:
//                    grade = 'D';
//                    break;
//                default:
//                    grade = 'F';
//                    break;
//            }
//            return grade;
//        }
//    }
//}
//Create a C# console application that converts temperatures between Celsius and Fahrenheit. Your program should provide the following functionality:

//Prompt the user to choose the temperature scale they want to convert from (Celsius or Fahrenheit).

//Prompt the user to enter the temperature value.

//Convert the temperature to the other scale.

//Display the converted temperature to the user.
//Use the following formulas for conversion:

//• Celsius to Fahrenheit: F = 59​C + 32
//• Fahrenheit to Celsius: C = 95​(F−32)

//Your program should handle invalid inputs gracefully and allow the user to continue converting temperatures until they choose to exit.




using System;

class temperatureconverter
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Convert from Celsius to Fahrenheit");
            Console.WriteLine("2. Convert from Fahrenheit to Celsius");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            double temperature;
            double convertedTemperature;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius: ");
                    if (!double.TryParse(Console.ReadLine(), out temperature))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    convertedTemperature = CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"Converted temperature: {convertedTemperature} Fahrenheit");
                    break;

                case 2:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    if (!double.TryParse(Console.ReadLine(), out temperature))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    convertedTemperature = FahrenheitToCelsius(temperature);
                    Console.WriteLine($"Converted temperature: {convertedTemperature} Celsius");
                    break;

                case 3:
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}