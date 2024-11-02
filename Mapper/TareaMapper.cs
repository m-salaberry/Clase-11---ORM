using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.model;

namespace Mapper
{
    public class TareaMapper
    {
        public static TareaEntity Map(Tarea tarea)
        {
            return new TareaEntity
            {
                Id = tarea.Id,
                DescripcionTarea = tarea.DescripcionTarea,
                FechaRegistro = tarea.FechaRegistro,
                FechaTarea = tarea.FechaTarea
            };
        }

        public static Tarea Map(TareaEntity tarea)
        {
            return new Tarea
            {
                Id = tarea.Id,
                DescripcionTarea = tarea.DescripcionTarea,
                FechaRegistro = tarea.FechaRegistro,
                FechaTarea = tarea.FechaTarea
            };
        }
    }
}
