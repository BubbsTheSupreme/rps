using System;
using System.Collections.Generic;

namespace rps
{
    class Program {
        static void Main(string[] args){
            var _CPU_ = new List<string> { "Rock", "Paper", "Scissors" };
            Random num = new Random();
            Console.WriteLine("type q or Q to quit");
            while(true){
                Console.Write("Rock, Paper, Scissors: ");
                string choice = Console.ReadLine();
                int rand = num.Next(0,3);
                var CPU_CHOICE = _CPU_[rand];
                if(choice == "Rock" || choice == "rock"){
                    switch(CPU_CHOICE) {
                        case "Rock":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("DRAW..");
                            break;
                        case "Paper":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU LOSE!..");
                            break;
                        case "Scissors":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU WIN!!");
                            break;
                    }
                }
                if(choice == "Paper" || choice == "paper"){
                    switch(CPU_CHOICE) {
                        case "Rock":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU WIN!!");
                            break;
                        case "Paper":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("DRAW..");
                            break;
                        case "Scissors":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU LOSE!..");
                            break;
                    }
                }
                if(choice == "Scissors" || choice == "scissors"){
                    switch(CPU_CHOICE) {
                        case "Rock":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("DRAW..");
                            break;
                        case "Paper":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU LOSE!..");
                            break;
                        case "Scissors":
                            Console.WriteLine($"CPU chose {CPU_CHOICE}");
                            Console.WriteLine("YOU WIN!!");
                            break;
                    }
                }
                if(choice == "q" || choice == "Q"){
                    break;
                }
                else{
                    Console.WriteLine("Please enter a valid input..");
                }
            }
        }
    }
}
