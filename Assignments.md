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

# Assignment 3-Apr-2023
# Problem 1.	
Write a program in C# Sharp to input a string and print it
Test Data :
Input the string : Welcome, w3resource
Expected Output :
The string you entered is : Welcome, w3resource 

# Problem 2.	
Write a program in C# Sharp to find the length of a string without using library function.  
Test Data :
Input the string : w3resource.com
Expected Output :
Length of the string is : 15 

# Problem 3.	
Write a program in C# Sharp to separate the individual characters from a string. 
Test Data :
Input the string : w3resource.com
Expected Output :
The characters of the string are : 
w  3  r  e  s  o  u  r  c  e  .  c  o  m 


# Problem 4.	
Write a program in C# Sharp to print individual characters of the string in reverse order. 
Test Data :
Input the string : w3resource.com
Expected Output :
The characters of the string in reverse are : 

m  o  c  .  e  c  r  u  o  s  e  r  3  w 


# Problem 5.	
Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string. 
Test Data :
Input the string : Welcome to w3resource.com
Expected Output :
	Number of Alphabets in the string is : 21 
	Number of Digits in the string is : 1 
	Number of Special characters in the string is : 4 


# Assignment 10-Apr-2023
# (Anmol) Problem 1:
Do a basic I/O file operation including creating , writing , opening and reading the file.
# Problem 2
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

# Assignment 24-Apr-2023(Anmol)
# Problem 1
Abstract Classes
The firm hires only two types of employees- either driver or developer. Now, you have to develop a software to store the information about them. 
Exp out : 
Salary of developer : 5000
Salary of driver : 3000

# Problem 2 
calculate area and perimeter of rectangle and square using interface method class
Exp out : 
Rectangle :
Area : 28 Perimeter : 22
Square :
Area : 16 Perimeter : 16

# Problem 3 
Write a program to print pattern using Nested Loop
Exp out : 
1 2
1 2 3
1 2 3 4
1 2 3 4 5

# Problem 4 
Using different inner and outer nested loops print the pattern
Exp out :
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5


# Assignment 28-Apr-2023
# Problem 1

Create a MDI Form application. Application should connect to SQLite file or db. Database will have only 1 table called "MyExpense"

| Id | ExpeneItem | ExpenseDate | ExpenseAmount |   |
|----|------------|-------------|---------------|---|
| 1  | Food       | 23-Apr-2023 | 300.56        |   |

Application should be able to View all expenes in a grid and user can add, update, delete any expense.
# ADO.NET Assignments from Anmol
# Problem 2	
Research and explain the key components of ADO.NET, including the DataSet, DataReader, and Connection objects. Write a summary of your findings and present it to the class.
# Problem 3	
Discuss the benefits and limitations of using ADO.NET versus other data access technologies, such as Entity Framework or LINQ to SQL. 
# Problem 4
Research the differences between connected and disconnected data access in ADO.NET, and provide examples of when each approach might be appropriate. Write a summary of your findings.

# Assignment 12-May-2023 (Anmol)
# Problem  1:
Create and use a singlecast delegate.
# Problem  2:
Create and use a multicast delegate.
# Problem  3: 
Create using an anonymous delegate.


