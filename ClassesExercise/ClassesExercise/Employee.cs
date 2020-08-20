using System;
namespace ClassesExercise
{
    public class Employee
    {
       
        public string firstName;
        public string lastName;
        public int yearsOfExperience;

       
        public void Member()
        {
            Console.WriteLine($"The employee is named {firstName} {lastName} and they have {yearsOfExperience} years of experience.");
        }
    }
}
