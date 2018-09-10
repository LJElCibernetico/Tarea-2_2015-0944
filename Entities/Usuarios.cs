using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime Fecha { get; set; }
        public String Nombre { get; set; }
        public String Comentario { get; set; }

        public Usuarios(int idUsuario, string username, string password, DateTime fecha, string nombre, string comentario)
        {
            IdUsuario = idUsuario;
            Username = username;
            Password = password;
            Fecha = fecha;
            Nombre = nombre;
            Comentario = comentario;
        }

        public Usuarios()
        {
            IdUsuario = 0;
            Username = String.Empty;
            Password = String.Empty;
            Fecha = DateTime.Now;
            Nombre = String.Empty;
            Comentario = String.Empty;
        }
    }
}
