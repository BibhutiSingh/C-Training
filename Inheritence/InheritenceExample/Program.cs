using System;

public class ConstructorExample{

    public static void Main(){
        int? a = 10;
           int? b=null;


        Console.WriteLine($"Sub of A + B ={(a ?? 1)  +  (b ?? 1)}");
        Students student=new Students(1, "ABC");


        //StudentInfo.CurrentStudent = student;
        StudentInfo.PrintCurrentStudentDetail();

        Console.ReadKey();
    }  
     
}

public static class StudentInfo
{
    public static Students CurrentStudent { get; set; }
    
    public static void PrintCurrentStudentDetail()
    {
        if(CurrentStudent is null){
            Console.WriteLine("No student assigned to current student property.");
        }
        else{
        CurrentStudent.PrintStudentDetails();
        }
    }
    
    
}
public interface IStudent
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public void PrintStudentDetails();    
    
}

public class Students : IStudent{
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
