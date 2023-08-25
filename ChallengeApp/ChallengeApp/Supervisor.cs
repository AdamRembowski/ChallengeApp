using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public List<float> grades = new List<float>();
        public event GradeAddDelegate GradeAdded;
        public string Name => "Adam";
        public string Surname => throw new NotImplementedException();
        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "5":
                    this.grades.Add(100);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break; 
                case "4":
                    this.grades.Add(60);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(65);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;

            }
        }
        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            return statistics;
        }
    }
}
