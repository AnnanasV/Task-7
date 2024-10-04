/*
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
*/

var circle = new Shapes.Circle();
circle.Radius = 1;
Console.WriteLine(circle.ToString());

var rectangle = new Shapes.Rectangle();
rectangle.X = 3;
rectangle.Y = 4;
Console.WriteLine(rectangle.ToString());

var triangle = new Shapes.Triangle();
triangle.X = 3;
triangle.Y = 4;
triangle.Z = 5;
Console.WriteLine(triangle.ToString());