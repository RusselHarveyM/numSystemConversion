using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSystemConversion
{
    public class Conversion
    {
        public Conversion() { }
        public void toBinary(string number, string from)
        {
            int[] a = new int[10];
            int i = 0;
            switch (from)
            {
                case "1":
                    int newNum = int.Parse(number);
                    for (i = 0; newNum > 0; i++)
                    {
                        a[i] = newNum % 2;
                        newNum = newNum / 2;
                    }
                    Console.Write("Binary of the given number= ");
                    for (i = i - 1; i >= 0; i--)
                    {
                        Console.Write(a[i]);
                    }
            
            break;
                case "2":
                    Console.Write("Binary of the given number= ");
                    Console.Write(number);
                    break;
                case "3":
                    string binary = "";
                    while (i < number.Length)
                    {
                        char c = number[i];
                        switch (c)
                        {
                            case '0':
                                binary += "000";
                                break;
                            case '1':
                                binary += "001";
                                break;
                            case '2':
                                binary += "010";
                                break;
                            case '3':
                                binary += "011";
                                break;
                            case '4':
                                binary += "100";
                                break;
                            case '5':
                                binary += "101";
                                break;
                            case '6':
                                binary += "110";
                                break;
                            case '7':
                                binary += "111";
                                break;
                            default:
                                System.Console.WriteLine("\nInvalid Octal Digit " + number[i]);
                                break;
                        }
                        i++;
                    }
                    System.Console.WriteLine("Binary value is: " + binary);
                    break;
                case "4":
                    string binarystring = String.Join(String.Empty,
                      number.Select(
                        c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                      )
                    );
                    System.Console.WriteLine("Binary value is: " + binarystring);
                    break;
            }

        }
        public void toOctal(string number, string from) {
            int convertnumber;
            string octalNumber;

            switch (from)
            {
                case "1":
                    convertnumber = Convert.ToInt32(number, 2);
                    if (convertnumber == 0)
                    {
                        Console.Write("Octal of the given number= " + convertnumber);
                        return;
                    }

                    octalNumber = "";
                    while (convertnumber > 0)
                    {
                        int remainder = convertnumber % 8;
                        octalNumber = remainder.ToString() + octalNumber;
                        convertnumber /= 8;
                    }
                    Console.Write("Octal of the given number= " + octalNumber);
                    //decimal
                    break;
                case "2":
                    convertnumber = Convert.ToInt32(number, 2);
                    Console.WriteLine("Octal of the given number= " + Convert.ToString(convertnumber, 8)); // prints "23"
                    //binary
                    break;
                case "3":
                    //octal
                    Console.Write("Octal of the given number= " + number);
                    break;
                case "4":
                    //hexa
                    int decimalNumber = Convert.ToInt32(number, 16);

                    if (decimalNumber == 0)
                    {
                        Console.Write("Octal of the given number= " + number);
                        return;
                    }

                    octalNumber = "";
                    while (decimalNumber > 0)
                    {
                        int remainder = decimalNumber % 8;
                        octalNumber = remainder.ToString() + octalNumber;
                        decimalNumber /= 8;
                    }
                    Console.Write("Octal of the given number= " + octalNumber);
                    break;
            }
        }
        public void toHexa(string number, string from)
        {
            switch (from)
            {
                case "1":
                    int decimalNumber = int.Parse(number);
                    string hexaNumber = decimalNumber.ToString("X");
                    Console.Write("Hexadecimal of the given number= " + hexaNumber);
                    break;
                case "2":
                    int binaryNumber = Convert.ToInt32(number, 2);
                    string hexaNumberFromBinary = binaryNumber.ToString("X");
                    Console.Write("Hexadecimal of the given number= " + hexaNumberFromBinary);
                    break;
                case "3":
                    int octalToDecimal = Convert.ToInt32(number, 8);
                    string hexaNumberFromOctal = octalToDecimal.ToString("X");
                    Console.Write("Hexadecimal of the given number= " + hexaNumberFromOctal);
                    break;
                case "4":
                    Console.Write("Hexadecimal of the given number= " + number);
                    break;
            }
        }

        public void toDecimal(string number, string from)
        {
            switch (from)
            {
                case "1":
                    int decimalNumber = int.Parse(number);
                    Console.Write("Decimal of the given number= " + decimalNumber);
                    break;
                case "2":
                    int binaryNumber = Convert.ToInt32(number, 2);
                    Console.Write("Decimal of the given number= " + binaryNumber);
                    break;
                case "3":
                    int octalNumber = Convert.ToInt32(number, 8);
                    Console.Write("Decimal of the given number= " + octalNumber);
                    break;
                case "4":
                    int hexaNumber = Convert.ToInt32(number, 16);
                    Console.Write("Decimal of the given number= " + hexaNumber);
                    break;
            }
        }
    }
}
