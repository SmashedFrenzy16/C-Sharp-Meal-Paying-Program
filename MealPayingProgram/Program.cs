// See https://aka.ms/new-console-template for more information

using System.Transactions;

Console.ForegroundColor = ConsoleColor.DarkRed;

string stringUsers;
int users;
int userNumber = 0;

string stringTotalPay;
double totalPay;

double pay;
string stringPay;

string continuePay;
string stringTip;
double tip = 0;

void payment()
{

    for (int i = 0; i < users; i++)
    {

        if (userNumber >= users)
        {
            userNumber = 0;
        }

        userNumber++;

        pay = 0;
        stringPay = "";

        Console.Write($"Hello, Person {userNumber}! Enter the amount to pay: ");

        stringPay = Console.ReadLine();

        pay = (int)Convert.ToInt64(stringPay);

        totalPay = totalPay - pay;

        Console.WriteLine($"This is the amount left to pay: £{totalPay}. If your remaining amount to be paid is negative, it will not be charged extra from £0, and you will be asked if you want to tip. If you want to pay extra, please tip at the end. If you pay for your food exactly, you won't get a chance to tip.");


    }

}

Console.WriteLine("Welcome to Fruit Diner!");

Console.Write("Enter in the total bill of your food (£s): ");

stringTotalPay = Console.ReadLine();

totalPay = Convert.ToDouble(stringTotalPay);

Console.Write("Enter the amount of customers paying: ");

stringUsers = Console.ReadLine();

users = (int)Convert.ToInt64(stringUsers);

payment();

while (totalPay > 0)
{

    payment();

} 

if (totalPay == 0)
{

    Console.WriteLine("You have paid the bill!");

} else if (totalPay < 0)
{
    Console.Write("Do you want to give a tip (y/n): ");

    continuePay = Console.ReadLine();

    if (continuePay == "Y" || continuePay == "y")
    {
        Console.Write("Enter tip amount (£s): ");


        stringTip = Console.ReadLine();

        tip = Convert.ToDouble(stringTip);

        Console.WriteLine($"This is your tip for the restaurant: £{tip}. Thank you for eating with us!");

    }
    else
    {
        
    }

}
