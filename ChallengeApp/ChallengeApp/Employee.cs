using System;
namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (double.TryParse(grade, out double result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String does not contain correct value");
            }
        }
        public void AddGrade(double grade)
        {
            float result = Convert.ToSingle(grade);
            this.AddGrade(result);
        }
        public Statistics GetStatistics()
        {
            var statististics = new Statistics();
            statististics.Average = 0;
            statististics.Max = float.MinValue;
            statististics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statististics.Max = Math.Max(statististics.Max, grade);
                statististics.Min = Math.Min(statististics.Min, grade);
                statististics.Average += grade;
            }
            statististics.Average /= this.grades.Count;
            return statististics;
        }
    }
}
