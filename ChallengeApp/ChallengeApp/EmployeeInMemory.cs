namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(string grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(int grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(char grade)
        {
            base.AddGrade(grade);
        }
        public override Statistics GetStatistics()
        {
            return base.GetStatistics();
        }
    }
}

