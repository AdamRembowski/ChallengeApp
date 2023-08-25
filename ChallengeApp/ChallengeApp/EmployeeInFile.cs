namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        protected const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            base.AddGrade(grade);
            Writer(grade);
        }
        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }
        public override void AddGrade(int grade)
        {
            base.AddGrade(grade);
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
            Reader();
            return base.GetStatistics();
        }
        public void Writer(float input)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(input);
            }
        }
        public void Reader()
        {
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        base.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
