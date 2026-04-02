// Variables
string nombreCliente;
string[] productos = new string[5];
int[] cantidades = new int[5];
double[] precios = new double[5];
double[] subtotales = new double[5];
double totalGeneral = 0;

// Nombre del cliente
Console.Write("Ingrese nombre del cliente: ");
nombreCliente = Console.ReadLine();

// Nombre de 5 productos
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\nProducto {i + 1}");

    Console.Write("Nombre del producto: ");
    productos[i] = Console.ReadLine();

    Console.Write("Cantidad: ");
    cantidades[i] = int.Parse(Console.ReadLine());

    Console.Write("Precio: ");
    precios[i] = double.Parse(Console.ReadLine());

    // Cálculo del subtotal
    subtotales[i] = cantidades[i] * precios[i];

    // total
    totalGeneral += subtotales[i];

}