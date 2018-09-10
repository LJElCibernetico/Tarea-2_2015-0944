using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }

        public int IdDepartamento { get; set; }
        public String Nombre { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public Double Costo { get; set; }
        public Double Precio { get; set; }

        public Productos(int idProducto, int idDepartamento, string nombre, double precio, int existencia, DateTime fechaDeVencimiento, double costo)
        {
            IdProducto = idProducto;
            IdDepartamento = idDepartamento;
            Nombre = nombre;
            Precio = precio;
            Existencia = existencia;
            FechaDeVencimiento = fechaDeVencimiento;
            Costo = costo;
        }

        public Productos()
        {
            IdProducto = 0;
            IdDepartamento = 0;
            Nombre = String.Empty;
            Precio = 0;
            Existencia = 0;
            FechaDeVencimiento = DateTime.Now;
            Costo = 0;
        }
    }
}
