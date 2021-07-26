using Common.DTO;
using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("Lista")]
        public ResponseDTO GetListaUsuarios()
        {                
            return _usuarioService.GetListaUsuarios();
        }

        [HttpPost("Agregar")]
        public ResponseDTO CrearUsuario([FromBody] UsuarioDTO newUsuario) 
        {
            return _usuarioService.CrearUsuario(newUsuario);
        }

        [HttpDelete("Eliminar/{userName}")]
        public ResponseDTO EliminarUsuario(string userName)
        {
            var deleteUsuario = new UsuarioDTO();
            deleteUsuario.UserName = userName;
            return _usuarioService.EliminarUsuario(deleteUsuario);
        }

        [HttpPut("Modificar")]
        public ResponseDTO ModificarUsuario([FromBody] UsuarioDTO modifyUsuario)
        {
            return _usuarioService.ModificarUsuario(modifyUsuario);
        }
    }
}
