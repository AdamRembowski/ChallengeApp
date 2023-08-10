using ChallengeApp;

List<Employee> employees = new List<Employee>();

employees.Add(new Employee("Adam", "Rembowski", 37));
employees.Add(new Employee("Tadeusz", "Nowak", 34));
employees.Add(new Employee("Aleksandra", "Szulc", 30));

employees[0].AddScore(10); employees[0].AddScore(7); employees[0].AddScore(3); employees[0].AddScore(8); employees[0].AddScore(6);
employees[1].AddScore(6); employees[1].AddScore(8); employees[1].AddScore(5); employees[1].AddScore(9); employees[1].AddScore(3);
employees[2].AddScore(8); employees[2].AddScore(6); employees[2].AddScore(5); employees[2].AddScore(9); employees[2].AddScore(9);

List<Employee> winner = new List<Employee>();
winner.Add(employees[0]);
int result = employees[0].Result;
foreach (Employee employee in employees)
{
    if (result < employee.Result)
    {
        result = employee.Result;
        winner.Clear();
        winner.Add(employee);
    }
    else if (employee.Result == winner[0].Result && employee != winner[0])
    {
        winner.Add(employee);
    }
}
foreach (Employee win in winner)
{
    Console.WriteLine("punktów: " + result + " - " + win.Name + " " + win.Surname + " lat:" + win.Age);
}