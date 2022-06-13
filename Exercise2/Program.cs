Console.WriteLine("Pon tu palabra que quieras voltear: ");
string? notReversed = Console.ReadLine();


var reversed = notReversed.ToCharArray()
    .Reverse();
Console.WriteLine(new string(reversed.ToArray()));


