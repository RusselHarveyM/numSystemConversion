// See https://aka.ms/new-console-template for more information

using numberSystemConversion;

var conversion = new Conversion();
var isStart = true;

while (isStart)
{

    Console.WriteLine("From Number System: \n[1] Decimal\n[2] Binary\n[3] Octal\n[4] HexaDecimal\n[5] Exit");
    var fromChoice = Console.ReadLine();
    if (fromChoice == "5")
        break;

    Console.WriteLine("To Number System: \n[1] Decimal\n[2] Binary\n[3] Octal\n[4] HexaDecimal\n[5] Exit");
    var toChoice = Console.ReadLine();
    if (toChoice == "5")
        break;

    Console.WriteLine("Enter number: ");
    var number = Console.ReadLine();


    switch(toChoice)
    {
        case "1":
            conversion.toDecimal(number, fromChoice);
            break;
        case "2":
            conversion.toBinary(number, fromChoice);
            break;
        case "3":
            conversion.toOctal(number, fromChoice);
            break;
        case "4":
            conversion.toHexa(number, fromChoice);
            break;

    }
    Console.ReadLine();
    Console.Clear();
};









