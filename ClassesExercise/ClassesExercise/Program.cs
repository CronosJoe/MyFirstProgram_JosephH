using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main()
        {
            Employee jim = new Employee();
            jim.firstName = "jim";
            jim.lastName = "john";
            jim.yearsOfExperience = 5;
            jim.Member();

            Employee jacob = new Employee();
            jacob.firstName = "Jacob";
            jacob.lastName = "Jennings";
            jacob.yearsOfExperience = 10;
            jacob.Member();

            Employee joseph = new Employee();
            joseph.firstName = "Joseph";
            joseph.lastName = "Huskey";
            joseph.yearsOfExperience = 7;
            Team crew = new Team();
            Employee[] team = new Employee[2];
            team[0] = jim;
            team[1] = jacob;
            crew.team = team;
            crew.leader = joseph;
            crew.averageExperience(team);


            Console.ReadLine();
        }
    }
   
}
