// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int secondNum = int.Parse(Console.ReadLine());

// What do you want to do with those numbers?
// [A]dd
// [S]ubtract
// [M]ultiply

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userOption = Console.ReadLine().ToLower();

// if (userOption == "a")
// {
//     Console.WriteLine($"{firstNum}+{secondNum}={firstNum+secondNum}");
// }
// else if (userOption == "s")
// {
//     Console.WriteLine($"{firstNum}-{secondNum}={firstNum-secondNum}");
// }
// else if (userOption == "m")
// {
//     Console.WriteLine($"{firstNum}*{secondNum}={firstNum*secondNum}");
// }
// else
// {
//     Console.WriteLine("Invalid option");
// }

// switch (userOption)
// {
//     case "a":
//     Console.WriteLine($"{firstNum}+{secondNum}={firstNum+secondNum}");
//     break;
//     case "s":
//     Console.WriteLine($"{firstNum}-{secondNum}={firstNum-secondNum}");
//     break;
//     case "m":
//     Console.WriteLine($"{firstNum}*{secondNum}={firstNum*secondNum}");
//     break;
//     default:
//     Console.WriteLine("Invalid option");
//     break;
// }

string RepeatCharacter(char character, int targetLength)
        {
            //your code goes here
            int i=0;
            string result="";
            do{
                result = result + character;
                i++;
            }
            while(i<targetLength);
            
return result;
        }
