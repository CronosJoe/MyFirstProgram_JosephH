using System;
namespace ClassesExercise
{
    public class Team
    {
       public Employee[] team;
        public Employee leader;

        public void averageExperience(Employee[] crew)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0;i<crew.Length;i++)
            {
                count++;
                sum += crew[i].yearsOfExperience;
            }
            sum += leader.yearsOfExperience;
            sum /= (count+1);
            Console.WriteLine($"The average years of experience for this team: {sum}");
        }
    }
}
