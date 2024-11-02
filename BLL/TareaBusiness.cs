using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class TareaBusiness
    {
        TareaData tareaData = new TareaData();
        
        public void AgregarTarea(TareaEntity tarea)
        {
            try
            {
                if (tarea.DescripcionTarea.Length < 5)
                {
                    throw new Exception("La descripcion debe tener al menos 5 caracteres");
                }
                if (tarea.FechaTarea < DateTime.Now)
                {
                    throw new Exception("La fecha de la tarea no puede ser previa a la fecha actual");
                }
                tarea.FechaRegistro = DateTime.Now;
                tareaData.SubirTarea(tarea);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModificarTarea(TareaEntity tareaMod)
        {
            try
            {
                tareaData.ModificarTarea(tareaMod);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                tareaData.EliminarTarea(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TareaEntity> ListarTareas()
        {
            try
            {
                return tareaData.ListarTareas();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
