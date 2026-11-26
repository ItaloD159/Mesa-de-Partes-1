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
        private int correlativo = 1;
        public Form1()
        {
            InitializeComponent();

            dgvPersonas.Columns.Clear();

            dgvPersonas.Columns.Add("colExpediente", "N° de Expediente");
            dgvPersonas.Columns.Add("colFecha", "Fecha de registro");
            dgvPersonas.Columns.Add("colTipoDocumento", "Tipo de documento");
            dgvPersonas.Columns.Add("colNumeroDocumento", "N° de Documento");
            dgvPersonas.Columns.Add("colNombres", "Nombres");
            dgvPersonas.Columns.Add("colApellidoPaterno", "Apellido paterno");
            dgvPersonas.Columns.Add("colApellidoMaterno", "Apellido materno");
            dgvPersonas.Columns.Add("colCorreo", "Correo electrónico");
            dgvPersonas.Columns.Add("colTelefono", "Teléfono");
            dgvPersonas.Columns.Add("colTipoExpediente", "Tipo de expediente");
            dgvPersonas.Columns.Add("colAsunto", "Asunto");
            dgvPersonas.Columns.Add("colEstado", "Estado");

        }

        //Botón registrar
        private void button1_Click(object sender, EventArgs e)
        {

            //Valida si se eligió un tipo de documento y expediente
            if (CBTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); CBTipoDocumento.Focus();
                return;
            }
            if (CBTipoExpediente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); CBTipoExpediente.Focus();
                return;
            }

            //Variables donde almacenamos los datos ingresados por el usuario
            string TipoDocumento = CBTipoDocumento.SelectedItem.ToString(); //Tipo de documento seleccionado
            string NumeroDocumento = Validaciones.LimpiarTexto(txtNumeroDocumento.Text);
            string Nombres = Validaciones.LimpiarTexto(txtNombres.Text);
            string ApellidoPaterno = Validaciones.LimpiarTexto(txtApellidoPaterno.Text);
            string ApellidoMaterno = Validaciones.LimpiarTexto(txtApellidoMaterno.Text);
            string CorreoElectronico = Validaciones.LimpiarTexto(txtCorreo.Text);
            string Telefono = Validaciones.LimpiarTexto(txtTelefono.Text);
            string TipoExpediente = CBTipoExpediente.SelectedItem.ToString(); //Tipo de expediente seleccionado
            string Asunto = Validaciones.LimpiarTexto(txtAsunto.Text);

            // Validamos los datos
            string error = Validaciones.ValidarRegistro(TipoDocumento, NumeroDocumento, Nombres,
                                                        ApellidoPaterno, ApellidoMaterno, Telefono);
            if (error != "")
            {
                MessageBox.Show(error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            //Colocamos los datos en la tabla
            //Generamos el código del expediente
            string codigoExpediente =
                "EXP-" + DateTime.Now.Year + "-" +
                correlativo.ToString("D4");

            //Obtenemos la fecha y hora actuales
            string fechaRegistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            //Asignamos el estado inicial
            string estado = "PENDIENTE";

            //Registramos los datos en la tabla
            dgvPersonas.Rows.Add(
                codigoExpediente,
                fechaRegistro,
                TipoDocumento,
                NumeroDocumento,
                Nombres,
                ApellidoPaterno,
                ApellidoMaterno,
                CorreoElectronico,
                Telefono,
                TipoExpediente,
                Asunto,
                estado
            );

            // Aumentamos el correlativo para el siguiente expediente
            correlativo++;

            MessageBox.Show(
                "Expediente registrado correctamente: " + codigoExpediente,
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNumeroDocumento.Clear();
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            CBTipoExpediente.SelectedIndex = -1;
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

        //Botón limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        //Búsqueda de registros por número de documento
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string DocumentoBuscado = Validaciones.LimpiarTexto(txtBuscarDocumento.Text);

            //Validamos si el campo está vacío antes de realizar la búsqueda
            if (DocumentoBuscado == "")
            {
                MessageBox.Show("Ingrese un número de documento para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool encontrado = false;

            //Buscamos en todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvPersonas.Rows)
            {

                if (fila.IsNewRow || fila.Cells[3].Value == null)
                    continue;

                string documentoEnTabla =
                    fila.Cells[3].Value.ToString();

                if (documentoEnTabla == DocumentoBuscado)
                {
                    //Se selecciona la fila en la tabla si se encuentra registrada
                    fila.Selected = true;
                    dgvPersonas.CurrentCell = fila.Cells[3]; //Salta visualmente a la fila

                    MessageBox.Show("¡Registro encontrado!", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    encontrado = true;
                    break;
                }
            }

            //No se encontró ningún registro con ese número de documento
            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún registro con ese número de documento.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
