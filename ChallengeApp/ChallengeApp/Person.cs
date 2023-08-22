namespace ChallengeApp
{
    public abstract class Person
    {
        protected string Name { get; private set; }
        protected string Surname { get; private set; }
        protected int Age { get; private set; }
        protected bool Sex { get; private set; } //Is Man = true; Woman = false
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
