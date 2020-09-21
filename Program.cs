using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_Fall20
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a triangle of arbitary height
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the height of the triangle:");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        PrintTriangle(n);
                        break;
                    } // end of if block
                    else
                    {
                        Console.WriteLine("\nPlease enter a positive integer.");
                    } // end of else block
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer.");
                } // end of catch block
            } // end of triangle while loop

            // print an arbitrary-length series of odd numbers and its sum
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number of terms in the series:");
                    int n2 = int.Parse(Console.ReadLine());
                    if (n2 > 0)
                    {
                        PrintSeriesSum(n2);
                        break;
                    } // end of if block
                    else
                    {
                        Console.WriteLine("\nPlease enter a positive integer.");
                    } // end of else block
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer.");
                } // end of catch block
            } // end of odd numbers while loop

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
                    } // end of if block
                    // proceed with valid input
                    else if (lstSize == 0)
                    {
                        // create default list
                        A.Add(1);
                        A.Add(2);
                        A.Add(2);
                        A.Add(6);
                        Console.Write("\nThe list contains: " + string.Join(", ", A) + "\n");
                    } // end of else if block
                    // proceed with valid input
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
                        } // end of for loop
                        Console.Write("\nThe list contains: " + string.Join(", ", A) + "\n");
                    } // end of else block
                    if (lstSize >= 0)
                    {
                        string check = MonotonicCheck(A); // replaced boolean with string to prevent exceptions from printing message
                        if (check == "true")
                        {
                            Console.WriteLine("The list is monotonic.");
                            Console.WriteLine("\nPress any key to continue ...\n");
                            Console.ReadKey();
                            break;
                        } // end of if block
                        else if (check == "false")
                        {
                            Console.WriteLine("The list is not monotonic.");
                            Console.WriteLine("\nPress any key to continue ...\n");
                            Console.ReadKey();
                            break;
                        } // end of else if block
                        else { }
                    } // end of if block
                    else { }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter a positive integer or \"0\".");
                }  // end of catch block
            } // end of monotonicity while loop

            // print number of unique n-diff pairs in an integer array
            while (true)
            {
                try
                {
                    // prompt user to choose an array
                    Console.WriteLine("\nPlease select an array:");
                    Console.WriteLine("Enter 1 for { 3, 1, 4, 1, 5 } with n-diff = 2.");
                    Console.WriteLine("Enter 2 for { 1, 2, 3, 4, 5 } with n-diff = 1.");
                    Console.WriteLine("Enter 3 for { 1, 3, 1, 5, 4 } with n-diff = 0.");
                    Console.WriteLine("Enter 4 to specify a custom 5-array and n-diff value.");
                    string input = Console.ReadLine();
                    int arrChoice = int.Parse(input);
                    // initialize variables
                    int[] nums = new int[5];
                    int k = 0;
                    int pairs = 0;
                    if (arrChoice == 1)
                    {
                        // correct output = 2
                        nums[0] = 3;
                        nums[1] = 1;
                        nums[2] = 4;
                        nums[3] = 1;
                        nums[4] = 5;
                        k = 2;
                    }
                    else if (arrChoice == 2)
                    {
                        // correct output = 4
                        nums[0] = 1;
                        nums[1] = 2;
                        nums[2] = 3;
                        nums[3] = 4;
                        nums[4] = 5;
                        k = 1;
                    }
                    else if (arrChoice == 3)
                    {
                        // correct output = 1
                        nums[0] = 1;
                        nums[1] = 3;
                        nums[2] = 1;
                        nums[3] = 5;
                        nums[4] = 4;
                        k = 0;
                    }
                    else if (arrChoice == 4)
                    {
                        try
                        {
                            Console.WriteLine("\nPlease enter the first integer.");
                            string str1 = Console.ReadLine();
                            int int1 = int.Parse(str1);
                            Console.WriteLine("\nPlease enter the second integer.");
                            string str2 = Console.ReadLine();
                            int int2 = int.Parse(str2);
                            Console.WriteLine("\nPlease enter the third integer.");
                            string str3 = Console.ReadLine();
                            int int3 = int.Parse(str3);
                            Console.WriteLine("\nPlease enter the fourth integer.");
                            string str4 = Console.ReadLine();
                            int int4 = int.Parse(str4);
                            Console.WriteLine("\nPlease enter the fifth integer.");
                            string str5 = Console.ReadLine();
                            int int5 = int.Parse(str5);
                            Console.WriteLine("\nPlease enter the n-diff value.");
                            string str6 = Console.ReadLine();
                            int int6 = int.Parse(str6);
                            nums[0] = int1;
                            nums[1] = int2;
                            nums[2] = int3;
                            nums[3] = int4;
                            nums[4] = int5;
                            k = int6;
                        } // end of try block
                        catch
                        {
                            Console.WriteLine("\nPlease enter only integers.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter 1, 2, 3, or 4.");
                        continue;
                    }
                    pairs = DiffPairs(nums, k);
                    Console.WriteLine("\n" + pairs + " unique n-diff pairs were found in the array.");
                    Console.WriteLine("\nPress any key to continue ...\n");
                    Console.ReadKey();
                    break;
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter 1, 2, 3, or 4.");
                } // end of catch block
            } // end of n-diff pairs while loop

            // print time required to type a word
            while (true)
            {
                try
                {
                    // prompt user to choose a keyboard and word
                    Console.WriteLine("\nPlease select a keyboard and word:");
                    Console.WriteLine("Enter 1 to time entry of \"dis\" on keyboard \"abcdefghijklmnopqrstuvwxyz\".");
                    Console.WriteLine("Enter 2 to time entry of \"gobulls\" on keyboard \"hijklmnopqrstuvwxyzabcdefg\".");
                    Console.WriteLine("Enter 3 to enter a custom word and keyboard.");
                    string input = Console.ReadLine();
                    int wordChoice = int.Parse(input);
                    // initialize variables
                    string keyboard = "";
                    string word = "";
                    int time = 0;
                    // calculate time
                    if (wordChoice == 1)
                    {
                        // correct output = 18
                        word = "dis"; 
                        keyboard = "abcdefghijklmnopqrstuvwxyz";
                        time = BullsKeyboard(keyboard, word);
                        Console.WriteLine("\nThe time required to type the word was " + time + ".");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    } // end of choice 1
                    else if (wordChoice == 2)
                    {
                        // correct output = 79
                        word = "gobulls";
                        keyboard = "hijklmnopqrstuvwxyzabcdefg";
                        time = BullsKeyboard(keyboard, word);
                        Console.WriteLine("\nThe time required to type the word was " + time + ".");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    } // end of choice 2
                    else if (wordChoice == 3)
                    {
                        Console.WriteLine("\nPlease enter the word: ");
                        word = Console.ReadLine();
                        Console.WriteLine("\nPlease enter the keyboard sequence: ");
                        keyboard = Console.ReadLine();
                        time = BullsKeyboard(keyboard, word);
                        Console.WriteLine("\nThe time required to type the word was " + time + ".");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    } // end of choice 3
                    else
                    {
                        Console.WriteLine("\nPlease enter 1, 2, or 3.");
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nPlease enter 1, 2, or 3.");
                } // end of catch block
            } // end of keyboard timer while loop

            // print numbers of operations to change a string
            while (true)
            {
                try
                {
                    // prompt user for two strings
                    Console.WriteLine("Enter \"a\" to accept string 1 as \"goulls\" and string 2 as \"gobulls\".");
                    Console.WriteLine("Enter \"b\" to accept string 1 as \"robky\" and string 2 as \"rocky\".");
                    Console.WriteLine("Enter \"c\" to accept string 1 as \"sunday\" and string 2 as \"saturday\".");
                    Console.WriteLine("Enter anything else to specify the strings.");
                    string choice = Console.ReadLine();
                    int minEdits = 0;
                    if (choice == "a")
                    {
                        // correct output = 1
                        string str1 = "goulls";
                        string str2 = "gobulls";
                        minEdits = StringEdit(str1, str2);
                    } // end of default string 1 block
                    else if (choice == "b")
                    {
                        // correct output = 1
                        string str1 = "robky";
                        string str2 = "rocky";
                        minEdits = StringEdit(str1, str2);
                    } // end of default string 2 block
                    else if (choice == "c")
                    {
                        // correct output = 3
                        string str1 = "sunday";
                        string str2 = "saturday";
                        minEdits = StringEdit(str1, str2);
                    } // end of default string 3 block
                    else
                    {
                        Console.WriteLine("\nEnter the first string.");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("\nEnter the second string.");
                        string str2 = Console.ReadLine();
                        minEdits = StringEdit(str1, str2);
                    } // end of user string block
                    if (minEdits == 499)
                    {
                        break;
                    } // end of bypass output block
                    else
                    {
                        Console.WriteLine("\nString 1 required " + minEdits + " operation(s) to match string 2.");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    } // end of output block
                } // end of try block
                catch { }
            } // end of string operations while loop

        } // end of method Main

        private static void PrintTriangle(int k)
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
                // iterate thru the lines
                for (int i = 1; i <= n; i++)
                {
                    // first line requires different processing than subsequent lines
                    if (i == 1)
                    {
                        string newline = new String('*', j);
                        Console.WriteLine("\n" + newline.PadLeft(l - (n - i)));
                    } //end of if block
                    else
                    {
                        // increment number of printed characters
                        j = j + 2;
                        string newline = new String('*', j);
                        Console.WriteLine(newline.PadLeft(l - (n - i)));
                    } //end of else block
                } // end of for loop
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

        private static void PrintSeriesSum(int k)
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
                } //end of for loop
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

        private static string MonotonicCheck(List<int> lst)
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
                    } //end of for loop
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
                    } //end of for loop
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
                    } //end of for loop
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

        private static int DiffPairs(int[] j, int k)
        {
            /* Given an array of integers and an integer n, you need to find the number of unique
             * n-diff pairs in the array. Here a n-diff pair is defined as an integer pair (i, j),    
             * where i and j are both numbers in the array and their absolute difference is n.
             * Example 1:
             * Input: [3, 1, 4, 1, 5], k = 2
             * Output: 2
             * Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
             * Although we have two 1s in the input, we should only return the number of unique pairs.
             * Example 2:
             * Input:[1, 2, 3, 4, 5], k = 1
             * Output: 4
             * Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and (4, 5).
             * Example 3:
             * Input: [1, 3, 1, 5, 4], k = 0
             * Output: 1
             * Explanation: There is one 0-diff pair in the array, (1, 1).
             * Note : The pairs (i,j) and (j,i) count as same.
             */
            try
            {
                // initialize list of previously processed values to avoid counting duplicates
                List<int> seen = new List<int>();
                // initialize counter of unique n-diff pairs
                int nDiffs = 0;
                // iterate thru elements of the array
                for (int i = 0; i < j.Length - 1; i++)
                {
                    // avoid counting duplicates
                    if (seen.Contains(j[i]))
                    {
                        continue;
                    }
                    else
                    {
                        // initialize list of previously processed values to avoid counting duplicates
                        List<int> tempSeen = new List<int>();
                        // compare current element to each element on the right
                        for (int z = 1; i + z < j.Length; z++)
                        {
                            // avoid counting duplicates
                            if (tempSeen.Contains(j[i + z]))
                            {
                                continue;
                            }
                            else if (Math.Abs(j[i] - j[i + z]) == k)
                            {
                                nDiffs++;
                                // avoid counting duplicates
                                tempSeen.Add(j[i + z]);
                            }
                            else
                            {
                                // avoid counting duplicates
                                tempSeen.Add(j[i + z]);
                            }
                        } // end of inside for loop
                        // avoid counting duplicates
                        seen.Add(j[i]);
                    } // end of else block
                } // end of outside for loop
                return nDiffs;
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return 0;
            } // end of catch block
        } // end of method DiffPairs

        private static int BullsKeyboard(string keyboard, string word)
        {
            /* Imagine a special bulls keyboard with all keys in a single row. 
             * Given a string keyboard of length 26 indicating the layout of the keyboard (indexed 
             * from 0 to 25), initially your finger is at index 0. To type a character, you have 
             * to move your finger to the index of the desired character.
             * The time taken to move your finger from index i to index j is |i – j|
             * You want to type a single word. Complete the function to calculate 
             * how much time it takes to type it with one finger.
             * Example 1:
             * Input: keyboard = “abcdefghijklmnopqrstuvwxyz” word = “dis”
             * Output:  18
             * Explanation: Initial index 0 at a. The moves from 0 to 3 , then 3 to 8 and finally 
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
                // 
                int time = 0;
                int curPos = 0;
                int nextPos = 0;
                foreach (char x in word)
                {
                    nextPos = keyboard.IndexOf(x);
                    time += Math.Abs(curPos - nextPos);
                    curPos = nextPos;
                }
                return time;
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing BullsKeyboard()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return 0;
            } // end of catch block
        } // end of method BullsKeyboard

        private static int StringEdit(string string1, string string2)
        {
            /* Given two strings str1 and str2 and below operations that can be performed on str1.
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
             * Explanation: We can convert str1 to str2 by replacing ‘b’ with ‘c’
             *
             * Example 3:
             * Input: str1 = “sunday” str2= “saturday”
             * Output: 3
             * Explanation: We can convert by inserting ‘a’ and ‘t’ and replacing ‘n’ with ‘r’
             * returns      : Integer
             * return type  : int
             */
            try
            {
                // initialize variables
                StringBuilder str1 = new StringBuilder(string1);
                StringBuilder str2 = new StringBuilder(string2);
                int numOps = 0;
                // if string lengths are equal
                if (str1.Length == str2.Length)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] == str2[i])
                        {
                            continue;
                        }
                        else
                        {
                            str1[i] = str2[i];
                            numOps++;
                        }
                    } // end of for loop
                    Console.WriteLine("\nString 1 is now: " + str1);
                    Console.WriteLine("String 2 is now: " + str2);
                } // end of same length block
                // if str1 is shorter than str2
                else if (str1.Length < str2.Length)
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] == str2[i])
                        {
                            continue;
                        }
                        else
                        {
                            if (str1[i + 1] == str2[i + 1])
                            {
                                str1[i] = str2[i];
                                numOps++;
                            }
                            else if (str1.Length < str2.Length)
                            {
                                str1.Insert(i, str2[i]);
                                numOps++;
                            }
                            else
                            {
                                str1[i] = str2[i];
                                numOps++;
                            }
                        } // end of else block
                    } // end of for loop
                    Console.WriteLine("\nString 1 is now: " + str1);
                    Console.WriteLine("String 2 is now: " + str2);
                } // end of shorter block
                // if str1 is longer than str2
                else
                {
                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i] == str2[i])
                        {
                            continue;
                        }
                        else
                        {
                            if (i < str1.Length - 1 && str1[i + 1] == str2[i + 1])
                            {
                                str1[i] = str2[i];
                                numOps++;
                            }
                            else if (str1.Length > str2.Length)
                            {
                                str1.Remove(i, 1);
                                numOps++;
                                i--;
                            }
                            else
                            {
                                str1[i] = str2[i];
                                numOps++;
                            }
                        } // end of else block
                    } // end of for loop
                    Console.WriteLine("\nString 1 is now: " + str1);
                    Console.WriteLine("String 2 is now: " + str2);
                } // end of longer block
                return numOps;
            } // end of try block
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return 499;
            } // end of catch block
        } // end of method StringEdit
    } // end of class Program
} // end of namespace Assignment1_Fall20
