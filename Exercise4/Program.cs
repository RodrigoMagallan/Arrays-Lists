//write a program and ask the user to enter a number or type "Quit" to exit. The list of number bay include duplicates. Display the unique numbers that the user has entered

var newList = new List<int>();

string quit = "quit";
while (true)
{
    Console.WriteLine("Enter a number or type quit to display: ");

    var thingEntered = Console.ReadLine();
    if (!thingEntered.Equals(quit))
    {
        var numberEntered = Convert.ToInt32(thingEntered);
        newList.Add(numberEntered);
        continue;
    }
    else
    {
        break;
    }
}


newList = newList.Distinct().ToList();
Console.WriteLine("You list: ");
foreach (var n in newList)
{
    Console.WriteLine(n);
}