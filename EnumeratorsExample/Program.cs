using System;
using System.Collections;
using System.Collections.Generic;
//Basic enum is
public enum ExamResult
{
    Pass,
    Fail,
    Suply,
    Compartment
}

public class MyClass
{
    public static void Main()
    {
        ExamResult currentResult = ExamResult.Pass;

        if(currentResult == ExamResult.Pass){
            Console.WriteLine($"Current Result is {currentResult}");
        }

        MyBookCollection myCollection=new MyBookCollection();
        foreach(var book in myCollection){
            Console.WriteLine(book);
        }
       Console.ReadKey();

    }

    public class MyBookCollection : IEnumerable<string>
    {
        BookEnumrator mybooks=new BookEnumrator();

        public IEnumerator<string> GetEnumerator()
        {
            while(mybooks.MoveNext()){
                yield return mybooks.Current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class BookEnumrator : IEnumerator<string>, IEnumerator, IDisposable
    {
         string [] myBooks = {"Maths 1","Maths 2", "Physics", "Chemestry","Bio","CS"};
         private string _current;
         private int _state=0;
         
 


        public BookEnumrator()
        {
            _current=myBooks[0];
        }

        public string Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
           if(_state < myBooks.Length -1  ){
                    _state++;
                _current=myBooks[ _state];
                return true;
                           }
                           return false;
        }

        public void Reset()
        {
            _state=0;
            _current= myBooks[_state];
        }
    }
}

