using Common.DTO;
using Common.Exceptions;
using Contracts.Repositories;
using Contracts.Service;
using DataAccess;
using Repositories;
using System;

namespace Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly COAContext _context;
        private readonly IUsuarioRepository usuarioRepository;
   
        public UsuarioService(COAContext context, IUsuarioRepository usuarioRepository)
        {
            _context = context;
            this.usuarioRepository = usuarioRepository;
        }

        public ResponseDTO GetListaUsuarios()
        {
            ResponseDTO result = new ResponseDTO();
            try
            {
                result.Result = usuarioRepository.GetAllUsuarrios();
                result.Success = true;
            }
            catch (UsuarioExceptions usuarioExceptios)
            {
                result.Success = false;
                result.Message = usuarioExceptios.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ocurrio un Error inesperado.";
            }
            

            return result;
        }
        public ResponseDTO CrearUsuario(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new ResponseDTO();
            try
            {
                usuarioRepository.CrearUsuario(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch(UsuarioExceptions usuarioExceptios)
            {
                result.Success = false;
                result.Message = usuarioExceptios.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ocurrio un Error inesperado.";
            }
            

            return result;

        }
        public ResponseDTO EliminarUsuario(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new ResponseDTO();
            try
            {
                usuarioRepository.EliminarUsuario(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch (UsuarioExceptions usuarioExceptios)
            {
                result.Success = false;
                result.Message = usuarioExceptios.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ocurrio un Error inesperado.";
            }
        
            return result;
        }
        public ResponseDTO ModificarUsuario(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new ResponseDTO();
            try
            {
                usuarioRepository.ModificarUsuario(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch (UsuarioExceptions usuarioExceptios)
            {
                result.Success = false;
                result.Message = usuarioExceptios.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ocurrio un Error inesperado.";
            } 
        
            return result;
        }
    }
}
