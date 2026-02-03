namespace Homework2;
class Program
{
    static void Main(string[ ] args) 
    {
        // Code for Q1 Please input a letter Grade: F GPA: 0 ; Please input letter Grade: G Wrong Letter Grade!
         Console.WriteLine("Please input a letter grade: ");
        string grade = Console.ReadLine();
        grade = grade.ToUpper(); //making letter upper case

        if (grade == "A")
        {
            Console.WriteLine("GPA: 4");
            }else if (grade == "B")
        {
            Console.WriteLine("GPA: 3");
             }else if (grade == "C")
        {
            Console.WriteLine("GPA: 2");
            }else if (grade == "D")
        {
            Console.WriteLine("GPA: 1");
            }else if (grade == "F")
        {
            Console.WriteLine("GPA: 0");
        }
            else
        {
            Console.WriteLine("Wrong Letter Grade!"); 
        }


// Code for Q2

            Console.Write("Please input the first Number: ");
            short a = Convert.ToInt16(Console.ReadLine()); // "a" will contain the first number

            Console.Write("Please input the second num: ");
            short b = Convert.ToInt16(Console.ReadLine()); // "b" will contain the second number

            Console.Write("Please input the third num: ");
            short c = Convert.ToInt16(Console.ReadLine()); //"c" will contain the third number

            short smallest;

            if (a <= b) // logical statements
            {
                if (a <= c)
                {
                    smallest = a;
                }
                else
                {
                    smallest = c;
                }
            }
            else
            {
                if (b <= c)
                {
                    smallest = b;
                }
                else
                {
                    smallest = c;
                }
            }

            Console.WriteLine("The smallest Value is: " + smallest); //return results
        }}
    
       // Code for Bonus question
    
