using Common.DTO;
using Common.Exceptions;
using Contracts.Repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private COAContext _context { get; set; }

        public UsuarioRepository(COAContext context)
        {
            _context = context;
        }
        public IList<UsuarioDTO> GetAllUsuarrios()
        {
            return _context.Usuarios.Where(x=> x.Activo).Select(x => new UsuarioDTO()
            {
                Nombre = x.Nombre,
                UserName = x.UserName,
                Email = x.Email,
                Telefono = x.Telefono
            }).ToList();
        }
        public void CrearUsuario(UsuarioDTO usuarioDTO)
        {
           
            var usuarioCrear = _context.Usuarios.Where(x => x.UserName == usuarioDTO.UserName).FirstOrDefault();
            if (usuarioCrear != null)
            {
                throw new UsuarioExceptions("El nombre de usuario ingresado ya existe.");
                
            }
            else
            {
                _context.Usuarios.Add(new DataAccess.Models.Usuario()
                {
                    UserName = usuarioDTO.UserName,
                    Nombre = usuarioDTO.Nombre,
                    Email = usuarioDTO.Email,
                    Telefono = usuarioDTO.Telefono,
                    Activo = true
                });
                
            }
                                  
        }
        public void EliminarUsuario(UsuarioDTO usuarioDTO)
        {
          
            var usuarioEliminar = _context.Usuarios.Where(x => x.UserName == usuarioDTO.UserName).FirstOrDefault();
            if (usuarioEliminar !=null)
            {
                usuarioEliminar.Activo = false;
                _context.Usuarios.Update(usuarioEliminar);
            }
            else
            {
                throw new UsuarioExceptions("El nombre de usuario ingresado no existe.");
            }
        }
        public void ModificarUsuario(UsuarioDTO usuarioDTO)
        {
            
            var usuarioModificar = _context.Usuarios.Where(x => x.UserName == usuarioDTO.UserName).FirstOrDefault();
            if (usuarioModificar != null)
            {
                usuarioModificar.Nombre = usuarioDTO.Nombre;
                usuarioModificar.Email = usuarioDTO.Email;
                usuarioModificar.Telefono = usuarioDTO.Telefono;
                _context.Usuarios.Update(usuarioModificar);
            }
            else
            {
                throw new UsuarioExceptions("El nombre de usuario ingresado no existe.");
            }
        }
    }
}
