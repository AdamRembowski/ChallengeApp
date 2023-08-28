namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddDelegate(object sender, EventArgs args);
        public abstract event GradeAddDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
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
        public abstract void AddGrade(float grade);
        public virtual void AddGrade(string grade)
        {
            try
            {
                float input = Convert.ToSingle(grade);
                AddGrade(input);
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
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Char");
            }
        }
        public abstract Statistics GetStatistics();
    }
}
