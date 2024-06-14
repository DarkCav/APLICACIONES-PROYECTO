using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;


namespace CapaDatos
{
    public  class CdOperaciones
    {
        private CdConexion conexion = new CdConexion();

        // Método para loguearse como administrador o cliente
        public bool Login(string username, string password)
        {
            conexion.abrir();
            SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM Usuarios WHERE Username = @Username AND Password = @Password", conexion.conexion);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            int result = (int)command.ExecuteScalar();
            conexion.cerrar();
            return result > 0;
        }

        public bool VerificarUsuario(string username)
        {
            conexion.abrir();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Username = @Username", conexion.conexion);
            command.Parameters.AddWithValue("@Username", username);
            int count = (int)command.ExecuteScalar();
            conexion.cerrar();
            return count > 0;
        }

        public void InsertarUsuario(Usuario usuario)
        {
            conexion.abrir();
            SqlCommand command = new SqlCommand("INSERT INTO Usuarios (usuario, contrasena, rol, cedula) VALUES (@Username, @Password, @Role, @Cedula)", conexion.conexion);
            command.Parameters.AddWithValue("@Username", usuario.Username);
            command.Parameters.AddWithValue("@Password", usuario.Password);  // Considera hashear esta contraseña antes de almacenarla
            command.Parameters.AddWithValue("@Role", usuario.Role);
            command.Parameters.AddWithValue("@Cedula", usuario.Cedula);  // Asegúrate de que esto coincide con la propiedad modificada de la clase Usuario
            command.ExecuteNonQuery();
            conexion.cerrar();
        }

        public bool CedulaExiste(string cedula)
        {
            conexion.abrir();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE Cedula = @Cedula", conexion.conexion);
            command.Parameters.AddWithValue("@Cedula", cedula);
            int resultado = (int)command.ExecuteScalar();
            conexion.cerrar();
            return resultado > 0;
        }
        // Método para validar la cédula
        public bool ValidarCedula(string cedula)
        {
            if (cedula.Length != 10)
                return false;

            int sumaPares = 0;
            int sumaImpares = 0;
            for (int i = 0; i < 9; i += 2)
            {
                sumaImpares += int.Parse(cedula[i].ToString()) * 2 > 9 ? int.Parse(cedula[i].ToString()) * 2 - 9 : int.Parse(cedula[i].ToString()) * 2;
            }

            for (int i = 1; i < 9; i += 2)
            {
                sumaPares += int.Parse(cedula[i].ToString());
            }

            int sumaTotal = sumaPares + sumaImpares;
            int decimo = 10 - (sumaTotal % 10);

            return decimo == int.Parse(cedula[9].ToString()) || (sumaTotal % 10 == 0 && cedula[9] == '0');
        }

        // Método para ingresar datos de cualquier entidad
        public void InsertarCliente(Cliente cliente)
        {
            conexion.abrir();
            string query = "INSERT INTO Clientes (Cedula, Nombre, Apellido, Ciudad, Edad, fecha_nacimiento, correo_electronico) VALUES (@Cedula, @Nombre, @Apellido, @Ciudad, @Edad, @FechaDeNacimiento, @CorreoElectronico)";
            SqlCommand command = new SqlCommand(query, conexion.conexion);
            command.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
            command.Parameters.AddWithValue("@Edad", cliente.Edad);
            command.Parameters.AddWithValue("@FechaDeNacimiento", cliente.FechaDeNacimiento);
            command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
            command.ExecuteNonQuery();
            conexion.cerrar();
        }

        // Método para actualizar datos de cliente por cédula o nombre
        public void ActualizarCliente(string cedula, string nombre, string nuevoApellido)
        {
            conexion.abrir();
            string query = "UPDATE Clientes SET Apellido = @NuevoApellido WHERE Cedula = @Cedula OR Nombre = @Nombre";
            SqlCommand command = new SqlCommand(query, conexion.conexion);
            command.Parameters.AddWithValue("@Cedula", cedula);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@NuevoApellido", nuevoApellido);
            command.ExecuteNonQuery();
            conexion.cerrar();
        }

        // Método para eliminar cliente por cédula
        public void EliminarCliente(string cedula)
        {
            conexion.abrir();
            string query = "DELETE FROM Clientes WHERE Cedula = @Cedula";
            SqlCommand command = new SqlCommand(query, conexion.conexion);
            command.Parameters.AddWithValue("@Cedula", cedula);
            command.ExecuteNonQuery();
            conexion.cerrar();
        }

        // Método para buscar cliente por cédula
        public Cliente BuscarClientePorCedula(string cedula)
        {
            conexion.abrir();
            string query = "SELECT * FROM Clientes WHERE Cedula = @Cedula";
            SqlCommand command = new SqlCommand(query, conexion.conexion);
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader = command.ExecuteReader();
            Cliente cliente = null;
            if (reader.Read())
            {
                cliente = new Cliente
                {
                    Cedula = reader["Cedula"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Ciudad = reader["Ciudad"].ToString(),
                    Edad = Convert.ToInt32(reader["Edad"]),
                    FechaDeNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]),
                    CorreoElectronico = reader["correo_electronico"].ToString()
                };
            }
            reader.Close();
            conexion.cerrar();
            return cliente;
        }
    }
}

