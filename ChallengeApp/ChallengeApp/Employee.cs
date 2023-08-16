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
            this.grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var statististics = new Statistics();
            statististics.Average = 0;
            statististics.Max = float.MinValue;
            statististics.Min = float.MaxValue;

            foreach(var grade in this.grades) 
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
