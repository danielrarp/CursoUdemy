using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CursoUdemy.Models
{
    public class Clientes
    {
        public int id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        public string nombre { get; set; }

        [Display(Name = "Fecha de alta")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YY-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaAlta { get; set; }

        [Range (18,75)]
        public int edad { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}