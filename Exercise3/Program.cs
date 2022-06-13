//Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display and error message and ask the user to retry. Once the user succesufully enter 5 unique numbers, sort them and display the result on the console.

var numberList = new List<int>();

while (true)
{
    if (numberList.Count < 5) {

        Console.WriteLine("Enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());
        if (numberList.Contains(num) == true)
        {
            Console.Clear();
            numberList.Clear();
            Console.WriteLine("Error try again");
            continue;
        }
        else
        {
            numberList.Add(num);
        }
        
    }
    else
    {
        break;
    }
    
}
Console.WriteLine("The list sorted: ");
numberList.Sort();
foreach (var n in numberList)
{
    Console.WriteLine(n);
}
