
//IF
int age = 25;

if (age > 10)
{
    Console.WriteLine("age is greater than 10");
}

//IF ELSE
int myage = 25;

if (myage > 18)
{
    Console.WriteLine("your legal");
} else
{
    Console.WriteLine("your not legal");
}

//IF ELSE IF
int yourage = 25;

if (yourage > 18)
{
    Console.WriteLine("your legal");
}
else if (yourage == 18)
{
    Console.WriteLine("your just legal");
}
else
{
    Console.WriteLine("your not legal");
}

//SWITCH
string  day = "Monday";
switch (day)
{
    case "Sunday":
        Console.WriteLine("It is Sunday");
        break;
    case "Monday":
        Console.WriteLine("It is Monday");
        break;
    case "Tuesday":
        Console.WriteLine("It is Tuesday");
        break;
    case "Wednesday":
        Console.WriteLine("It is Wednesday");
        break;
    case "Thursday":
        Console.WriteLine("It is Thursday");
        break;
    case "Friday":
        Console.WriteLine("It is Friday");
        break;
    case "Saturday":
        Console.WriteLine("It is Saturday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

//WHILE
//WhileLoopGame:  always give a number and I will give you the square of that number until you give me 0 and then I will stop

//Console.WriteLine("Enter a number");
//int number = Convert.ToInt32(Console.ReadLine());
//bool start = true;  
//    while (start)
//    {
//        if (number == 0)
//        {
//            Console.WriteLine(">>>Exit<<<");
//            start = false;
//        }
//        else
//        {
//                Console.WriteLine("Square of {0} is {1}", number, number * number);
//                Console.WriteLine("Enter a new number");
//                number = Convert.ToInt32(Console.ReadLine());
//        }
//    }

    //DO WHILE
    //DoWhileLoopGame:  always give a number and I will give you the square of that number until you give me 0 and then I will stop

    Console.WriteLine("Enter a number");
    int number2 = Convert.ToInt32(Console.ReadLine());
    bool start2 = true;
    do
    {
        if (number2 == 0)
        {
            Console.WriteLine(">>>Exit<<<");
            start2 = false;
        }

        //check if the number is int
        else if ( )
        {   
            Console.WriteLine("Invalid number");
            Console.WriteLine("Enter a new number");
            number2 = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Square of {0} is {1}", number2, number2 * number2);
            Console.WriteLine("Enter a new number");
            number2 = Convert.ToInt32(Console.ReadLine());
        }
    } while (start2);


//ternary operators for if else

//int number3 = 10;
//string result = (number3 % 2 == 0) ? "Even Number" : "Odd Number";
//Console.WriteLine(result);

