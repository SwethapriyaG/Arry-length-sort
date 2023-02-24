using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 40;
            int test1 = 60;
            string num;
            num = "20";
            string num1;
            num1 = "21"; 

            //test1 = 60;
            //string userInput = Console.ReadLine();
            //Console.WriteLine(test);
            
            //if (userInput =="Y") 
            //{
            //    test1 = 100;
            //}
            //else
            //{
            //    test1 = 200;
            //}
            Console.WriteLine("+ arithamatic oparator :" + (test+test1));
            if (test != test1)
            {
                Console.WriteLine("The variable test : " + test + " is not equal to the variable test1 : " + test1);
            }
            Console.WriteLine("- arithamatic oparator :" + (test1 - test));
            Console.WriteLine("* arithamatic oparator :" + (test * test1));
            Console.WriteLine("% arithamatic oparator :" + (test1 % test));
            Console.WriteLine("/ arithamatic oparator :" + (test / test1));
            if (test <= test1)
            {
                Console.WriteLine("Test is less than or equal to test1");
            }
            else
            {
                Console.WriteLine("Test is grater than test1");
            }
            if (test1 >= test)
            {
                Console.WriteLine("Test1 is : " + test1);
            }
            else
            {
                Console.WriteLine(" Test value is: " + test);
            }
            if (test<test1)
            {
                Console.WriteLine("< compariton oparator: " + test1);
            }
            else
            {
                Console.WriteLine("< comparation oparator: " + test);
            }
            if (test > test1)
            {
                Console.WriteLine("> comparation oparator: " + test1);
            }
            else
            {
                Console.WriteLine("> comparation oparator: " + test);
            }
            Console.WriteLine("String concatination:" + (num + num1));

            Console.WriteLine("for loop: ");
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("while loop: ");
            int k = 0;
            while (k < 5 )
            {
                k++;
                Console.WriteLine(k);
            }
            Console.WriteLine("do while:");
            int y = 0;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y < 6);

            Console.WriteLine("\nforeach loo:");
            string[] names = { "Swetha", "Saritha", "Dheepika" };
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            names[0] = "Swethapriya";
            Console.WriteLine("\nChanging first element in arrya:" + names[0]);
            Console.WriteLine("\nPrinting arry with for loop:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("\nLenth of the arry: " + names.Length);
            Console.WriteLine("\nSorting string arry elements:");
            String[] fruits = { "Banana", "Graps", "Apple", "Straberry" };
            Array.Sort(fruits);
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sorting int arry elements:");
            int[] numList = { 5, 6, 3, 8, 2, 9, 7, 4, 1, 10 };
            Array.Sort(numList);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
