using DataAccess.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Usuario : EntityBase
    {
        [Column(TypeName = "VARCHAR(200)")]
        public string UserName { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string Email { get; set; }

        [Column(TypeName = "BIGINT")]
        public long Telefono { get; set; }

        [Column(TypeName = "BIT")]
        public bool Activo { get; set; }
    }
}
