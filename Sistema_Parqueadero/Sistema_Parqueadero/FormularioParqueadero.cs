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
    public partial class FormularioParqueadero : Form
    {
        int Placas;

        public FormularioParqueadero()
        {
            InitializeComponent();
        }

        private void txtPlacas_TextChanged(object sender, EventArgs e)
        {
            
            Placas = Convert.ToInt32(txtPlacas.Text); 
          
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Hora_Entrada;

            Hora_Entrada = Convert.ToDouble(cmbHora);
        }

        private void cmbMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Hora_Salida;

            Hora_Salida = Convert.ToDouble(cmbMinutos);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Placas <= 99 || Placas > 999)
            {
                MessageBox.Show("El número de placa es incorrecto. La placa debe ser de tres digitos");
                txtPlacas.Clear();
                txtPlacas.Focus();
                return;
            }
        }
    }
}
