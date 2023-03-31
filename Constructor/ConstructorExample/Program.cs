using System;

public class ConstructorExample{

    public static void Main(){
        Students student=new Students(1, "ABC");

        //student.PrintStudentDetails();


        StudentInfo.CurrentStudent = student;
        StudentInfo.PrintCurrentStudentDetail();

        Console.ReadKey();
    }  
     
}

public static class StudentInfo
{
    public static Students CurrentStudent { get; set; }
    
    public static void PrintCurrentStudentDetail()
    {
        CurrentStudent.PrintStudentDetails();
    }
    
    
}

public class Students{
    public Students(int rollNumber, string name)
    {
        RollNumber=rollNumber;
        Name= name;
    }
    public int  RollNumber { get; set; }   
    
    public string Name { get; set; }

    public void PrintStudentDetails(){
        Console.WriteLine($"{RollNumber}- {Name}");
    }
    
    
}
