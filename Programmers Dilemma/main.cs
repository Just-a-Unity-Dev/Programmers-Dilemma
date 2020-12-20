using System;

/// TODO
/// Make game
/// if (Console.ReadKey().Key = ConsoleKey.E) {
///
///}
/// 
/// 
/// 
/// 
/// 


namespace Programmers_Dilemma {
    class Introduction {
        public static void Intro_Menu(string[] args) {
            Console.WriteLine("This game is about a Programmer.");
            Console.ReadKey();

            Console.WriteLine("A game about a dilemma.");
            Console.ReadKey();

            Console.WriteLine("The Programmers Dilemma");
            Console.ReadKey();

            Console.WriteLine("Press X to Exit\n Press SPACE to play.\nPress A for Credits and ABOUT");
            if (Console.ReadKey().Key == ConsoleKey.X) {
                Console.WriteLine("Thank you for playing The Programmers Dilemma");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }else if (Console.ReadKey().Key == ConsoleKey.Spacebar) {
                Console.WriteLine("The Programmers Dilemma");
                System.Threading.Thread.Sleep(3000);
                Game.GameIntro();
            } else if (Console.ReadKey().Key == ConsoleKey.A) {
                Console.WriteLine("The Programmers Dilemma");
                System.Threading.Thread.Sleep(3000);
                Game.GameIntro();
            }
        }
        public static void Credits() {
            Console.WriteLine(@"CREDITS
             BLUEHATS/JUST-A-UNITY-DEV - MAIN PROGRAMMER
             ASPRIUS - MAIN WRITER

             MADE IN VS2019
             
             ");
        }
    }

    class Game {
        public static void GameIntro() {

        }
    }
}
