using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_2._1300
{
    public class GameMenu
    {
        public void Start()
        {

            string titel = @"
                  _____      _ _    _       _   _                 _                                                  
                 | ____|_ __(_) | _( )___  | \ | |_   _ _ __ ___ | |__   ___ _ __ __ _ _   _  ___  ___ ___  ___ _ __ 
                 |  _| | '__| | |/ /// __| |  \| | | | | '_ ` _ \| '_ \ / _ \ '__/ _` | | | |/ _ \/ __/ __|/ _ \ '__|
                 | |___| |  | |   <  \__ \ | |\  | |_| | | | | | | |_) |  __/ | | (_| | |_| |  __/\__ \__ \  __/ |   
                 |_____|_|  |_|_|\_\ |___/ |_| \_|\__,_|_| |_| |_|_.__/ \___|_|  \__, |\__,_|\___||___/___/\___|_|   
                                                                                 |___/                               
            ";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(titel);
            Console.ResetColor();

            string antwort;
            NumberGuessingGame game = new NumberGuessingGame();

            do
            {
                while (true)
                {
                    Console.Write("Wollen Sie spielen (j/n): ");
                    antwort = Console.ReadLine();
                    if (antwort == "j" || antwort == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe!!");
                        Console.ResetColor();
                    }
                }

                if (antwort == "j")
                {
                    game.Play();
                }

                while (true)
                {
                    Console.Write("Wollen Sie nochmals spielen (j/n)? ");
                    antwort = Console.ReadLine();
                    if (antwort == "j" || antwort == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe!!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            } while (antwort == "j");
        }
    }
}
