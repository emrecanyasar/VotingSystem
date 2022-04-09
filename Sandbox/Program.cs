int yesCounter=0;
int noCounter=0;
Console.WriteLine($"Yes Counts:{yesCounter}");
Console.WriteLine($"No Counts:{noCounter}");

if (yesCounter>noCounter)
{
    Console.WriteLine($"Yes Won");
}
else if (noCounter > yesCounter)
{
    Console.WriteLine($"No Won");
}
else
{
    Console.WriteLine($"DRAW");
}
