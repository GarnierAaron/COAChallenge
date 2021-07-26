﻿using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public interface IUsuarioService
    {
        ResponseDTO GetListaUsuarios();
        ResponseDTO CrearUsuario(UsuarioDTO usuarioDTO);
        ResponseDTO EliminarUsuario(UsuarioDTO usuarioDTO);
        ResponseDTO ModificarUsuario(UsuarioDTO usuarioDTO);

    }
}
