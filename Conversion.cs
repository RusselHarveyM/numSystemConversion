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
                    break;
            }

        }
        public void toOctal(string number, string from) {
            switch (from)
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }
        }
        public void toHexa(string number, string from)
        {
            switch (from)
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }
        }
        public void toDecimal(string number, string from)
        {
            switch (from)
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
            }
        }
    }
}
