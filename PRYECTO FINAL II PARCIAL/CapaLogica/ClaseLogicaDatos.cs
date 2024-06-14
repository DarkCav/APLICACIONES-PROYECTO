using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;




namespace CapaLogica
{
    public  class ClaseLogicaDatos
    {

        private CdOperaciones operaciones = new CdOperaciones();

        public bool VerificarLogin(string username, string password)
        {
            return operaciones.Login(username, password);
        }

        public void RegistrarCliente(Cliente cliente)
        {
            operaciones.InsertarCliente(cliente);
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            operaciones.InsertarUsuario(usuario);
        }

        public void ActualizarDatosCliente(string cedula, string nombre, string apellido)
        {
            operaciones.ActualizarCliente(cedula, nombre, apellido);
        }

        public void EliminarCliente(string cedula)
        {
            operaciones.EliminarCliente(cedula);
        }

        public Cliente BuscarCliente(string cedula)
        {
            return operaciones.BuscarClientePorCedula(cedula);
        }

        public bool UsuarioExiste(string username)
        {
            return operaciones.VerificarUsuario(username);
        }

        public bool CedulaExiste(string cedula)
        {
            return operaciones.CedulaExiste(cedula);
        }
        public bool ValidarCedula(string cedula)
        {
            return operaciones.ValidarCedula(cedula);
        }
    }
}


