

Dictionary<int, string> employees = new Dictionary<int, string>();
bool validId;
int id;
string name;

employees.Add(101, "Tim");
employees.Add(102, "Bob");
employees.Add(103, "Sue");

do
{
    Console.Write("Enter an employee ID # to get the name of the employee: ");
    string idText = Console.ReadLine();
    bool validNum = Int32.TryParse(idText, out id);

    validId = employees.TryGetValue(id, out name);

    if (!validId)
    {
        Console.WriteLine("The ID entered is not a valid ID.");
    }

} while (validId != true);

Console.WriteLine($"The employee with ID # {id} is {name}.");
