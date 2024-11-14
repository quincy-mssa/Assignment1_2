using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            //Test Data :
            //Input 1st number: 5
            //Input 2nd number: 5
            //Expected Output :
            //5 and 5 are equal
            double firstNum, secondNum;
            firstNum = 5;
            secondNum = 15;
            if (firstNum == secondNum)
            {
                Console.WriteLine(+firstNum + " and " + secondNum + " are equal.");
            }
            else if (secondNum != firstNum)
            {
                Console.WriteLine(+firstNum + " and " + secondNum + " are not equal");
            }

            {
                //Write a console application in C# to explore different ways in which array is
                //declared and initialized and explore different properties and methods of Array class
                int[] array1 = { 1, 2, 3, 4, 5 }; //Declares a 5 element array of integers
                string[] array2 = { "ocean", "mountain", "valley" }; //Declares a 3 element array of strings
                var numbers = new[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(array2);



            }

            {
                //Write a program in C# to read n number of values in an array and display it in reverse order.Test Data :
                //Input the number of elements to store in the array :3
                //Input 3 number of elements in the array :
                //element - 0 : 2
                //element - 1 : 5
                //element - 2 : 7
                //Expected Output:
                //The values store into the array are:
                //2 5 7
                //The values store into the array in reverse are :
                //7 5 2

                {
                    //Ask for the number of elements to store in the array
                    Console.Write("Input the number of elements to store in the array: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    //Declare the array and size
                    int[] array = new int[n];

                    //Get elements from the user
                    Console.WriteLine("Input " + n + " number of elements in the array:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("element - " + i + " : ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    //Show array in original order
                    Console.WriteLine("The values stored in the array are:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(array[i] + " ");
                    }

                    Console.WriteLine();

                    //Show the array in reverse order
                    Console.WriteLine("The values stored in the array in reverse are:");
                    for (int i = n - 1; i >= 0; i--)
                    {
                        Console.Write(array[i] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
