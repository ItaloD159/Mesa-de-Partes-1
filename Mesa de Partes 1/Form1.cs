using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesa_de_Partes_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvPersonas.Columns.Add("colNumeroDocumento", "Documento");
            dgvPersonas.Columns.Add("colNombres", "Nombres");
            dgvPersonas.Columns.Add("colApellidos", "Apellidos");
            dgvPersonas.Columns.Add("colTeléfono", "Teléfono");
            dgvPersonas.Columns.Add("colAsunto", "Asunto");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Valida si se eligió un tipo de documento
            if (CBTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de documento."); CBTipoDocumento.Focus();
                return;
            }

            string TipoDocumento = CBTipoDocumento.SelectedItem.ToString(); //Tipo de documento seleccionado

            string NumeroDocumento = txtNumeroDocumento.Text;
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Telefono = txtTelefono.Text;
            string Asunto = txtAsunto.Text;


            //MessageBox.Show("NumeroDocumento: " + NumeroDocumento +
                //"\nNombres: " + Nombres +
                //"\nApellidos: " + Apellidos +
                //"\nTeléfono: " + Telefono +
                //"\nAsunto: " + Asunto);


            // Validación de campos del tipo de documento
            if (TipoDocumento == "DNI")
            {
                if (NumeroDocumento.Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 8 dígitos.");
                    return;
                }
            }

            if (TipoDocumento == "RUC") 
            {
                if (NumeroDocumento.Length != 11) 
                {
                    MessageBox.Show("El RUC debe tener 11 dígitos.");
                    return;
                }
            }

            if (TipoDocumento == "CE")
            {
                if (NumeroDocumento.Length != 11)
                {
                    MessageBox.Show("La Cédula de Extranjería debe tener 11 dígitos.");
                    return;
                }
            }

            if (Nombres == "" || Apellidos == "")
            {
                MessageBox.Show("Ingrese nombres y apellidos.");
                return;
            }

            dgvPersonas.Rows.Add(NumeroDocumento, Nombres, Apellidos, Telefono, Asunto);

            MessageBox.Show("Persona registrada correctamente.");

            txtNumeroDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtAsunto.Clear();
            txtNumeroDocumento.Focus();
            CBTipoDocumento.SelectedIndex = -1;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtAsunto.Clear();
            txtNumeroDocumento.Focus();
            CBTipoDocumento.SelectedIndex = -1;
        }
    }
}
