namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public bool sex { get; private set; } //Is Man = true; Woman = false
        public Person(string name, string surname, int age, bool sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }
}
