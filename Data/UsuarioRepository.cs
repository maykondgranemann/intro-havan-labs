using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepository
    {
        // Create
        public void Create(Usuario model)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
            }
        }
        // ReadAll
        public List<Usuario> ReadAll()
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                return context.Usuarios.ToList();
            }
        }
        // ReadById
        public Usuario ReadById(int id)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                return context.Usuarios.Find(id);
            }
        }
        // Update
        public void Updade(Usuario model)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        // Delete
        public void Delete(int id)
        {
            using (HavanLabsContext context = new HavanLabsContext())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
        }
    }
}
