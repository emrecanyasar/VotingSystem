using Sandbox;

var yes = new Counter("Yes", 4);
var no = new Counter("No", 4);
var maybe = new Counter("Maybe", 4);

var manager=new CounterManager( yes, no, maybe );

int total =yes.Count+no.Count+maybe.Count;

var yesPercent = yes.GetPercent(total) ;
var noPercent = no.GetPercent(total);
var maybePercent = maybe.GetPercent(total); ;

var excess = Math.Round(100 - yesPercent - noPercent - maybePercent,2);

Console.WriteLine($"Excess:{excess}");

if (yes.Count>no.Count)
{
    if (yes.Count>maybe.Count)
    {
        Console.WriteLine($"Yes Won");
        yesPercent += excess;
    }
    else if(maybe.Count>yes.Count)
    {
        Console.WriteLine($"maybe Won");
        maybePercent += excess;
    }
    else
    {
        Console.WriteLine($"Yes -DRAW- Maybe");
        noPercent += excess;

    }
}
else if (no.Count > yes.Count)
{
    if (no.Count > maybe.Count)
    {
        Console.WriteLine($"No Won");
        noPercent += excess;

    }
    else if (maybe.Count > no.Count)
    {
        Console.WriteLine($"maybe Won");
        maybePercent += excess;

    }
    else
    {
        Console.WriteLine($"No -DRAW- Maybe");
        yesPercent += excess;

    }
}
else if (maybe.Count > yes.Count)
{
    Console.WriteLine($"Maybe Won");
    maybePercent += excess;

}
else if(maybe.Count == yes.Count)
{
    Console.WriteLine($"No -DRAW- Yes -DRAW- Maybe");
    maybePercent += excess;
}
else
{
    Console.WriteLine($"No -DRAW- Yes");
    maybePercent += excess;
}

Console.WriteLine($"Yes Counts:{yes.Count},Percentage:{Math.Round(yesPercent, 2)}%");
Console.WriteLine($"No Counts:{no.Count},Percentage:{Math.Round(noPercent, 2)}%");
Console.WriteLine($"No Counts:{maybe.Count},Percentage:{Math.Round(maybePercent, 2)}%");
Console.WriteLine($"Total Percentage:{ Math.Round(yesPercent+noPercent+maybePercent, 2)}%");