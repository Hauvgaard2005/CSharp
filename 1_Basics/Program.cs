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
    Text("\nthe little... thing... you were talking to jumps at you");
    slowText("\nWhat do you use to defend yourself\n");
    List<string> weapons = new List<string>();
    weapons.Add("A Stick");
    weapons.Add("An Entire Tree");
    weapons.Add("A Small Stone");
    weapons.Add("A Large Boulder");

Console.WriteLine("[1]" + weapons[0]);
Console.WriteLine("[2]" + weapons[1]);
Console.WriteLine("[3]" + weapons[2]);
Console.WriteLine("[4]" + weapons[3]);

int[] weaponsChoiceCheck = {1, 2, 3, 4};
weaponsTryAgain:
var weaponsChoice = Convert.ToInt32(Console.ReadLine());
while (!weaponsChoiceCheck.Contains(weaponsChoice)){
    Console.WriteLine("please enter a valid weapon of choice using the numbers 1, 2, 3 or 4");
    try {
        weaponsChoice = Convert.ToInt32(Console.ReadLine());
        if(weaponsChoiceCheck.Contains(weaponsChoice)){
            goto weaponAccepted;
        }

    }
    catch {
        Console.WriteLine("An error has occured, please try again");
        goto weaponsTryAgain;
    }
}
weaponAccepted:
switch (weaponsChoice){
    case 1:
        Text("you whack him with your stick but it does nothing and you die");
        goto end;
    case 2:
        Text("did you think you could life an entire tree? no... you cant... and you died");
        goto end;
    case 3: 
        Text("you throw the small stone and manage to hit the little gnelf, gnoblin or gnome (whatever it was) right in the eye and it runs away.");
        slowText("\nconglaturations... you live");
        goto end;
    case 4:
        Text("did you think you could life an entire bouler, let alone SWING it!? no... you cant... and you died");
        goto end;
}

    Console.ReadLine();
goto end;
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
end:

Console.ReadLine();