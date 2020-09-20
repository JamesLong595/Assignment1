using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Fall20
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a triangle of arbitary height
            while (true)
                try
                {
                    Console.WriteLine("Enter the height of the triangle:");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        PrintTriangle(n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a positive integer.");
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer.");
                } // end of catch block

            // print an arbitrary-length series of odd numbers and its sum
            while (true)
                try
                {
                    Console.WriteLine("Enter the number of terms in the series:");
                    int n2 = int.Parse(Console.ReadLine());
                    if (n2 > 0)
                    {
                        PrintSeriesSum(n2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a positive integer.");
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer.");
                } // end of catch block

            // determine the monotonicity of a list and print the findings 
            while (true)
            {
                try
                {
                    // initialize the list
                    List<int> A = new List<int>();
                    // optionally collect list data from user
                    Console.WriteLine("Enter the size of the list or enter \"0\" to accept the default list:");
                    string input = Console.ReadLine();
                    int lstSize = int.Parse(input);
                    // validate input
                    if (lstSize < 0)
                    {
                        Console.WriteLine("\nPlease enter a positive integer or \"0\".");
                    }
                    // proceed with valid input
                    else if (lstSize == 0)
                    {
                        // create default list
                        A.Add(1);
                        A.Add(2);
                        A.Add(2);
                        A.Add(6);
                        Console.Write("\nThe list contains: " + string.Join(", ", A) + "\n");
                    }
                    else
                    {
                        // create list per user specifications
                        // set the boundaries for the random number generator
                        Console.WriteLine("\nEnter the minimum value in the list:");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter the maximum value in the list:");
                        int max = int.Parse(Console.ReadLine());
                        // instantiate a random number generator
                        Random randNum = new Random();
                        // Populate the list with random numbers between min and max
                        for (int i = 0; i < lstSize; i++)
                        {
                            A.Add(randNum.Next(min, max + 1)); // range includes min but not max
                        }
                        Console.Write("\nThe list contains: " + string.Join(", ", A) + "\n");
                    }
                    if (lstSize >= 0)
                    {
                        string check = MonotonicCheck(A); // replaced boolean with string to prevent exceptions from printing message
                        if (check == "true")
                        {
                            Console.WriteLine("The list is monotonic.");
                            Console.WriteLine("\nPress any key to continue ...\n");
                            Console.ReadKey();
                            break;
                        }
                        else if (check == "false")
                        {
                            Console.WriteLine("The list is not monotonic.");
                            Console.WriteLine("\nPress any key to continue ...\n");
                            Console.ReadKey();
                            break;
                        }
                        else { }
                    }
                    else { }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer or \"0\".");
                }
            } // end of while loop

            // print 
            int[] nums = new int[] { 3, 1, 4, 1, 5 };
            int k = 2;
            int pairs = DiffPairs(nums, k);
            Console.WriteLine(pairs);

            // print 
            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "dis";
            int time = BullsKeyboard(keyboard, word);
            Console.WriteLine(time);

            // print 
            string str1 = "goulls";
            string str2 = "gobulls";
            int minEdits = StringEdit(str1, str2);
            Console.WriteLine(minEdits);

        } // end of method Main

        public static void PrintTriangle(int k)
        {
            /* n – number of rows for the pattern, integer (int)
             * summary   : This method prints a triangle pattern using *.
             * For example n = 5 will display the output as: 
             *
             *      *
             *     ***
             *    *****   
             *   *******
             *  *********
             *
             * returns      : N/A
             * return type  : void
             */
            try
            {
                // initialize line counter
                int n = k;
                // initialize printed character counter
                int j = 1;
                // set length of longest line
                int l = (n * 2) - 1;
                for (int i = 1; i <= n; i++)
                    // first line requires different processing than subsequent lines
                    if (i == 1)
                    {
                        string newline = new String('*', j);
                        Console.WriteLine("\n" + newline.PadLeft(l - (n - i)));
                    }
                    else
                    {
                        // increment number of printed characters
                        j = j + 2;
                        string newline = new String('*', j);
                        Console.WriteLine(newline.PadLeft(l - (n - i)));
                    }
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of catch block
        } // end of method PrintTriangle

        public static void PrintSeriesSum(int k)
        {
            /* n2 – number of terms of the series, integer (int)
             * This method prints the following series (Odd numbers) until n terms: 1, 3, 5, 7, 9, 11 … and their sum.
             * For example, if n2 = 5, output will be
             *
             * The odd numbers are : 1, 3, 5, 7, 9
             * The sum is : 25
             *
             * Returns : N/A
             * Return type: void
             * 
             */
            // initialize array of length k and then set values
            try
            {
                int[] odds = new int[k];
                odds[0] = 1;
                for (int i = 1; i < k; i++)
                {
                    odds[i] = odds[i - 1] + 2;
                }
                int sum = odds.Sum();
                Console.Write("\nThe odd numbers are : ");
                Console.WriteLine(string.Join(", ", odds));
                Console.WriteLine("The sum is : " + sum + "\n");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing PrintSeriesSum()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of catch block
        } // end of method PrintSeriesSum

        public static string MonotonicCheck(List<int> lst)
        {
            /* An array is monotonic if it is either monotone increasing or monotone decreasing.
             * An array A is monotone increasing if for all i <= j, A[i] <= A[j].  An array A is              
             * monotone decreasing if for all i <= j, A[i] >= A[j].
             * Return true if and only if the given array A is monotonic
             * For example:
             * Input: A = [1,2,2,6] will return the output: true
             * Input: A = [3,3,2,1] will return the output : true
             * Input: A = [4,5,2,3] will return the output: false
             * Input: A = [1,1,1,1] will return the output : true
             * returns      : Boolean Value
             * return type  : bool
             */
            try
            {
                // store the list's maximum index value
                int maxIdx = lst.Count - 1;
                // if list appears to be increasing, do this
                if (lst[0] < lst[maxIdx])
                {
                    for (int i = 0; i < maxIdx; i++)
                    {
                        if (lst[i] > lst[i + 1])
                        {
                            return "false";
                        }
                    }
                    return "true";
                } // end of increasing list validation
                // if list appears to be decreasing, do this
                else if (lst[0] > lst[maxIdx])
                {
                    for (int i = 0; i < maxIdx; i++)
                    {
                        if (lst[i] < lst[i + 1])
                        {
                            return "false";
                        }
                    }
                    return "true";
                } // end of decreasing list validation
                // if list appears to be flat, do this
                else
                {
                    for (int i = 0; i < maxIdx; i++)
                    {
                        if (lst[i] != lst[i + 1])
                        {
                            return "false";
                        }
                    }
                    return "true";
                } // end of flat list validation
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing MonotonicCheck()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return "exception";
            } // end of catch block
        } // end of method MonotonicCheck

        public static int DiffPairs(int[] J, int k)
        {
            /* Given an array of integers and an integer n, you need to find the number of unique
             * n-diff pairs in the array. Here a n-diff pair is defined as an integer pair (i, j),    
             * where i and j are both numbers in the array and their absolute difference is n.
             * Example 1:
             * Input: [3, 1, 4, 1, 5], k = 2
             * Output: 2
             * Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
             * Although we have two 1s in the input, we should only return the number of unique   
             * pairs.
             * Example 2:
             * Input:[1, 2, 3, 4, 5], k = 1
             * Output: 4
             * Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and  
             * (4, 5).
             * Example 3:
             * Input: [1, 3, 1, 5, 4], k = 0
             * Output: 1
             * Explanation: There is one 0-diff pair in the array, (1, 1).
             * Note : The pairs (i,j) and (j,i) count as same.
             */
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            }

            return 0;
        } // end of method DiffPairs

        public static int BullsKeyboard(string keyboard, string word)
        {
            /* Imagine a special bulls keyboard with all keys in a single row. 
             * Given a string keyboard of length 26 indicating the layout of the keyboard(indexed 
             * from 0 to 25), initially your finger is at index 0. To type a character, you have 
             * to move your finger to the index of the desired character.
             * The time taken to move your finger from index i to index j is |i – j|
             * You want to type a single word. Complete the function to calculate 
             * how much time it takes to type it with one finger.
             * Example 1:
             * Input: keyboard = “abcdefghijklmnopqrstuvwxyz” word = “dis”
             * Output:  18
             * Explanation: Initial index 0 at a . The moves from 0 to 3 , then 3 to 8 and finally 
             * from 8 to 18. Therefore total time = 3 + 5 + 10 = 18
             *
             * Example 2:
             * Input: keyboard = “hijklmnopqrstuvwxyzabcdefg” word = “gobulls”
             * Output:  79
             * returns      : Integer
             * return type  : int
             */
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing BullsKeyboard()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            }

            return 0;
        } // end of method BullsKeyboard

        public static int StringEdit(string str1, string str2)
        {
            /* Given two strings str1 and str2 and below operations that can performed on str1.
             * Find minimum number of edits (operations) required to convert ‘str1’ into ‘str2’
             * 1.Insert
             * 2.Remove
             * 3.Replace
             * 
             * All of the above operations are of equal cost.
             * 
             * Example 1:
             * Input: str1 = “goulls” str2 = “gobulls”
             * Output: 1
             * Explanation: We can convert str1 to str2 by inserting ‘b’
             *
             * Example 2:
             * Input: str1 = “robky” str2 = “rocky”
             * Output: 1
             * Explanation: We can convert str1 to str2 by replacing ‘b’ with ‘u’
             *
             * Example 3:
             * Input: str1 = “sunday” str2= “saturday”
             * Output: 3
             * Explanation: We can convert by replacing ‘n’ with ‘r’ and inserting ‘t’ and ‘a’
             * returns      : Integer
             * return type  : int
             */
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            }

            return 0;
        } // end of method StringEdit
    } // end of class Program
} // end of namespace Assignment1_Fall20
