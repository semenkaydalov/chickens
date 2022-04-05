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
                            chicken1.peck();
                            chicken1.run();
                            chicken1.printValues();
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