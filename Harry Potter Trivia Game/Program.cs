using System;

namespace Harry_Potter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counter for number of guesses 
            int totalCorrect = 0;

            Console.WriteLine("Welcome to the \"Harry Potter Trivia\"!! \nPlease enter your name:");
            string contestant = Console.ReadLine();
            Console.WriteLine("\nHere are the rules:");
            Console.WriteLine("1. All answers will be given using the numbers 1-4.");
            Console.WriteLine("2. NO magic is allowed during the exam!");
            Console.WriteLine("3. Ensure you have fun!");
            Console.WriteLine("Lets get started!");
            string house = House("\nThe Sorting Hat wants to know who you belong too!");
            Console.WriteLine($"Ok {contestant}, here is Question 1...");


            //Question 1

            string TriWizardAnswer = TriWizardTournamentQuestion();


            if (TriWizardAnswer == "Correct")
            {
                totalCorrect++;
                Console.WriteLine($"That's right! One point to {house}!! Moving on.\n");
            }
            else
            {
                Console.WriteLine($"Sorry {contestant}. That was not the correct answer... Next question... \n");
            }


            //Question 2

            string orderOfThePheonixAnswer = OrderOfThePheonixQuestion();

            if (orderOfThePheonixAnswer == "Correct")
            {
                totalCorrect++;
                Console.WriteLine($"Correct! Magnificent answer {contestant}! Next question is...\n");
            }
            else
            {
                Console.WriteLine($"Close but not just not that close... Next question! \n");
            }


            //Question 3
            //Boolean method called to return true or false 

            bool HarryLoveLifeAnswer = HarryLoveLifeQuestion();


            if (HarryLoveLifeAnswer == true)
            {
                totalCorrect++;
                Console.WriteLine($"Bingo! Good job! {totalCorrect} questions right! Here's another.\n");
            }
            else
            {
                Console.WriteLine($"So close! But that point goes to the other House! Next question.\n");
            }

            //Question 4
            //uint method called

            uint KingsCrossAnswer = KingsCrossQuestion();

            if (KingsCrossAnswer == 1)
            {
                totalCorrect++;
                Console.WriteLine($"Another point to {house}! Final question...\n");

            }
            else
            {
                Console.WriteLine($"Thats not right... Are you sure you aren't a muggle? Final question!\n");
            }


            // Question 5
            //string array method called

            string WeasleyTwinsAnswer = WeasleyTwinsQuestion();

            if (WeasleyTwinsAnswer == "Correct")
            {
                totalCorrect++;
                Console.WriteLine($"That is correct! Final point to {contestant}, House {house}!\n");
            }
            else
            {
                Console.WriteLine($"No more points for {house}!\n");
            }

            Console.WriteLine($"Finished Quiz.");
            Console.WriteLine($"Score: {totalCorrect} out of 5.");
        }


        //Start of Methods
        private static string House(string userInput)
        {
            Console.WriteLine(userInput);
            Console.WriteLine("1. The Courageous Godric Gryffindor");
            Console.WriteLine("2. The Loyal Helga Hufflepuff");
            Console.WriteLine("3. The Intelligent Rowena Ravenclaw");
            Console.WriteLine("4. The Cunning Salazar Slytherin");
            string house = Console.ReadLine();

            {
                if (house == "1")
                {
                    Console.WriteLine("All Hail Gryffindor!\n");
                    house = "Gryffindor";
                }
                else if (house == "2")
                {
                    Console.WriteLine("All Hail Hufflepuff!\n");
                    house = "Hufflepuff";
                }
                else if (house == "3")
                {
                    Console.WriteLine("All Hail Ravenclaw!\n");
                    house = "Ravenclaw";
                }
                else if (house == "4")
                {
                    Console.WriteLine("All Hail Slytherin!\n");
                    house = "Slytherin";
                }
                else
                {
                    Console.WriteLine("\nThat was not an option...");
                    House("Choose again");
                }
            }
            return house;

        }

        //Question 1    
        static string TriWizardTournamentQuestion()
        {
            int answer = 0;
            Console.WriteLine("How does Harry manage to breathe underwater during the second task of the Triwizard Tournament?");
            Console.WriteLine("1. He transfigures into a shark");
            Console.WriteLine("2. He kisses a mermaid");
            Console.WriteLine("3. He eats gillyweed");
            Console.WriteLine("4. He performs a bubble-head charm");

            while (answer <= 0 || answer > 4)
            {
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                }
                if (answer < 1 || answer > 4)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }
            }

            if (answer != 3)
            {
                return "Incorrect";
            }

            return "Correct";
        }

        //Question 2
        static string OrderOfThePheonixQuestion()
        {
            int answer = 0;
            Console.WriteLine("Who is NOT a member of the Order of the Phoenix?");
            Console.WriteLine("1. Cornelius Fudge");
            Console.WriteLine("2. Mad-eye Moody");
            Console.WriteLine("3. Professor Snape");
            Console.WriteLine("4. Remus Lupin");

            while (answer <= 0 || answer > 4)
            {
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                }
                if (answer < 1 || answer > 4)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }
            }

            if (answer != 1)
            {
                return "Incorrect";
            }

            return "Correct";

        }

        //Question 3
        private static bool HarryLoveLifeQuestion()
        {
            int check = 0;
            string check2;
            Console.WriteLine("True or False: Harry Potter marries Hermoine Granger.");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");

            while (check <= 0 || check > 2)
            {
                try
                {
                    check = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                }
                if (check < 1 || check > 2)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }
            }
            check2 = Convert.ToString(check);


            switch ((check2))
            {
                case "1":
                    {
                        return false;
                    }
                case "2":
                    {
                        return true;
                    }
                default: 
                    {
                        return false;
                    }
            }
        }

        //Question 4
        static uint KingsCrossQuestion()
        {
            uint answer = 0;
            Console.WriteLine("From what King’s Cross platform does the Hogwarts Express leave?");
            Console.WriteLine("1. 8 1/4");
            Console.WriteLine("2. 9 3/4");
            Console.WriteLine("3. 5 1/2");
            Console.WriteLine("4. 11");

            while (answer <= 0 || answer > 4)
            {
                try
                {
                    answer = Convert.ToUInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                   
                }
                if (answer < 1 || answer > 4)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }
            }

            if (answer == 2)
            {
                return 1;
            }
            else 
            {
                return 2;
            }

        }

        // Question 5 
        static string WeasleyTwinsQuestion()
        {
            int check = 0;
            int check2 = 0;
            Console.WriteLine("What are the names of the two Weasley boys?");
            string[] nameArray = { "1. Fred", "2. Ron", "3. George", "4. Bill" };

            foreach (string name in nameArray)
            {
                System.Console.WriteLine($"{name}");
            }

            Console.WriteLine("\nThe first twin is...");
            while (check <= 0 || check > 4)
            {
                try
                {
                    check = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                }
                if (check < 1 || check > 4)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }
            }

            Console.WriteLine("The second twin is...");
            while (check2 <= 0 || check2 > 4)
            {
                try
                {
                    check2 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                }
                if (check2 < 1 || check2 > 4)
                {
                    Console.WriteLine("\nThat was not an option...");
                    Console.WriteLine("Enter your answer again...");
                }

            }

            if ((check != 1 && check != 3) && (check2 != 3 && check2 != 1))
            {
                return "Incorrect";
            }
            return "Correct";

        }
    }
}
