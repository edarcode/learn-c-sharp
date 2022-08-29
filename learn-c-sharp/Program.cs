// Calcular el area de un circulo. Debe recibir por consola el radio.

Console.WriteLine("Digite el radio del circulo");

string inputRadio =  Console.ReadLine();
double radio = double.Parse(inputRadio);
double area = Math.Pow(radio,2) * Math.PI;

Console.WriteLine($"El área de un círculo con radio {radio} es: {area}");
