using System;
using System.ComponentModel.Design;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Topic_7___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello! Please, pick a program!");
            Console.WriteLine("1. Random Number.");
            Console.WriteLine("2. Vegetables.");
            Console.WriteLine("Anything Else. Leave.");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1) 
            {
                Console.WriteLine("Okay, taking you to the random numbers.");
                Thread.Sleep(200);
                Console.WriteLine("Loading...");
                Thread.Sleep(333);
                Numbers();
            }

            if (choose == 2)
            {
                Console.WriteLine("Okay, taking you to the vegetables.");
                Thread.Sleep(200);
                Console.WriteLine("Loading...");
                Thread.Sleep(333);
                Veggies();
            }

            else
            {
                Console.WriteLine("Okay, see you later.");
            }
            
        }
        

        public static void Numbers() 
        {
            {
                int sum = 0;
                int large = 20;
                int small = 10;
                int numb;
                Random Generator = new Random();
                List<int> numbers = new List<int>();
                double divide = numbers.Count;
                Console.WriteLine("I have a list of random numbers right here.");

                string choice = "";
                while (choice != "q")
                {


                    
                    Console.Clear();
                    Console.WriteLine();
                    for (int i = 0; i < 25; i++)
                    {
                        numb = Generator.Next(10, 21);
                        Console.Write(numb + ", ");
                        numbers.Add(numb);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Hello! What would you like to do with the list of random numbers?");
                    Console.WriteLine("1 - Sort the list.");
                    Console.WriteLine("2 - Make a new list.");
                    Console.WriteLine("3 - Remove a number.");
                    Console.WriteLine("4 - Add a value.");
                    Console.WriteLine("5 - Count the number of a specified value.");
                    Console.WriteLine("6 - Print the largest value.");
                    Console.WriteLine("7 - Print the smallest value.");
                    Console.WriteLine("8 - Print the sum and average of each value.");
                    Console.WriteLine("Q - Quit");

                    choice = Console.ReadLine().ToUpper().Trim();


                    if (choice == "1")
                    {
                        Console.WriteLine("Okay, sorting list, now.");
                        Thread.Sleep(2180);
                        Console.WriteLine("Loading...");
                        Thread.Sleep(802);
                        numbers.Sort();


                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.Sort();
                            Console.Write(numbers[i] + ", ");

                        }
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }

                    else if (choice == "2")
                    {
                        Console.WriteLine("Okay, rerolling the list.");
                        Thread.Sleep(2500);
                        Console.WriteLine("Loading...");
                        Thread.Sleep(603);
                        Console.WriteLine("Okay, here it is.");
                        Thread.Sleep(500);
                        for (int i = 0; i < 25; i++)
                        {
                            numb = Generator.Next(10, 21);
                            Console.WriteLine(numb);
                            numbers.Add(numb);
                            Thread.Sleep(400);

                        }
                    }

                    else if (choice == "3")
                    {
                        Console.WriteLine("Please give me a number to remove.");
                        int numberPick;
                        while (!Int32.TryParse(Console.ReadLine(), out numberPick) || numberPick < 10 || numberPick > 20)
                        {
                            Console.WriteLine("Please input a valid number.");
                        }




                        while (numbers.Contains(numberPick))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {

                                if (numbers[i] == numberPick)
                                {
                                    numbers.Remove(numbers[i]);
                                    numbers.Sort();
                                }


                            }


                        }

                        foreach (int number in numbers)
                        {
                            Console.Write(number + ", ");
                        }
                        Console.ReadLine();

                    }


                    else if (choice == "4")
                    {
                        Console.WriteLine("Please give me a value you would like to add to the list.");
                        int numberPick, numbCount = 0;
                        while (!Int32.TryParse(Console.ReadLine(), out numberPick) || numberPick < 10 || numberPick > 20)
                        {
                            Console.WriteLine("Please input a valid number.");
                            string name = Console.ReadLine();
                            for (int i = 0; i < 1; i++)
                            {
                                int numbe = Convert.ToInt32(Console.ReadLine());
                                numbers.Add(numbe);
                            }

                        }





                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine("Please give me a number to find.");
                        int numberPick, numbCount = 0;
                        while (!Int32.TryParse(Console.ReadLine(), out numberPick) || numberPick < 10 || numberPick > 20)
                        {
                            Console.WriteLine("Please input a valid number.");
                        }


                        for (int i = 0; i < numbers.Count; i++)
                        {

                            if (numbers[i] == numberPick)
                            {
                                numbCount++;


                            }
                        }


                        Console.WriteLine($"The number you have chosen, {numberPick}, shows up a total of {numbCount} times.");
                        Console.ReadLine();
                    }

                    else if (choice == "6")
                        
                    {
                        
                        foreach (int number in numbers)
                        {
                            
                            if (number < large)
                            {
                                large = number; 

                            }
                            
                        }
                        Console.WriteLine($"The largest number is {large}.");
                        Console.ReadLine();
                    }

                    else if (choice == "7")
                    {
                        small = 20;
                        foreach (int number in numbers)
                        {

                            if (number > small)
                            {
                                
                                small = number;

                            }
                        }
                        Console.WriteLine($"The smallest number is {small}.");
                        Console.ReadLine();


                    }

                    else if (choice == "8")
                    {

                        foreach (int number in numbers)
                        {
                            sum += number;
                        }

                        Convert.ToDouble(sum);


                        Console.WriteLine($"The sum is {sum}, and the sum is {sum / divide}");
                        Console.ReadLine();
                    }

                }
            }

        }

        public static void Veggies()
        {
            List<string> vegetables = new List<string>() {"CARROT", "LETTUCE", "RADISH", "MUSHROOM", "CELERY" };

           string choice = "";
            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine();
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {vegetables[i]}");
                    Console.WriteLine();

                }
                Console.WriteLine("Hello! What would you like to do with the list vegetables?");
                Console.WriteLine("1 - Remove a vegetable (By index).");
                Console.WriteLine("2 - Remove a vegetable (By name).");
                Console.WriteLine("3 - Search for a vegetable.");
                Console.WriteLine("4 - Add a vegetable.");
                Console.WriteLine("5 - Sort List.");
                Console.WriteLine("6 - Clear List.");
                Console.WriteLine("Q - Quit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    int remove;
                    Console.WriteLine("which vegetable would you like to destroy?");
                    while (!Int32.TryParse(Console.ReadLine(), out remove))
                    {
                        Console.WriteLine("Please input a valid number.");
                    }
                    if (remove == 0)
                    {
                        Console.WriteLine("Removing fis- Hey wait a minute... That isn't a vegetable!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Okay, removing {vegetables[remove]}");
                        vegetables.RemoveAt(remove);
                        

                    }

                }


                if (choice == "2")
                {
                    string name;
                    Console.WriteLine("Please give me a name.");
                    name = Console.ReadLine();
                    if (name == vegetables[1])
                    {
                        Console.WriteLine($"Okay, removing {vegetables[1]}.");
                    }
                    vegetables.RemoveAt(1);
                    for (int i = 1; i < vegetables.Count; i++)
                    {
                        Console.WriteLine(i + ", " + vegetables[i]);


                    }
                    Console.ReadLine();

                    if (name == vegetables[2])
                    {
                        Console.WriteLine($"Okay, removing {vegetables[2]}.");
                    }
                    vegetables.RemoveAt(1);
                    for (int i = 1; i < vegetables.Count; i++)
                    {
                        Console.WriteLine(i + ", " + vegetables[i]);


                    }
                    Console.ReadLine();

                    if (name == vegetables[3])
                    {
                        Console.WriteLine($"Okay, removing {vegetables[3]}.");
                    }
                    vegetables.RemoveAt(1);
                    for (int i = 1; i < vegetables.Count; i++)
                    {
                        Console.WriteLine(i + ", " + vegetables[i]);


                    }
                    Console.ReadLine();
                    if (name == vegetables[4])
                    {
                        Console.WriteLine($"Okay, removing {vegetables[4]}.");
                    }
                    vegetables.RemoveAt(1);
                    for (int i = 1; i < vegetables.Count; i++)
                    {
                        Console.WriteLine(i + ", " + vegetables[i]);


                    }
                    Console.ReadLine();
                    if (name == vegetables[5])
                    {
                        Console.WriteLine($"Okay, removing {vegetables[5]}.");
                    }
                    vegetables.RemoveAt(1);
                    for (int i = 1; i < vegetables.Count; i++)
                    {
                        Console.WriteLine(i + ", " + vegetables[i]);


                    }
                    Console.ReadLine();
                }

                if (choice == "3")
                {
                    Console.WriteLine("Which vegetable would you like to search for today?");

                    string search = Console.ReadLine();

                    if (search != "carrot" || search != "CARROT" || search != "lettuce" || search != "LETTUCE" || search != "radish" || search != "RADISH" || search != "mushroom" || search != "MUSHROOM" || search != "celery" || search != "CELERY") 
                    { 
                      Console.WriteLine("I'll just assume you could not type, so here, have a fish. (:");
                      Console.WriteLine("His name is Finland. (:");
                        Console.WriteLine("      _____");
                        Console.WriteLine("|\\   /     \\");
                        Console.WriteLine("| \\_/ .   . \\");
                        Console.WriteLine("|  _     O   |");
                        Console.WriteLine("| / \\       /");
                        Console.WriteLine("|/   \\_____/");
                    }

                    if (search == vegetables[1] || search == "carrot")
                    { 
                    Console.WriteLine($"I have found the vegetable. It is the carrot, and has the index of 1.");
                    }

                    if (search == vegetables[2] || search == "lettuce")
                    {
                        Console.WriteLine($"I have found the vegetable. It is the lettuce, and has the index of 2.");
                    }

                    if (search == vegetables[3] || search == "raddish")
                    {
                        Console.WriteLine($"I have found the vegetable. It is the radish, and has the index of 3.");
                    }

                    if (search == vegetables[4] || search == "mushroom")
                    {
                        Console.WriteLine($"I have found the vegetable. It is the mushroom, and has the index of 4.");
                    }

                    if (search == vegetables[5] || search == "celery")
                    {
                        Console.WriteLine($"I have found the vegetable. It is the lettuce, and has the index of 5.");
                    }
                }
               
                if (choice == "4")
                {
                    bool match = true;

                    Console.WriteLine("Please give me a vegetable to add.");
                    string add = Console.ReadLine().ToUpper().Trim();
                    

                    foreach (string vegetable in vegetables)
                    {

                        if (add == vegetable) 
                        {
                            match = false;
                        }

                        if (add != vegetable) 
                        {
                            match = true;
                        }
                    
                    }
                    
                    if (match = true) 
                    {
                        vegetables.Add(add);
                        Console.WriteLine("K");

                    }
                    if (match = false)
                    {
                        Console.WriteLine("I'm sorry, but that is already in the list.");
                        Console.ReadLine();

                    }


                    if (add == "FISH") 
                    {
                        Console.WriteLine("Fish, what fish?");
                    }

                }
                if (choice == "5")
                {
                    Console.WriteLine("Okay, sorting list.");
                    vegetables.Sort();
                
                }

                if (choice == "6")
                {
                    Console.WriteLine("Clearing list.");
                    vegetables.Clear();

                }
            }

        }
    }
}