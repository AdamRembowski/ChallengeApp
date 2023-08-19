using ChallengeApp;

var employee = new Employee("Adam", "Rembowski");

Console.WriteLine("Witaj kochany sprawdzaczu zadania domowego :)");
Console.WriteLine("<><><><><><><><><><><><><><><><<><><><><><><>");
Console.WriteLine();
while (true)
{
    Console.WriteLine("Wprowadź kolejną ocenę lub wciśnij 'q' aby zakończyć");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (input != null && input != "")
    {
        var indexer = input.ToCharArray().Length;
        if (indexer <= 1)
        {            
            if (int.TryParse(input, out int result))
            {
                employee.AddGrade(input);
            }
            else
            {
                char inputChar = Convert.ToChar(input);
                employee.AddGrade(inputChar);
            }
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    else
    {
        Console.WriteLine("nie wprowadzono oceny");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


