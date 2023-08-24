using ChallengeApp;

var employee = new EmployeeInMemory("Adam", "Rembowski");

Console.WriteLine("Witaj kochany sprawdzaczu zadania domowego :)");
Console.WriteLine("<><><><><><><><><><><><><><><><<><><><><><><>");
Console.WriteLine();


employee.GradeAdded += EmployeeGradeAdded;
employee.AddGrade(0.5f);

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


//while (true)
//{
//    Console.WriteLine("Wprowadź kolejną ocenę lub wciśnij 'q' aby zakończyć");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    else if (input != null && input != "")
//    {
//        var indexer = input.ToCharArray().Length;
//        if (indexer <= 1) // sprawdzam czy jest więcej niż jeden znak
//        {
//            if (double.TryParse(input, out double result))
//            {
//                try
//                {
//                    employee.AddGrade(result); //jeśli znak jest liczbą
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//            else //jeśli znak nie jest liczbą
//            {
//                try
//                {
//                    char inputChar = Convert.ToChar(input);
//                    employee.AddGrade(inputChar);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//        }
//        else // jeśli jest więcej znaków
//        {
//            try
//            {
//                employee.AddGrade(input);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }
//    } //jeśli nie wprowadzono żadnego ciągu znaków
//    else
//    {
//        Console.WriteLine("nie wprowadzono oceny");
//    }
//}
//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average(L): {statistics.AverageLetter}");
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");


