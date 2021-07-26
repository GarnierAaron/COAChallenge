using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        IList<UsuarioDTO> GetAllUsuarrios();
        void CrearUsuario(UsuarioDTO usuarioDTO);
        void EliminarUsuario(UsuarioDTO usuarioDTO);
        void ModificarUsuario(UsuarioDTO usuarioDTO);
    }
}
