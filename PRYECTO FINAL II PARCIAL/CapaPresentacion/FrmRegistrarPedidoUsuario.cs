using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarPedidoUsuario : Form
    {
        public FrmRegistrarPedidoUsuario()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = new DateTime(1753, 1, 1);
            dateTimePicker2.MaxDate = new DateTime(9999, 12, 31);
        }

        private void FrmRegistrarPedidoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
