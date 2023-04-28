# Assignment 31-March-2023
## Submition Date 03-Apr-2023

## Problem 1
Write a code to revrse a string. Take a string input from user. Print reverse of it.
Input="ABC"
Output=>"CBA"

## Problem 2
Write a extention method to count the number of vowels in a string provided by user.
Input1 => "RAJU"
Output1 => 2

Input 2 => "Seema"
Output 2=> 3

*Note : The code should be able to work with uppercase as well as lower case values.

## Problem 3
In a list of names print the count/occurance of each name.

Input 1=> ["RAJ", "raj", "Avi","Kirti"]
Output 1=> 
Raj - 2
Avi - 1
Kirti - 1

## Problem 4
Write a AppMath class, which should implements Add, Substract, Multiplication, Division
of integer as well as double/decimal values.

Also, input should not be retricted to 2 params

eg int Add(int a, int b);
double Add(double a, double b);
decimal Add(decimal a, decimal b);

input => Add(2,2,5,6,7)
Output => 22

input => Multiplication(2,2,5)
Output => (2*2*5)=> 20

# Assignment 10-Apr-2023
# Problem 1
Write a function to append a line to a text file.

<pre><code class='language-cs'>
using System;
using System.IO;
public class MyProgram
{
    public static void Main()
    {
       string filePath=@"C:\06_Official\Trainings\Sessions\testTextFile.txt";
       AppendLine(filePath, "this is a line which is getting appended.");
       Console.ReadKey();
    }

    public static void AppendLine(string filePath, string newLine){
        //Write your code here
    }
    }
</code></pre>


# Assignment 12-Apr-2023
# Problem 1

Finish Simple calculator add more operations ( * , / , Mod(%))

# Assignment 28-Apr-2023
# Problem 1

Create a MDI Form application. Application should connect to SQLite file or db. Database will have only 1 table called "MyExpense"

| Id | ExpeneItem | ExpenseDate | ExpenseAmount |   |
|----|------------|-------------|---------------|---|
| 1  | Food       | 23-Apr-2023 | 300.56        |   |

Application should be able to View all expenes in a grid and user can add, update, delete any expense.
