using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace DIS_Assignment1

{

    class Program

    {

        static void Main(string[] args)

        {

            int a = 5, b = 15;

            printPrimeNumbers(a, b);



            int n1 = 5;

            double r1 = getSeriesResult(n1);

            Console.WriteLine("The sum of the series is: " + r1);





            long n2 = 15;

            long r2 = decimalToBinary(n2);

            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);





            long n3 = 1111;

            long r3 = binaryToDecimal(n3);

            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);





            int n4 = 5;

            printTriangle(n4);



            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };

            computeFrequency(arr);



            Console.ReadLine();



            // The assignment helped me in rejuvenate my knowledge of some of the loops concepts and how to convey our logic in computer language.

        }



        public static void printPrimeNumbers(int x, int y) // this method is void which means we dont have to provide any return type to this method.

        {

            try

            {

                int n, i, c;// initializing integers value n, i ,c

                for (n = x; n <= y; n++) // This for loop first take the value of x as n then checks rhe condition that the value must be less than equal to y and if it satisfy then it will repeat untill it unsatisfy that condition. This loop is to go through each number between x and y to find out prime numbers.

                {

                    c = 0; // here we set the value of int c = 0.

                    for (i = 2; i <= n / 2; i++) // This loop provides our logic to find out prime numbers between x and y. This logic can findout the prime numbers between any range of numbers.
                                                 // In this loop i will start from 2 and than checks the condition i should be less than or equal to n/2 and if it satisfy this condition the i will increase.
                    {

                        if (n % i == 0) // if will check this condition that n will divide by i and if remainder is 0 then it will enter this loop

                        {

                            c++; // c will increment

                            break;

                        }

                    }

                    if (c == 0 && n != 1) // this if comment c must be equal to 0 and also checks n not equal to 1 and if it passes both condition then it will write.

                        Console.Write("{0} ", n);

                }

                Console.Write("\n"); // for change of line 

            }

            catch

            {

                Console.WriteLine("Exception occured while computing printPrimeNumbers()"); // to catch exception 

            }

        }



        public static double getSeriesResult(int n) // this method is double which means that this method will reqiure a return type to execute this method.

        {

            try

            {

                int i, s = 0; // two integers are created i and s, and we have set the value of int s = 0.

                int x = 1;// We have set the value of integer x = 1.

                for (i = 1; i <= n; i++)// the i will start from the 1, than satisfy the condition that i should be less than or equal to n, then it will increase untill it unsatisfy this condition 

                {

                    s = s + x; // Here we are providing the logic that every number will be added in s untill the loop stop.  

                    x = (x) + 1; // increasing value of x by 1 because we are doing series sum and in series the numbers will increase by 1.

                }

                return Convert.ToDouble(s); // provide a return type to the method and converting the int s in double.

            }

            catch

            {

                Console.WriteLine("Exception occured while computing getSeriesResult()"); // catch exception

            }

            return 0;

        }



        public static long decimalToBinary(long n) // This method is also have datatype that is long. So, we have to provide a retun type to this method

        {

            try

            {

                int m = Convert.ToInt32(n); // Here we are assigning the value of int m. And the value is n as the n is long datatype so we have to convert it into interger.

                string result; // declaring a string result



                result = ""; // In result we have passed an empty string.

                // I have taken a variable 'remain' which will store remainder value after dividing m with 2. After that I will store remainder value adding into another variable 'result'.

                while (m > 1)

                {

                    int remain = m % 2; // to find out remainder which is our key of conversion

                    result = Convert.ToString(remain) + result; // to add previous result to current one 

                    m /= 2; // Division assignment. This will divide the value of m by 2 and return the value.

                }

                result = Convert.ToString(m) + result; // adding last element through which it will exit while loop

                return Convert.ToInt64(result);

            }

            catch

            {

                Console.WriteLine("Exception occured while computing decimalToBinary()");

                return 0;

            }

        }
        public static long binaryToDecimal(long n) // This method is also have datatype that is long. So, we have to provide a retun type to this method

        {

            long dec = 0, bin = 1, rem; // Created three long datatype and set dec=0 and bin=1

            try

            {

                while (n > 0) // while loop will check condition for value n

                {

                    rem = n % 10;               //taking  the value in unit digit 

                    dec = (dec + rem) * bin;  // Logic to calculating decimal value

                    n = n / 10;

                    bin = bin * 2;  // Converting in decimal

                }

            }

            catch

            {

                Console.WriteLine("Exception occured while computing binaryToDecimal()");

            }



            return dec; // returning the value

        }



        public static void printTriangle(int n)

        {

            try

            {

                int space, x; // created two integers space and x

                for (int i = 1; i <= n; i++) // this for loop will start will i=1 and than check the condition i should be less than n and than i will increase upto the condition will unsatisfy. 

                {

                    for (space = 1; space <= (n - i); space++) // Here we we are applying for loop to print space. through this logic there will be 4 space printed in the first line as the value of will be 1 for the first iteration and n is 5 which is n - i = 4  

                        Console.Write(" ");

                    for (x = 1; x <= i; x++) //increment the value   

                        Console.Write('*');

                    for (x = (i - 1); x >= 1; x--) //decrement the value  

                        Console.Write("*");

                    Console.WriteLine();

                }

            }

            catch

            {

                Console.WriteLine("Exception occured while computing printTriangle()");

            }

        }



        public static void computeFrequency(int[] a)

        {

            try

            {

                int n = a.Length; // Here we are creating an integer n and assigning it to the lenght of the array.

                Boolean[] b = new Boolean[n]; // Here we created object of array and passes the int n to its index

                Console.WriteLine("Computed Frequency is:");

                for (int i = 0; i < n; i++) // for loop to inspect each and every element in the array

                {

                    if (b[i] == true) // this if loop check whether the string is empty or not, if i = 0 and it doesnot satisfay this condition whic means the array is empty or if satisfy the condition than it will read the first element of array.

                        continue;

                    int counter = 1;

                    for (int j = i + 1; j < n; j++) // Now the index wiil increase by 1 and checks all the values of array 

                    {

                        if (a[i] == a[j]) // Compare the values at of array at different indexes.

                        {

                            b[j] = true;    // if the value satisfy

                            counter++;     //increment the counter

                        }



                    }



                    Console.WriteLine(a[i] + "  :  " + counter);

                }

            }

            catch

            {

                Console.WriteLine("Exception occured while computing computeFrequency()");

            }

        }



    }

}