using System;

public class InheritenceExample{

    public static void Main(){
        AppMath math=new AppMath();
        Console.WriteLine(math.Sum(2,2));
        Console.WriteLine(math.Sub(2,2));
        Console.ReadKey();
    }  
     
}
public sealed class AppMath
{
    public int Sum(int a, int b){
        return a+b;
    }
}

public static class MyExtention{
    public static int Sub(this AppMath appMath, int a, int b){
        return a-b;
    }
}


