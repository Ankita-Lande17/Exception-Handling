using System;
 
namespace user_defined_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceptage;
            Console.WriteLine("Enter your age:");
            acceptage = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptage == 18 || acceptage > 18)
                {
                    Console.WriteLine("Congratulations! You are eligibale for voting card:");
                    Console.ReadLine();
                }
                else
                {
                    throw (new InvalidAgeException("You are not eligibale for voting card:"));
                }
            }
            catch (InvalidAgeException e) 
            { 
                Console.WriteLine(e); 
            }  
 
        }
    }
    /// <summary>
    /// This is user create exception
    /// </summary>
 
public class InvalidAgeException : Exception  
{  
    public InvalidAgeException(String message)  
        : base(message)  
    {  
  
    }  
}  
}