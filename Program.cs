float baseSalary = 5000;
float hra = 0.30F;

float netSalary = (baseSalary - (baseSalary * hra));

Console.WriteLine("Base Salary : " + baseSalary);
Console.WriteLine("Net Salary : " + netSalary);

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its very cold outside");
else
    Console.WriteLine("Its moderate outside");

bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;

if (isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
    Console.WriteLine("Stop purchase");