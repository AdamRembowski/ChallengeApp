using ChallengeApp;

List<Employee> employees = new List<Employee>();

employees.Add(new Employee("Adam", "Rembowski"));
employees.Add(new Employee("Tadeusz", "Nowak"));
employees.Add(new Employee("Aleksandra", "Szulc"));

employees[0].AddGrade(10); employees[0].AddGrade(7); employees[0].AddGrade(3); employees[0].AddGrade(8); employees[0].AddGrade(6);
employees[1].AddGrade(6); employees[1].AddGrade(8); employees[1].AddGrade(5); employees[1].AddGrade(9); employees[1].AddGrade(3);
employees[2].AddGrade(8); employees[2].AddGrade(6); employees[2].AddGrade(5); employees[2].AddGrade(9); employees[2].AddGrade(9);

//var employee = new Employee("", "");
//var statistics = employee.GetStatistics();

List<Employee> winner = new List<Employee>();
winner.Add(employees[0]);
var result = employees[0].GetStatistics().Average;
foreach (Employee employee in employees)
{
    if (result < employee.GetStatistics().Average)
    {
        result = employee.GetStatistics().Average;
        winner.Clear();
        winner.Add(employee);
    }
    else if (employee.GetStatistics().Average == winner[0].GetStatistics().Average && employee != winner[0])
    {
        winner.Add(employee);
    }
}
foreach (Employee win in winner)
{
    Console.WriteLine($"punktów: {result} {win.Name} { win.Surname}");
}