using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.model;
using Mapper;

namespace DAL
{
    public class TareaData
    {

        private static AppDbContext getAppDbContext()
        {
            AppContextFactory appDbContextFactory = new AppContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }
        public void SubirTarea(TareaEntity tarea)
        {
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    Tarea tareaSubir = TareaMapper.Map(tarea);
                    appDbContext.Tareas.Add(tareaSubir);
                    appDbContext.SaveChanges();
                }
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
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    Tarea tareaToUpdate = appDbContext.Tareas.Where(tarea => tarea.Id == tareaMod.Id).FirstOrDefault()!;
                    tareaToUpdate.DescripcionTarea = tareaMod.DescripcionTarea;
                    tareaToUpdate.FechaTarea = tareaMod.FechaTarea;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarTarea(int id)
        {
            try
            {
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    Tarea tareaToRemove = appDbContext.Tareas.Where(tarea => tarea.Id == id).FirstOrDefault()!;
                    appDbContext.Tareas.Remove(tareaToRemove);
                    appDbContext.SaveChanges();
                }
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
                AppDbContext appDbContext = getAppDbContext();
                using (appDbContext)
                {
                    List<Tarea> tareas = appDbContext.Tareas.ToList();
                    List<TareaEntity> tareasEntity = new List<TareaEntity>();
                    foreach (Tarea tarea in tareas)
                    {
                        tareasEntity.Add(TareaMapper.Map(tarea));
                    }
                    return tareasEntity;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
