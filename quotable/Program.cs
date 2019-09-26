using System;
using SimpleRandomQuoteProvider;


namespace Program
{
    public class Class1
    {
        long input;
        string stringInput;
        new SimpleRandomQuoteProvider quoter = SimpleRandomQuoteProvider;

     static void Main(string[] args){
            Console.Write("Enter number of quotes: ");
            input = Console.ReadLine();
            quoter.quote(input);
         }

     }

        
    }

