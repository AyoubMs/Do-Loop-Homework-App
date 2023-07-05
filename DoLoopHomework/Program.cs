
string? firstName = string.Empty;
string formattedName = string.Empty;
bool isInvalidName;

do
{
    Console.Write("What is your name (or type exit to quit): ");
    firstName = Console.ReadLine();
    isInvalidName = int.TryParse(firstName, out int falseNameNumber);
    if (isInvalidName)
    {
        Console.WriteLine("That's not a valid name.");
    }
    if (firstName.ToLower() == "tim")
    {
        formattedName = $"Professor {firstName}";
    }
    else if (!isInvalidName)
    {
        formattedName = $"Student {firstName}";
    }

    if (firstName.ToLower() != "exit" && !isInvalidName)
    {
        Console.WriteLine($"Welcome, {formattedName}");
    }
} while (firstName.ToLower() != "exit");

