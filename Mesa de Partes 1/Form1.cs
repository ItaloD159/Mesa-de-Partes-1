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

            dgvPersonas.Columns.Add("colDni", "DNI");
            dgvPersonas.Columns.Add("colNombres", "Nombres");
            dgvPersonas.Columns.Add("colApellidos", "Apellidos");
            dgvPersonas.Columns.Add("colTeléfono", "Teléfono");
            dgvPersonas.Columns.Add("colAsunto", "Asunto");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string asunto = txtAsunto.Text;

            MessageBox.Show("DNI: " + dni +
                "\nNombres: " + nombres +
                "\nApellidos: " + apellidos +
                "\nTeléfono: " + telefono +
                "\nAsunto: " + asunto);


            if (dni.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                return;
            }

            if (nombres == "" || apellidos == "")
            {
                MessageBox.Show("Ingrese nombres y apellidos.");
                return;
            }

            dgvPersonas.Rows.Add(dni, nombres, apellidos, telefono, asunto);

            MessageBox.Show("Persona registrada correctamente.");

            txtDni.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtAsunto.Clear();

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
