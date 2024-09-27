using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            Console.WriteLine("Adda till listan med att lägga operator(+) i början av namnet, och (-) för att ta bort");

            bool isAlive = true;

            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1).Trim();
                Console.WriteLine("Lägga till en person med (+) Ta bort med (-), Avsluta med (0), (h) för huvud meny.");


                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;

                    case '-':

                        if (theList.Contains(value))
                        {
                            theList.Remove(value);
                        }
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;

                    case 'h':
                    case 'H':
                        isAlive = false;
                        break;

                    default:
                        Console.WriteLine("Använd endast (+) för att lägga till (-) för att ta bort eller (0) för att avsluta.");
                        break;

                }

                Console.WriteLine("Antal personer i listan: " + theList.Count);
                foreach (string name in theList)
                {
                    Console.WriteLine("Person i listan: " + name);
                }
                Console.WriteLine();

            }
            while (isAlive);


        }


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            Queue<string> queueListName = new Queue<string>();
            string inputName;
            bool isAlive = true;

            do
            {
                Console.WriteLine("(e) lägger till med Enqueue, (d) tar bort med Dequeue, 'k' för att avsluta");
                inputName = Console.ReadLine();
                string inputValue = inputName.Substring(1).Trim();
                char letter = inputName[0];
                switch (letter)
                {
                    case 'e':
                        queueListName.Enqueue(inputValue);
                        break;

                    case 'd':
                        queueListName.Dequeue();
                        break;


                    case 'k':
                        isAlive = false;
                        break;


                }

            } while (isAlive);

            foreach (string names in queueListName)
            {
                Console.WriteLine($"Namn {names} kvar i kön");
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack stack = new Stack();

            bool isAlive = true;



            do
            {
                Console.WriteLine("(1) För att pusha ett namn på stack" +
                                 " \n(2) För att pop ett namn från stack" +
                                  "\n(3) För att skriva ut alla namn på stack" +
                                 " \n(4) För att få en stäng ömvänd" +
                                 "\n(5) För att avsluta programmet");
                string val = Console.ReadLine();
                string inputStack;

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv en text att lägga till på stacken:");
                        inputStack = Console.ReadLine();
                        stack.Push(inputStack);
                        Console.WriteLine($"{inputStack} har lagts till på stacken.");
                        Console.WriteLine();
                        break;



                    case "2":
                        stack.Pop();
                        Console.WriteLine();
                        break;

                    case "3":
                        foreach (string item in stack)
                        {
                            Console.WriteLine($"Namn {item} finns på stack: ");

                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        inputStack = Console.ReadLine();
                        ReverseText(inputStack);
                        Console.WriteLine();
                        break;


                    case "5":
                        isAlive = false;
                        break;

                    default:
                        Console.WriteLine("Välj en tal mellan 1 - 5");
                        break;
                }

            } while (true);


            static void ReverseText(string input)
            {
                Stack stack = new Stack();

                for (int i = 0; i < input.Length; i++)
                {
                    stack.Push(input[i]);
                }

                Console.WriteLine("Antal bokstäver i strängen: " + stack.Count);

                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(stack.Pop());

                }

                Console.WriteLine();

            }


        }

        static void CheckParanthesis()
            {
                /*
                 * Use this method to check if the paranthesis in a string is Correct or incorrect.
                 * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
                 * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
                 */

            }

        
    }
}
