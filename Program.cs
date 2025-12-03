using System;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace proj2
{
    class Program
    {
        static void Main()
        {
            bool active = true;
            string example;
            Console.Clear();
            while (active == true)
            {
                Console.WriteLine("Write an example and press enter calculate the result enter, ensure there are only numbers and signs used in example, NO CHARACTERS. In order to leave type 'b' character and press enter.");
                switch (example = Console.ReadLine())
                {
                    case "b":
                        active = false;
                        break;
                    default:
                        //Console.WriteLine(ReadExample(example));
                        ReadExample(example);
                        break;
                }
            }
        }
        static public int ReadExample(string Example)
        {
            string temp = "";
            int numberTemp = 0;
            List<int> numbers = new List<int> { };
            List<char> sign = new List<char> { };
            foreach (char var in Example.ToCharArray())
            {
                switch (var)
                {
                    case '0':
                        temp += "0";
                        break;
                    case '1':
                        temp += "1";
                        break;
                    case '2':
                        temp += "2";
                        break;
                    case '3':
                        temp += "3";
                        break;
                    case '4':
                        temp += "4";
                        break;
                    case '5':
                        temp += "5";
                        break;
                    case '6':
                        temp += "6";
                        break;
                    case '7':
                        temp += "7";
                        break;
                    case '8':
                        temp += "8";
                        break;
                    case '9':
                        temp += "9";
                        break;
                    default:
                        if (int.TryParse(temp, out numberTemp) == true)
                        {
                            numbers.Add(numberTemp);
                            temp = "";
                        }
                        switch (var)
                        {
                            case '+':
                                sign.Add('+');
                                break;
                            case '-':
                                sign.Add('-');
                                break;
                            case '*':
                                sign.Add('*');
                                break;
                            case '/':
                                sign.Add('/');
                                break;
                            default:
                                Console.Error.WriteLine("Wrong character detected");
                                return 0;
                        }
                        break;
                }
            }
            return Calculator(numbers, sign);
        }
        static int Calculator(List<int> numbers, List<char> signs)
        {
            int result = 0;
            foreach (int v in numbers)
            {
                Console.WriteLine(v);
            }
            foreach (char s in signs)
            {
                Console.WriteLine(s);
            }
            return result;
        }
    }
}