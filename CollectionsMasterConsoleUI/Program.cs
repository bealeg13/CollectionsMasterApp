using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] myArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray, 0, 50);


            //TODO: Print the first number of the array
            Console.WriteLine($"The first number in the array is {myArray[0]}");

            //TODO: Print the last number of the array            
            Console.WriteLine($"The last number in the array is {myArray[49]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */



            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(myArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"The current capacity of the list is {myList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList, 50, 0, 50);

            //TODO: Print the new capacity
            Console.WriteLine($"The new capacity of the list is {myList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(myList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            foreach (int num in myList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            //numberList = numberList.Where(num => num % 2 == 0).ToList();
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }

            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
                                       
        }

        private static void NumberChecker(List<int> numberList)
        {   int userNumber = int.Parse(Console.ReadLine());
            int searchNumber = numberList.IndexOf(userNumber);
             
            {
                if (searchNumber != -1)
                {
                    Console.WriteLine($"The number {userNumber} is in the list");
                }
                else
                {
                    Console.WriteLine($"The number {userNumber} is not in the list");
                }
            }
        }

        private static void Populater(List<int> numberList, int count, int minValue, int maxValue)
        {
            Random rng = new Random();

            for ( int i = 0; i < count; i++)
            {
                numberList.Add(rng.Next(minValue, maxValue + 1));
            }
            foreach(int num in numberList)
            {
                Console.WriteLine(num);
            }
        }

        private static void Populater(int[] numbers, int minValue, int maxValue)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(minValue, maxValue + 1);

            }
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
