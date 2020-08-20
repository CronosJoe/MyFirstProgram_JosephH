using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main()
        {
            Employee Jim = new Employee();
            Jim.firstName = "jim";
            Jim.lastName = "john";
            Jim.yearsOfExperience = 5;
            Jim.Member();
            Console.WriteLine();
        }
    }
   
}
