using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class ProductoCarolina
    {
        // Propiedades automáticas (RF-02 a RF-05)
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // RF-08: Mostrar los datos del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Producto: {Nombre}");
            Console.WriteLine($"Precio: RD${Precio:N2}");
            Console.WriteLine($"Cantidad disponible: {Cantidad}");
        }

        // RF-09: Calcular valor total (Precio x Cantidad)
        public decimal CalcularValorTotal()
        {
            return Precio * Cantidad;
        }
    }
}
