// See https://aka.ms/new-console-template for more information

// unary ++, --, +, -

int numOperator = 4;
Console.WriteLine(numOperator++);
Console.WriteLine(numOperator--);

Console.WriteLine(++numOperator);
Console.WriteLine(--numOperator);

Console.WriteLine(numOperator);
Console.WriteLine(-numOperator);
Console.WriteLine(-(numOperator));

// binary *, /, +, -

var sum = 2 + 2;
var subtraction = 7 - 2;
var division = 25 / 2;
var divisionReal = 2 % 2;
var multiplication= 2 * 2;

// operator arithmetic <, >, <=, >=
Console.WriteLine(4 > 5);
Console.WriteLine(5 >= 5);
Console.WriteLine(4 < 5);
Console.WriteLine(4 <= 5);

// operator equalities ==, !=

Console.WriteLine(4 != 5);
Console.WriteLine(4 == 5);

// operator logic AND &&, OR ||

Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(true || true);
Console.WriteLine(false || false);

Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(true && true);
Console.WriteLine(false && false);