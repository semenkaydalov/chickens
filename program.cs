using System;
using System.Collections.Generic;

namespace program {

    class Program {
        
        static void Main() {

            string x = "y";
            while (x == "y") {  
                System.Console.Write("Do you want create somebody? (y/n) ");

                x = Console.ReadLine()!;
                if (x == "y") {
                    System.Console.Write("Who you want to create? (chick/chicken) ");
                    string who = Console.ReadLine()!;

                    if (who == "chick") {
                        byte[] coordinates = new byte[3];

                        System.Console.Write("Enter name: ");
                        string name = Console.ReadLine()!;

                        try {
                            System.Console.Write("Enter weight: ");
                            int weight = Convert.ToInt16(Console.ReadLine());

                            System.Console.WriteLine("Enter coordinates: ");
                            for (int i = 0; i < coordinates.Length; i++) {
                                coordinates[i] = Convert.ToByte(Console.ReadLine());
                            }

                            chick chick1 = new chick(name, weight, coordinates);
                            System.Console.WriteLine("-----------------------");  
                            chick1.printValues();    
                        }
                        catch (FormatException) {
                            System.Console.WriteLine("Wrong format!");
                        }

                    }   
                    else if (who == "chicken") {
                        byte[] coordinates = new byte[3];

                        System.Console.Write("Enter name: ");
                        string name = Console.ReadLine()!;

                        try {
                            System.Console.Write("Enter weight: ");
                            int weight = Convert.ToInt16(Console.ReadLine());
                        
                            System.Console.Write("Enter color: ");
                            string color = Console.ReadLine()!;

                            System.Console.WriteLine("Enter coordinates: ");
                            for (int i = 0; i < coordinates.Length; i++) {
                                coordinates[i] = Convert.ToByte(Console.ReadLine());
                            }

                            chicken chicken1 = new chicken(name, weight, color, coordinates);
                            System.Console.WriteLine("-----------------------");
                            chicken1.printValues();

                            System.Console.Write("Do you want to feed {0}? (y/n) ", chicken1.Name);
                            string food = Console.ReadLine()!;
                            if (food == "y") {
                                System.Console.WriteLine("Let's choose food for {0}!", chicken1.Name);
                                System.Console.Write("Type name of your feed: ");
                                string feedname = Console.ReadLine()!;
                                System.Console.Write("Choose the stimulus of your feed (0-10): ");
                                int stimulant = Convert.ToInt16(Console.ReadLine());
                                System.Console.Write("Choose the nutritional value of your food (0-10): ");
                                int satiety = Convert.ToInt16(Console.ReadLine());
                                feed feed1 = new feed(); 
                                feed1.setValues (feedname, stimulant, satiety);
                                feed1.printValues();
                                System.Console.WriteLine("Your chicken has eaten!");
                            }

                            System.Console.WriteLine("-----------------------");

                            System.Console.Write("Do you want to peck your chick? (y/n) ");
                            string pecking = Console.ReadLine()!;
                            if (pecking == "y") {
                                chicken1.peck();
                            }
                            System.Console.WriteLine("-----------------------");
                            System.Console.Write("Do you want to run? (y/n) ");
                            string running = Console.ReadLine()!;
                            if (running == "y") {
                                chicken1.run();
                            }
                            chicken1.printCoordinates();
                        }
                        catch (FormatException) {
                            System.Console.WriteLine("Wrong format!");
                        }

                    }
                    
                    else {
                    System.Console.WriteLine("Animal is unrecognized!");
                    }

                }

            }

        }

    }

}