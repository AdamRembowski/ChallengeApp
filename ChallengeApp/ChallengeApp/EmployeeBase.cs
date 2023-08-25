namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddDelegate(object sender, EventArgs args);
        public event GradeAddDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public virtual void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public virtual void AddGrade(double grade)
        {
            float result = Convert.ToSingle(grade);
            this.AddGrade(result);
        }
        public virtual void AddGrade(int grade)
        {
            float result = Convert.ToSingle(grade);
            this.AddGrade(result);
        }
        public virtual void AddGrade(string grade)
        {
            try
            {
                double.TryParse(grade, out double result);
                this.grades.Add(Convert.ToSingle(result));
            }
            catch
            {
                throw new Exception("invalid grade value");
            }
        }
        public virtual void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Char");
            }
        }
        public virtual Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
