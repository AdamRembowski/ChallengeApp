namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        protected const string fileName = "grades.txt";
        public override event GradeAddDelegate GradeAdded;
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }
        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(int grade)
        {
            base.AddGrade(grade);
        }
        public void Writer(float output)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(output);
            }
        }
        public void ClearFile()
        {
            File.Delete(fileName);
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Writer(grade);
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
        public override void AddGrade(string grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(char grade)
        {
            base.AddGrade(grade);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var gradeFromFile = float.Parse(line);
                        statistics.AddGrade(gradeFromFile);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
