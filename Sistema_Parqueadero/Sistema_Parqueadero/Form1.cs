using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Parqueadero
{
    public partial class Form1 : Form
    {
        string Contraseña = "equipocinco";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text != Contraseña)
            {
                MessageBox.Show("La contraseña ingresada es incorrecta. Ingrese la contraseña nuevamente");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }
            else
            {
                txtContraseña.Clear();
                FormularioParqueadero Formulario = new FormularioParqueadero();
                Formulario.ShowDialog();
            }
        }
    }
}
