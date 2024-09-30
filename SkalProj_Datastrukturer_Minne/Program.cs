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
                char nav = input[0];   //Första index som matas in av användaren
                string value = input.Substring(1).Trim(); //Hela inmatningen från andra index
                Console.WriteLine("Lägga till en person med (+) Ta bort med (-), Avsluta med (0), (h) för huvud meny.");


                switch (nav)
                {
                    //Lägger till listan 
                    case '+':
                        theList.Add(value);
                        break;

                    //Tar bort från listan
                    case '-':

                        if (theList.Contains(value))
                        {
                            theList.Remove(value);
                        }
                        break;

                    //Avslutar programmet
                    case '0':
                        Environment.Exit(0);
                        break;


                     //Användaren väljer att gå till huvud menyn
                    case 'h':
                    case 'H':
                        isAlive = false;
                        break;

                    //En utskriv av programmet ifall användaren matade något som inte stämmer
                    default:
                        Console.WriteLine("Använd endast (+) för att lägga till (-) för att ta bort eller (0) för att avsluta.");
                        break;

                }

                //Skriver ut antal personer i listan
                Console.WriteLine("Antal personer i listan: " + theList.Count);

                //Skriver ut personer i listan
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
                Console.WriteLine("(e) lägger till med Enqueue, (d) tar bort med Dequeue, 'k' för att avsluta, 'h huvud meny");
                inputName = Console.ReadLine(); //Inmatar sträng(namn)
                string inputValue = inputName.Substring(1).Trim(); //Startar från andra tecknet av strängen och tar bort mellanslag
                char letter = inputName[0];  //Första inmatnings värde index

                //Val av funktion av användaren
                switch (letter)
                {
                    case 'e':
                    case 'E':
                        queueListName.Enqueue(inputValue);
                        break;

                    case 'd':
                    case 'D':
                        queueListName.Dequeue();
                        break;

                    case 'h':
                    case 'H':
                        isAlive = false;
                        break;


                    case 'k':
                    case 'K':
                        isAlive = false;
                        break;


                }
                //Skriver ut namn som står kvar i kön
                foreach (string names in queueListName)
                {
                    Console.WriteLine($"Namn {names} kvar i kön");
                }
                Console.WriteLine();

            } while (isAlive);

           

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
                                 " \n(2) För att poppa från stack" +
                                  "\n(3) För att skriva ut alla namn på stack" +
                                 " \n(4) För att få en stäng ömvänd" +
                                 "\n(5) För att avsluta programmet");
                string val = Console.ReadLine();
                string inputStack;

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv en text att lägga till på stacken:");
                        inputStack = Console.ReadLine(); //Inmatning av en sträng
                        stack.Push(inputStack);
                        Console.WriteLine($"{inputStack} har lagts till på stacken.");
                        Console.WriteLine();
                        break;



                    case "2":
                        stack.Pop();  //Poppar värden på toppen av stacken
                        Console.WriteLine();
                        break;

                    case "3":
                        //Skriver ut namnen som är kvar på stacken
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

            //En metod som omvandlar en sträng till en omvänd form
            static void ReverseText(string input)
            {
                Stack stack = new Stack();

                for (int i = 0; i < input.Length; i++)
                {
                    stack.Push(input[i]); //Lägger aktuella indexen på stacken
                }

                Console.WriteLine("Antal bokstäver i strängen: " + stack.Count);

                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(stack.Pop()); //Skriver ut samtidig som poppar från stacken

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
            bool isValid = true;

            while (isValid)
            {
                Stack stack = new Stack();
                Console.WriteLine("Write a text to check if the text is wellformed or not: ");
                string str = Console.ReadLine();

                //Programmet avslutar om ingen text inmatas
                if (string.IsNullOrEmpty(str))
                {
                    isValid = false;
                    break;
                }

                for (int i = 0; i < str.Length; i++)  //Loopen går genom hela strängen
                {
                    char currentIndex = str[i];       //Den akutella index som loopen ska gå genom

                    //Kollar om symbolen finns i strängen
                    if (currentIndex == '(' || currentIndex == '{' || currentIndex == '[')
                    {
                        stack.Push(currentIndex); // Om fångade någon av symbolen så lägger den på stacken
                        Console.WriteLine("Symbol on stack: " + currentIndex);

                    }


                    //Kollar Om det finns bara stängning av symbolen
                    else if (currentIndex == ')' || currentIndex == '}' || currentIndex == ']')
                    {
                        //Om stacken är tom programmet går till nästa körning
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Incorrect forming");
                            isValid = false;
                            break;
                        }

                        //Poppar från stacken
                        char poped = (char)stack.Pop();
                        Console.WriteLine("Poped symbol: " + poped);

                        //Kontrollerar om den stängningssymbolen matchas med den sista öppnade
                        if ((currentIndex == ')' && poped != '(') ||
                           (currentIndex == '}' && poped != '{') ||
                           (currentIndex == ']' && poped != '['))
                        {
                            Console.WriteLine("Incorrect forming");
                            isValid = false;
                            break;
                        }

                    }

                }

                if (isValid)
                {
                    //Kollar om stacken är tom
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Correct forming");
                    }

                    //Det finns öppnade symboler kvar som inte har matchas
                    else
                    {
                        Console.WriteLine("Incorrect forming");
                    }

                }

                //Rensar stacken inför nästa körning
                stack.Clear();
                Console.WriteLine();


            }
        }


    }
}
