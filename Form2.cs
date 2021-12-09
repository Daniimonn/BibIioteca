using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibIioteca
{
    public partial class Form2 : Form
    {
        public Form2(Form1.Datos info)
        {
            InitializeComponent();
            lblDatos1.Text = info.Usuario;
            lblDatos2.Text = info.Nombre;
            lblDatos3.Text = info.Apellido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
