using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmRegistroLogin : Form
    {

        private ClaseLogicaDatos logicaDatos = new ClaseLogicaDatos();

        public FrmRegistroLogin()
        {
            InitializeComponent();
            this.txtUsuario.KeyPress += new KeyPressEventHandler(Txt_KeyPress);
            this.txtContra.KeyPress += new KeyPressEventHandler(Txt_KeyPress);
            this.txtCed.KeyPress += new KeyPressEventHandler(Txt_KeyPress);
            this.comboBox1.KeyPress += new KeyPressEventHandler(Txt_KeyPress);
           
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control nextControl = this.GetNextControl((Control)sender, true);
                if (nextControl != null)
                {
                    e.Handled = true;  // Indica que el evento KeyPress ha sido manejado
                    nextControl.Focus();  // Mueve el foco al siguiente control
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            new FrmRegistroLogin().Show();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tctCed_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContra.Text; // Considera hashear la contraseña
            string role = comboBox1.SelectedItem.ToString();
            string cedula = txtCed.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string ciudad = txtCiudad.Text;
            int edad = int.Parse(txtEdad.Text);
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string correo = txtCorreo.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el cliente ya existe
            Cliente clienteExistente = logicaDatos.BuscarCliente(cedula);

            if (clienteExistente == null)
            {
                // Si no existe, crea un nuevo cliente
                Cliente nuevoCliente = new Cliente
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Ciudad = ciudad,
                    Edad = edad,
                    FechaDeNacimiento = fechaNacimiento,
                    CorreoElectronico = correo
                };

                logicaDatos.RegistrarCliente(nuevoCliente); // Asume que este método maneja la inserción en la base de datos
            }

            // Crea un nuevo usuario
            Usuario nuevoUsuario = new Usuario
            {
                Username = username,
                Password = password, // Asegúrate de hashear la contraseña aquí
                Role = role,
                Cedula = cedula
            };

            try
            {
                logicaDatos.RegistrarUsuario(nuevoUsuario);
                MessageBox.Show("El usuario ha sido registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Opcional: Cierra el formulario después del registro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCed.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, ingrese una cédula para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = logicaDatos.BuscarCliente(cedula);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtCiudad.Text = cliente.Ciudad;
                txtEdad.Text = cliente.Edad.ToString();
                dateTimePicker1.Value = cliente.FechaDeNacimiento;
                txtCorreo.Text = cliente.CorreoElectronico;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado. Por favor, verifique la cédula o ingrese los datos para un nuevo registro.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCiudad.Clear();
                txtEdad.Clear();
                txtCorreo.Clear();
                dateTimePicker1.Value = DateTime.Today;
            }
        }
    }
}
