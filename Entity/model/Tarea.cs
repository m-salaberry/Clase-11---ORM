using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Tarea
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string DescripcionTarea { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        [Required]
        public DateTime FechaTarea { get; set; }



    }
}
