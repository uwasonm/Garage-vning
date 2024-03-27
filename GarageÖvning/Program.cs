using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GarageÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage  g=new Garage();

            int option = 1;
            do
            {
                int choice = 0;
                try
                {
                    Console.WriteLine("Enter your choice: 1 for parking, 2 for leaving the parking,or 0 for exiting the application");//to add an error     message if not 0,1,2 is entered
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                { 
                    Console.WriteLine("Please provide a valid input (0, 1, or 2)");
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Parking a vehicle!");

                            string name = "nothing yet";
                            string numberplate = "nothing yet";
                            string plate = string.Empty;
                            string color = string.Empty;
                            int wheels = 0;
                            

                            Console.WriteLine("Enter the name: ");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter the numberplate: ");
                            plate = Console.ReadLine();
                            numberplate = plate.ToUpper();

                            Console.WriteLine("Enter the color: ");
                            color = Console.ReadLine();

                            Console.WriteLine("Enter the number of wheels ");
                            wheels = int.Parse(Console.ReadLine());

                            Vehicle newvehicle = new Vehicle(name, numberplate, color, wheels);
                            g.ParkedVehicles.Add(newvehicle);
                            printList(g);
                            break;
                        }

                    case 2:
                        {
                           Console.WriteLine("A vehicle is leaving");

                            try
                            {
                                printList(g);
                                Console.WriteLine("Choose the number of the leaving vehicle as per the list above: ");//to improve using number plate as it is a unique identifier 
                                int vehicleNumber = int.Parse(Console.ReadLine());
                            
                        g.ParkedVehicles.Remove(g.ParkedVehicles[vehicleNumber]);
                        g.LeavingVehicles.Add(g.ParkedVehicles[vehicleNumber]);

                        printList(g);
                        Console.WriteLine();
                        printLeavingVehicle(g);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Only numbers are allowed!");
                            }

                            catch ( ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Please provide a valid input from the list");
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        Console.WriteLine("Please provide a valid input (0, 1,or 2)");
                        //return option;
                        break;
                }
            }
            while (option != 0);
        }

        private static void printLeavingVehicle(Garage g)
        {
            Console.WriteLine(" Vehicle(s) that have left are:");
            for (int i = 0; i < g.LeavingVehicles.Count; i++)

            { Console.WriteLine(i + ". Vehicle: " + g.ParkedVehicles[i]); }
        }

        private static void printList(Garage g)
        {
            Console.WriteLine(" Vehicle(s) in the garage are:");
            for (int i = 0;i<g.ParkedVehicles.Count;i++) 
            {  Console.WriteLine(i +". Vehicle: " + g.ParkedVehicles[i]); }
            Console.WriteLine();
        }
    }
}
