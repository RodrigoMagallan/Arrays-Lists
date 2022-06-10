//When you post a message on facebook, depoending on the number of poeple who like
//your post, facebook display differente information:
//if no one likes your post, it doesn't display anything
//If only one person likes your post, it idsplays:[]Friend's name} likes your post
//If two people like your post, it display[friend1] and [friend2] like your post
//if more than two people like your post, it displays[Friend1],[Friend2] and [Number of Other people] other like your post.
//Write a program and continuosly ask the user to enter diferent names, until the user presses enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern

var names = new List<string>();

while (true)
{
    Console.WriteLine("Enter a name: ");
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    names.Add(input);
}
var qtyOfFriends = names.Count;
    switch (qtyOfFriends)
    {
        case 0:
            Console.WriteLine(" ");
            break;
        case 1:
            Console.WriteLine("{0} likes your post", names[0]);
            break;
        case 2:
            Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            break;
        default:
            Console.WriteLine("{0},{1} and {2} Other friends", names[0], names[2], names.Count - 2);
            break;

    }

