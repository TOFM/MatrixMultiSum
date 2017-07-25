using System;

namespace MatrixHomeWork1
{
    /* Program for printing the sum of the top-left half matrix values
     * And the multiplication of the top right matrix values
     * Made by TOFM
     * Do not copy
     */
     /*
      * 
      *  OPTIMAZED
      * 
      */
    class Program
    {
        // Seting variables
        public static int size = Int32.Parse(Console.ReadLine());
        public static int[,] abc = new int[size, size];
        // ^^^ Seting the size of the matrix
        public static Random rand = new Random();
        // Summing variables
        public static int sumF = 0;
        public static int sumS = 0;
        //Sum check variables
        public static int howF = 0;
        public static int howS = 0;
        // Multiplication variables
        public static uint prF = 1;
        public static uint prS = 1;
        //Multiplication check variables
        public static int prHowF = 0;
        public static int prHowS = 0;
        //Seting the matrix with random values and printing them(Summing part) and checking
        static int[,] Random(int[,] arr)
        {
            //First check
            for (int j = 0; j < size; j++)
            {
                for (int i = j; i < size; i++)
                {
                    arr[i, j] = rand.Next(1, 10);
                    Console.Write("[{0},{1}] = {2}", i, j, abc[i, j]);
                    sumF += abc[i, j];
                    howF++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum : {0}", sumF);
            Console.WriteLine("Summed {0} elements", howF);
            Console.WriteLine("-------------------------");
            return arr;
        }
        //Functionf for putting random values to array[][] (Multiplication Part) and checking
        static int[,] RandomOne(int[,] arr)
        {
            //First check
            for (int j = size;j < size+2 ; j--)
            {
                if(j == -1)
                {
                    break;
                }
                for (int i = j; i < size ; i++)
                {
                    arr[i , j] = rand.Next(1, 3);
                    Console.Write("[{0},{1}] = {2}", i, j, arr[i, j]);
                    prF *= (uint)arr[i, j];
                    prHowF++;
                }
                Console.WriteLine();   
            }
            Console.WriteLine("Result of * : {0}", prF);
            Console.WriteLine("Mutipli-ed {0} elements", prHowF);
            Console.WriteLine("-------------------------");
            return arr;
        }
        //Main functionality 
        //Suming the values of the matrix diagonal triangle
        //Multiplicationing the values of the second diagonal triangle
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose what you want: ");
            Console.WriteLine("(1)Sum of top left || (2)* of top right");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                //Summ choice
                case 1:
                Random(abc);
                    //Second check
                Console.WriteLine("\\SUMMING PART//");
                Console.WriteLine("Numbers: ");
                for (int j = 0 ; j < size; j++)
                {
                    for (int i = j; i < size; i++)
                    {
                        Console.Write(abc[i, j]);
                        sumS += abc[i, j];
                        howS++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Sum: {0}", sumS);
                Console.WriteLine("Summed {0} elements", howS);
                Console.WriteLine("----------------------------");
                // Starting the third final check
                if ((howF == howS) && (sumF == sumS))
                {
                    Console.WriteLine("Check complete:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The sum is correct!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Check complete:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The sum is incorrect!");
                    Console.ResetColor();
                }
                Console.ReadKey();
                    break;
                    //Multiplication choice
                case 2:
                    RandomOne(abc);
                    //Second check
                    Console.WriteLine("\\MULTIPLICTION PART//");
                    Console.WriteLine("Numbers: ");
                    for (int j = size; j < size + 2; j--)
                    {
                        //Stoping the cycle in the right place DO NOT REMOVE
                        if (j == -1)  {
                            break;
                        }
                        for (int i = j; i < size ; i++)
                        {
                            Console.Write(abc[i, j]);
                            prS *= (uint)abc[i, j];
                            prHowS++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Result of multiplication: {0}", prS);
                    Console.WriteLine("Multiplicated-ed {0} elements", prHowS);
                    Console.WriteLine("----------------------------");
                    // Starting the third final check
                    if ((prHowF == prHowS) && (prF == prS)) {
                        Console.WriteLine("Check complete:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The sum is correct!");
                        Console.ResetColor();
                    } else {
                        Console.WriteLine("Check complete:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The sum is incorrect!");
                        Console.ResetColor();
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}
