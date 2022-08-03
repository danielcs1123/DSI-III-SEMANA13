using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Listar()
        {
            Cliente objcliente = new Cliente();
            dgv_cliente.DataSource = null;
            dgv_cliente.DataSource = objcliente.Listar();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_id.Enabled = true;
            txt_nombres.Enabled = true;
            txt_apellidos.Enabled = true;
            rbtn_masculino.Enabled = true;
            rbtn_femenino.Enabled = true;
            dtp_fecha.Enabled = true;
            cmb_documento.Enabled = true;
            txt_direccion.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefono.Enabled = true;
            txt_email.Enabled = true;

            txt_id.Text = "";
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            rbtn_masculino.Checked = true;
            dtp_fecha.Value = DateTime.Now;
            cmb_documento.Text = "";
            txt_direccion.Text = "";
            txt_numero.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente objcliente = new Cliente();
            objcliente.Nombre = txt_nombres.Text;
            objcliente.Apellidos = txt_apellidos.Text;
            objcliente.Sexo = rbtn_masculino.Checked ? "M" : "F";
            objcliente.Fecha_Nacimiento = dtp_fecha.Value;
            objcliente.Tipo_Documento = cmb_documento.SelectedText;
            objcliente.Num_Documento = txt_numero.Text;
            objcliente.Direccion = txt_direccion.Text;
            objcliente.Telefono = txt_telefono.Text;
            objcliente.Email = txt_email.Text;
            objcliente.Insertar();
            MessageBox.Show("¡Datos guardados con éxito!");
            this.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
