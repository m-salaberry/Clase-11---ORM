using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TareaEntity
    {

        private int id;
        private string descripcionTarea;
        private DateTime fechaRegistro;
        private DateTime fechaTarea;

        public int Id { get => id; set => id = value; }
        public string DescripcionTarea { get => descripcionTarea; set => descripcionTarea = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaTarea { get => fechaTarea; set => fechaTarea = value; }


    }
}
