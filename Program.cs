using System;

namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose language / Elija el idioma");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Español");

            Language();
        }

        static void Language()
        {
            string? language = Console.ReadLine();
            switch (language)
            {
                case "1":
                    BMIEnglish();
                    break;
                case "2":
                    BMISpanish();
                    break;
                default:
                    Console.WriteLine("Please introduce a valid option / Por favor introduzca una opción válida");
                    Language();
                    break;
            }
        }

        static int MeasuringSystem()
        {
            string? system = Console.ReadLine();
            switch (system)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                default:
                    return 0;
            }
        }

        static void BMIEnglish()
        {
            Console.WriteLine("Choose a measuring system:");
            Console.WriteLine("1. Pounds & Inches");
            Console.WriteLine("2. Kilos & Meters");

            int system = MeasuringSystem();
            while (system == 0)
            {
                Console.WriteLine("Please introduce a valid option");
                system = MeasuringSystem();
            }

            Console.WriteLine("Introduce your weight in {0}:", system == 1 ? "pounds" : "kilos");
            var stringWeight = Console.ReadLine();
            while (stringWeight == null || stringWeight.Length == 0 || stringWeight.Any(x => char.IsLetter(x)))
            {
                Console.WriteLine("Please introduce a valid option");
                stringWeight = Console.ReadLine();
            }

            Console.WriteLine("Introduce your height in {0}:", system == 1 ? "inches" : "meters");
            var stringHeight = Console.ReadLine();
            while (stringHeight == null || stringHeight.Length == 0 || stringHeight.Any(x => char.IsLetter(x)))
            {
                Console.WriteLine("Please introduce a valid option");
                stringHeight = Console.ReadLine();
            }

            var Weight = Convert.ToDouble(stringWeight);
            var Height = Convert.ToDouble(stringHeight);
            double BMI = Weight / (Height * Height);

            if (system == 1) BMI = BMI * 703;

            Console.WriteLine($"Your BMI is {Math.Round(BMI,2)}");
            switch (true)
            {
                case true when BMI < 18.5:
                    Console.WriteLine("You're underweight!");
                    break;
                case true when BMI >= 18.5 && BMI < 25:
                    Console.WriteLine("You're normal!");
                    break;
                case true when BMI >= 25 && BMI < 30:
                    Console.WriteLine("You're overweight!");
                    break;
                case true when BMI >= 30 && BMI < 35:
                    Console.WriteLine("You're obese!");
                    break;
                case true when BMI >= 35:
                    Console.WriteLine("You're extremely obese!");
                    break;
            }
        }

        static void BMISpanish()
        {
            Console.WriteLine("Elija un sistema de medición:");
            Console.WriteLine("1. Libras y Pulgadas");
            Console.WriteLine("2. Kilos y Metros");

            int system = MeasuringSystem();
            while (system == 0)
            {
                Console.WriteLine("Por favor introduzca una opción válida");
                system = MeasuringSystem();
            }

            Console.WriteLine("Introduzca su peso en {0}:", system == 1 ? "libras" : "kilos");
            var stringWeight = Console.ReadLine();
            while (stringWeight == null || stringWeight.Length == 0 || stringWeight.Any(x => char.IsLetter(x)))
            {
                Console.WriteLine("Por favor introduzca una opción válida");
                stringWeight = Console.ReadLine();
            }

            Console.WriteLine("Introduzca su altura en {0}:", system == 1 ? "pulgadas" : "metros");
            var stringHeight = Console.ReadLine();
            while (stringHeight == null || stringHeight.Length == 0 || stringHeight.Any(x => char.IsLetter(x)))
            {
                Console.WriteLine("Por favor introduzca una opción válida");
                stringHeight = Console.ReadLine();
            }

            var Weight = Convert.ToDouble(stringWeight);
            var Height = Convert.ToDouble(stringHeight);
            double BMI = Weight / (Height * Height);

            if (system == 1) BMI = BMI * 703;

            Console.WriteLine($"Su IMC es de {Math.Round(BMI, 2)}");
            switch (true)
            {
                case true when BMI < 18.5:
                    Console.WriteLine("Tienes bajo peso!");
                    break;
                case true when BMI >= 18.5 && BMI < 25:
                    Console.WriteLine("Estas saludable!");
                    break;
                case true when BMI >= 25 && BMI < 30:
                    Console.WriteLine("Tienes sobrepeso!");
                    break;
                case true when BMI >= 30 && BMI < 35:
                    Console.WriteLine("Tienes obesidad!");
                    break;
                case true when BMI >= 35:
                    Console.WriteLine("Tienes obesidad severa o mórbida!");
                    break;
            }
        }
    }
}