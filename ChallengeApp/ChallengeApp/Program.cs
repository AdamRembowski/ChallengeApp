string Name = "Adam";
bool IsMan = true;
int Age = 37;

if (IsMan && Age >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}
else if (!IsMan && Age >= 18)
{
    Console.WriteLine("Pełnoletnia Kobieta");
}
else
{
    Console.WriteLine("Niepełnoletnie dziecko");
}

if (IsMan && Age < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (!IsMan && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (Name == "Adam" && Age == 37)
{
    Console.WriteLine(Name + ", lat " + Age);
}
else
{
    Console.WriteLine("ktoś inny");
}