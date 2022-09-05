void Text(string text, int time = 50)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
void slowText(string text, int time = 100)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
Text("Do you know...\n");
string text2 = "...\n";
foreach (char c in text2)
{
    Console.Write(c);
    Thread.Sleep(1000);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
slowText("the Muffin Man?\n");
string muffinManInput = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;
string areYou = "";

if (muffinManInput == "yes")
{
    while (areYou != "yes" && areYou != "no")
    {
        
        Text("Are you "); 
        slowText("the Muffin Man?\n");
        areYou = Console.ReadLine();
    }
}
if (areYou == "yes")
{
    Text("i knew it... leave now or you shall suffer the consequenses");
    Console.ForegroundColor = ConsoleColor.Gray;
    Thread.Sleep(1000);
    Text("the little... thing... you were talking to jumps at you");
    slowText("\nWhat do you use to defend yourself");
    List<string> weapons = new List<string>();
    weapons.Add("Stick");
    weapons.Add("An entire tree");
    weapons.Add("A small stone");
    weapons.Add("a large boulder");

    Console.ReadLine();
}
if (areYou == "no")
{
    Text("oh... ok...");
    string shrekScript = System.IO.File.ReadAllText(@"C:\Users\mathi\OneDrive\1Hansenberg\2. G\Programmering\Files\ShrekScript.txt");
    slowText("prove it then...\n");
    string scriptGuess = Console.ReadLine();
    if (scriptGuess != shrekScript)
    {
        foreach(char c in shrekScript){
            Console.Write(c);
            Thread.Sleep(10);
        }
    }
    Text("\n\n\nThat was the entire shrek script... damn... good job");
    Console.ReadLine();
}

Console.ReadLine();