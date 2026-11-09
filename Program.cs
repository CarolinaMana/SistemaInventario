using System;

namespace SistemaInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE INVENTARIO: LABORATORIO 5.6 ===\n");

            // Instancia y asignación del Producto 1 (Casos de prueba CP-02 y CP-03)
            ProductoCarolina producto1 = new ProductoCarolina();
            producto1.Codigo = "P001";
            producto1.Nombre = "Laptop Alumno";
            producto1.Precio = 100.00m;
            producto1.Cantidad = 5;

            // Instancia y asignación del Producto 2 (Caso de prueba CP-04 con cantidad 0)
            ProductoCarolina producto2 = new ProductoCarolina();
            producto2.Codigo = "P002";
            producto2.Nombre = "Mouse Óptico";
            producto2.Precio = 250.00m;
            producto2.Cantidad = 0;

            // Instancia y asignación del Producto 3 (Garantiza los 3 objetos independientes)
            ProductoCarolina producto3 = new ProductoCarolina();
            producto3.Codigo = "P003";
            producto3.Nombre = "Teclado Mecánico";
            producto3.Precio = 1500.00m;
            producto3.Cantidad = 12;

            // Invocación de métodos y visualización de resultados (RF-10 y RF-12)
            Console.WriteLine("--- Información del Producto 1 ---");
            producto1.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto1.CalcularValorTotal():N2}\n");

            Console.WriteLine("--- Información del Producto 2 ---");
            producto2.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto2.CalcularValorTotal():N2}\n");

            Console.WriteLine("--- Información del Producto 3 ---");
            producto3.MostrarInformacion();
            Console.WriteLine($"Valor Total: RD${producto3.CalcularValorTotal():N2}\n");

            // Demostración de independencia de memoria (RF-11 y CP-08)
            Console.WriteLine("=== Demostración de Independencia (CP-08) ===");
            producto1.Precio = 120.00m; // Modificación simulada
            Console.WriteLine($"Precio modificado de {producto1.Nombre}: RD${producto1.Precio:N2}");
            Console.WriteLine($"Precio intacto de {producto2.Nombre}: RD${producto2.Precio:N2}");
        }
    }
}
