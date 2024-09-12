using System.Collections.Generic;

namespace task.n._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numpers = new();
            string selection = " ";
            do
            {
                      Console.WriteLine("                    -------------------------------------- ");
                      Console.WriteLine($"                   | P - Print numbers: {Numpers.Count}                 |");
                      Console.WriteLine("                   | A - Add a number                     |");
                      Console.WriteLine("                   | M - Display mean of the numbers      |");
                      Console.WriteLine("                   | S - Display the smallest number      |");
                      Console.WriteLine("                   | L - Display the largest number       |");
                      Console.WriteLine("                   | C - clear the list                   |");
                      Console.WriteLine("                   | Q - Quit                             |");
                      Console.WriteLine("                   | Enter your choice:                   |");  
                      Console.WriteLine("                    -------------------------------------- ");

                selection = (Console.ReadLine());
                 
                switch (selection)
                {
                    case "P":
                    case "p":
                        if (Numpers.Count != 0 || Numpers.Count < 0)
                        {
                            Console.WriteLine("the list is: ");
                            Console.Write("[");
                            for (int i = 0; i < Numpers.Count; i++)
                            {
                                Console.Write(" " + Numpers[i] + " ");
                            }
                            Console.Write("]");
                            Console.WriteLine();
                        }
                        else if (Numpers.Count == 0)
                            Console.WriteLine("the list is emty");
                        break;

                    case "a":
                    case "A":
                        Console.Write("please add numper: ");
                        int NumperAdded = int.Parse(Console.ReadLine());
                        bool num = false;
                        for (int i = 0; i < Numpers.Count; i++)
                        {
                            if (NumperAdded == Numpers[i])
                            {
                                num = true;
                            }
                        }
                        if (num)
                            Console.WriteLine("alredy in list");
                        else
                        {
                            Console.WriteLine($"{NumperAdded} is added");
                            Numpers.Add(NumperAdded);
                        }
                        break;

                    case "M":
                    case "m":
                        if  (Numpers.Count != 0)
                        {
                            Console.WriteLine("the main avarge of list is: ");
                            double total = Numpers.Sum();
                            Console.WriteLine(total / Numpers.Count);
                        }
                        else if (Numpers.Count == 0)
                            Console.WriteLine("the list is emty"); 
                        break;

                    case "s":
                    case "S":

                        if (Numpers.Count == 0)
                        {
                            Console.WriteLine("the list is emty");
                        }
                        else
                        {
                            int small = Numpers[0];
                            for (int i = 0; i > Numpers.Count; i++)
                            {
                                if (small > Numpers[i])
                                    small = Numpers[i];
                            }
                            Console.WriteLine($"the smallest nemper is : ({small})");
                        }
                        break;

                    case "L":
                    case "l":

                        if (Numpers.Count == 0)
                        {
                            Console.WriteLine("the list is emty");
                        }
                        else
                        {
                            int large = Numpers[0];
                            for (int i = 0; i < Numpers.Count; i++)
                            {
                                if (large < Numpers[i])
                                    large = Numpers[i];
                            }
                            Console.WriteLine($"the smallest nemper is : ({large})");
                        }
                        break;

                    case "q":
                    case "Q":
                        Console.WriteLine("good bye");
                        break;

                    case "c":
                    case "C":
                        if (Numpers.Count == 0)
                            Console.WriteLine("the list is emty");
                        else
                        Numpers.Clear();
                        break;

                    default:

                        Console.WriteLine("UNKNOWN CHOISE");
                        break;
                }
            } while (selection != "Q" && selection != "q");
        }
    }
}
