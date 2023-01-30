using ControlUsuarios.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly ApplicationDbContext _dbcontext;
        public UsuarioRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
            _dbcontext.Usuario.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Insertar(Usuario modelo)
        {
            _dbcontext.Usuario.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public Task<Usuario> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Usuario>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
