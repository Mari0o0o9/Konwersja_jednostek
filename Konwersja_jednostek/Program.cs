using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Konwersja
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Co chcesz przeliczyć? :3");
                Console.WriteLine("1 - Mile");
                Console.WriteLine("2 - Kilometry");
                Console.WriteLine("3 - Metry");
                Console.WriteLine("4 - Centymetry");
                Console.WriteLine("===============================");
                Console.WriteLine("5 - Kilogram");
                Console.WriteLine("6 - Dekagram");
                Console.WriteLine("7 - Gram");

                var key = Console.ReadKey(intercept: true).Key;
                Console.Clear();

                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Na co chcesz przeliczyć Mile?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Kilometry");
                        Console.WriteLine("2 - Metry");
                        Console.WriteLine("3 - Centymetry");

                        var keyD1 = Console.ReadKey(intercept: true).Key;
                        Console.Clear();

                        switch (keyD1)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.WriteLine("1 Mila = 1.609344 Kilometra");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD1 = Console.ReadLine();
                                double selectOptionD1;

                                if (double.TryParse(stringToConvertD1, out selectOptionD1) && selectOptionD1 >= 1)
                                {
                                    
                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD1 * 1.609 + " km");
                                }

                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.WriteLine("1 Mila = 1609.344 Metrów");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD2 = Console.ReadLine();
                                double selectOptionD2;

                                if (double.TryParse(stringToConvertD2, out selectOptionD2) && selectOptionD2 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD2 * 1609.344 + " m");
                                }

                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.WriteLine("1 Mila = 160 934.4 Centymetrów");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD3 = Console.ReadLine();
                                double selectOptionD3;

                                if (double.TryParse(stringToConvertD3, out selectOptionD3) && selectOptionD3 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD3 * 160934.4 + " cm");
                                }
                                
                                break;

                            default:
                                Console.WriteLine("Niepoprawny wybór!!!");
                                break;

                        }
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Na co chcesz przeliczyć Kilometry?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Mile");
                        Console.WriteLine("2 - Metry");
                        Console.WriteLine("3 - Centymetry");

                        var keyD2 = Console.ReadKey(intercept: true).Key;
                        Console.Clear();

                        switch (keyD2)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.WriteLine("1 Kilometr = 0.6214 Mili");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD1 = Console.ReadLine();
                                double selectOptionD1;

                                if (double.TryParse(stringToConvertD1, out selectOptionD1) && selectOptionD1 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD1 * 0.6214 + " mi");
                                }
                                
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.WriteLine("1 Kilometr = 1000 Metrów");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD2 = Console.ReadLine();
                                double selectOptionD2;

                                if (double.TryParse(stringToConvertD2, out selectOptionD2) && selectOptionD2 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD2 * 1000 + " m");
                                }

                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.WriteLine("1 Kilometr = 100 000 Centymetrów");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD3 = Console.ReadLine();
                                double selectOptionD3;

                                if (double.TryParse(stringToConvertD3, out selectOptionD3) && selectOptionD3 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD3 * 100000 + " cm");
                                }
                                
                                break;

                            default:
                                Console.WriteLine("Niepoprawny wybór!!!");
                                break;

                        }

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Na co chcesz przeliczyć Metry?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Mile");
                        Console.WriteLine("2 - Kilometry");
                        Console.WriteLine("3 - Centymetry");

                        var keyD3 = Console.ReadKey(intercept: true).Key;
                        Console.Clear();

                        switch (keyD3)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.WriteLine("1 Metr = 0.000621369949495 Mili");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD1 = Console.ReadLine();
                                double selectOptionD1;

                                if (double.TryParse(stringToConvertD1, out selectOptionD1) && selectOptionD1 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD1 * 0.000621369949495 + " mi");
                                }
                                
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.WriteLine("1 Metr = 0.001 Kilometr");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD2 = Console.ReadLine();
                                double selectOptionD2;

                                if (double.TryParse(stringToConvertD2, out selectOptionD2) && selectOptionD2 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD2 * 0.001 + " km");
                                }
                                
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.WriteLine("1 metr = 100 Centymetrów");
                                Console.WriteLine("============================");
                                Console.WriteLine("Podaj swoją liczbe:");

                                var stringToConvertD3 = Console.ReadLine();
                                double selectOptionD3;

                                if (double.TryParse(stringToConvertD3, out selectOptionD3) && selectOptionD3 >= 1)
                                {

                                    Console.WriteLine("============================");
                                    Console.WriteLine("Wynik: " + selectOptionD3 * 100 + " cm");
                                }
                                
                                break;

                            default:
                                Console.WriteLine("Niepoprawny wybór!!!");
                                break;

                        }

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Na co chcesz przeliczyć Centymetry?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Mile");
                        Console.WriteLine("2 - Kilometry");
                        Console.WriteLine("3 - Metry");
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("Na co chcesz przeliczyć Kilogramy?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Dekagram");
                        Console.WriteLine("2 - Gram");
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("Na co chcesz przeliczyć Dekagramy?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Kilogram");
                        Console.WriteLine("2 - Gram");
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Console.WriteLine("Na co chcesz przeliczyć Gramy?");
                        Console.WriteLine("===============================");
                        Console.WriteLine("1 - Kilogram");
                        Console.WriteLine("2 - Dekagram");
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybór!!!");
                        break;
                }
                Console.WriteLine("Nacisnij dowolny przycisk zeby kontynuować");
                Console.ReadKey(intercept:true);
                Console.Clear();
            }
            
        }
    }
}