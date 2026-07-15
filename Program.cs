using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre:Sebastian Montenegro\n" +
            "Grado: IVC - Clave:23\n" +
            "=========CONVERSIONES======");
            double metros;
        Console.WriteLine("Dame una medida de metros: ");
        metros= double.Parse(Console.ReadLine());

        Console.WriteLine("Menu Principal");
        Console.WriteLine("1. Milimetros\n" +
            "2. Centimetros\n" +
            "3. Decimetros\n" +
            "4. Hectometro\n" +
            "5. Kilometro\n" +
            "6. Salir\n" +
            "Seleccione una opcion []:");
        int opc=Convert.ToInt32(Console.ReadLine()); 
    }
}
