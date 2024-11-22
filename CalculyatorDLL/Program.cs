using CalculyatorDLL;

Calculator calculator = new Calculator();

double num1 = 20;
double num2 = 5;

Console.WriteLine("Toplama: " + calculator.Add(num1, num2));
Console.WriteLine("Çıxma: " + calculator.Subtract(num1, num2));
Console.WriteLine("Vurma: " + calculator.Multiply(num1, num2));
Console.WriteLine("Bölmə: " + calculator.Divide(num1, num2));
