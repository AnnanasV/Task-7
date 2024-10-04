var num1 = new ArythmeticOverload.ComplexNumber(7, -4);
var num2 = new ArythmeticOverload.ComplexNumber(3, 2);
var num3 = new ArythmeticOverload.ComplexNumber(7, -4);

Console.WriteLine((num1 / num2).ToString());
Console.WriteLine((num1 * num2).ToString());
Console.WriteLine((num1 - num2).ToString());
Console.WriteLine((num1 + num2).ToString());

Console.WriteLine("===============");

Console.WriteLine(num1 == num3);
Console.WriteLine(num1 != num2);