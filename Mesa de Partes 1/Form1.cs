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
            string NumeroDocumento = txtNumeroDocumento.Text;
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Telefono = txtTelefono.Text;
            string Asunto = txtAsunto.Text;

            MessageBox.Show("NumeroDocumento: " + NumeroDocumento +
                "\nNombres: " + Nombres +
                "\nApellidos: " + Apellidos +
                "\nTeléfono: " + Telefono +
                "\nAsunto: " + Asunto);


            if (NumeroDocumento.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                return;
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
    }
}
