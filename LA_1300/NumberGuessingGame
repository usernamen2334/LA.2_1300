using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_2._1300
{
    public class NumberGuessingGame
    {
        public void Play()
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int counter = 0;

            Console.Clear();

            while (true)
            {
                Console.WriteLine("Versuchen Sie die Zahl (1-100) zu erraten: ");

                if (int.TryParse(Console.ReadLine(), out int guess))  //Ich habe "TryParse" auf Stackoverflow gefunden und habe mir es von Chat Gpt erklären lassen und dann verwendet.
                {
                    if (guess >= 1 && guess <= 100)
                    {
                        if (guess == number)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Herzlichen Glückwunsch, Sie haben die Zahl richtig erraten!!");
                            Console.ResetColor();
                            break;
                        }
                        else if (guess > number)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Raten Sie niedriger!!");
                            Console.ResetColor();
                            counter++;
                        }
                        else if (guess < number)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Raten Sie höher!!");
                            Console.ResetColor();
                            counter++;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Die eingegebene Zahl muss zwischen 1 und 100 liegen. Bitte erneut eingeben!!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe!!");
                    Console.ResetColor();
                }
            }
            Console.WriteLine($"Sie haben {counter} Versuche gebraucht! (Die Nummer war: {number}) ");
        }
    }
}
