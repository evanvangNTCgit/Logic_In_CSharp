/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/

/*
int a = 7;
int b = 6;
System.Console.WriteLine(a != b);
string s1 = "Hello";
string s2 = "Hello";
System.Console.WriteLine(s1 != s2);
*/

/*
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
System.Console.WriteLine(discount);
*/

/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

/*
Random random = new Random();
int coinFlip = random.Next(1, 3);

System.Console.WriteLine(coinFlip == 1 ? "Heads" : "Tails");
*/

string permission = "Admin|Manager";
int level = 57;
string message;

/*
Note to self while this did pass the test...
I should have done some nested if statements
Because a user can be both an admin AND a manager.
*/

if (permission.Contains("Admin") && level > 55)
{
    message = "Welcome, Super Admin user.";
}
else if (permission.Contains("Admin") && level <= 55)
{
    message = "Welcome, Admin user.";
}
else if (permission.Contains("Manager") && level >= 20)
{
    message = "Contact an Admin for access.";
}
else if (permission.Contains("Manager") && level < 20)
{
    message = "You do not have sufficient privilages.";
}
else
{
    message = "You do not have sufficient privileges.";
}

System.Console.WriteLine(message);