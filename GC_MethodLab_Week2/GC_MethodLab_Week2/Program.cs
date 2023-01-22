using DiceMethodLab;
bool Close = false;

Console.WriteLine("Welcome To Billy's Casino, where we only play this one game. Hope that's what you're into.\r\nWould you like to Roll? (y/n)");
String? UserRollInput = (Console.ReadLine());

if (UserRollInput is "Y")
{
    Close = false;
}
else if (UserRollInput is "y")
{ 
    Close = false;

}
else
{
    Close = true;
    Console.WriteLine("Thanks for Playing! Come again!");
}

while (!Close)
{
    int Die1Result = GetDiceRoll.DiceRoll();
    int Die2Result = GetDiceRoll.DiceRoll();
    int DieTotal = (Die1Result + Die2Result);
    string DiceComboNameResult = GetDiceComboName.DiceComboName(Die2Result, Die1Result);
    string DiceTotalNameResult = GetDiceTotalName.DiceTotalName(Die1Result, Die2Result);


    Console.WriteLine("You rolled a " + Die1Result + " and a " + Die2Result + " (" + DieTotal + " Total)");
    Console.WriteLine(DiceComboNameResult);
    Console.WriteLine(DiceTotalNameResult);
    Console.WriteLine("Would you like to Roll again? (y/n)");
    UserRollInput = (Console.ReadLine());
    if (UserRollInput is "Y")
    {
        Close = false;
    }
    else if (UserRollInput is "y")
    {
        Close = false;

    }
    else
    {
        Close = true;
        Console.WriteLine("Thanks for Playing! Come again!");
    }
}

