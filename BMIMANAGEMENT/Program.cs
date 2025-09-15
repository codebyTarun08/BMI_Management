using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIMANAGEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BmiManagement manager = new BmiManagement();

            Console.WriteLine("No of Objects for Person");
            string PersonNoInput = Console.ReadLine();
            int noOfPerson = Convert.ToInt32(PersonNoInput);


            for (int i = 0; i < noOfPerson; i++)
            {
                Console.WriteLine("Name of Person: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Weight of Person: ");
                string Weight = Console.ReadLine();
                Console.WriteLine("Height of Person: ");
                string Height = Console.ReadLine();
                double W = double.Parse(Weight);
                double H = double.Parse(Height);
                manager.personList.Add( new Person(Name, W, H));
            }

            while (true)
            {
                Console.WriteLine("*** Choose the Option ***\n" +
                    "1.Choice1 : A\n" +
                    "2.Choice2 : B\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "A":
                           Console.WriteLine("Enter the status");
                           string status= Console.ReadLine();
                            List<Person> pers = manager.Enquire(status);
                            if(pers.Count == 0)
                            {
                                Console.WriteLine("There are no Person Found.");
                            }
                            else
                            {
                                foreach(var p in pers)
                                {
                                    Console.WriteLine($"{p.Name}:{p.Weight}:{p.Height}");
                                }  
                            }
                            break;
                    case "B":
                        Console.WriteLine(manager.AverageWeight());
                        break;
                    default: 
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }

        }
    }
}
