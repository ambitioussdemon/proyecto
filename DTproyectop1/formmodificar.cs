using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DTproyectop1;

namespace DTproyectop1
{


    public partial class frmmodificar : Form
    {
        MySqlConnection conexion;
        private frmsi formprincipal;
        public frmmodificar(frmsi origen)
        {
            InitializeComponent();
            formprincipal = origen;
            conexion = Conexion.conectar();


        }

        private void gprdatos_Enter(object sender, EventArgs e)
        {

        }

        private void lnklblregreso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formprincipal.Show();
            this.Close();
        }

        private void lnklblsalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string query = "UPDATE estudios SET nombre=@nombre, costo=@costo, cita=@cita, ayuno=@ayuno, vejiga=@vejiga, creatinina=@creatinina, microlax=@microlax, higiene=@higiene, metal=@metal, trojes=@trojes, galerias=@galerias, matriz=@matriz, norte=@norte WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                cmd.Parameters.AddWithValue("@nombre", txtestudio.Text);
                cmd.Parameters.AddWithValue("@costo", int.Parse(txtcosto.Text));
                cmd.Parameters.AddWithValue("@cita", rbsi.Checked ? 1 : 2);
                cmd.Parameters.AddWithValue("@ayuno", chbayuno.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@vejiga", chbvejiga.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@creatinina", chbcrea.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@microlax", chbmicro.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@higiene", chbhigiene.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@metal", chbmetal.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@trojes", chbtrojes.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@galerias", chbgalerias.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@matriz", chbmatriz.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@norte", chbnorte.Checked ? 1 : 0);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("✅ Estudio actualizado correctamente en la base de datos.");

                    // 🔹 Actualizamos también el formulario principal
                    formprincipal.txtid.Text = this.txtid.Text;
                    formprincipal.txtestudio.Text = this.txtestudio.Text;
                    formprincipal.txtcosto.Text = this.txtcosto.Text;
                    formprincipal.rbsi.Checked = this.rbsi.Checked;
                    formprincipal.rbno.Checked = this.rbno.Checked;
                    formprincipal.chbayuno.Checked = this.chbayuno.Checked;
                    formprincipal.chbvejiga.Checked = this.chbvejiga.Checked;
                    formprincipal.chbcrea.Checked = this.chbcrea.Checked;
                    formprincipal.chbmicro.Checked = this.chbmicro.Checked;
                    formprincipal.chbhigiene.Checked = this.chbhigiene.Checked;
                    formprincipal.chbmetal.Checked = this.chbmetal.Checked;
                    formprincipal.chbtrojes.Checked = this.chbtrojes.Checked;
                    formprincipal.chbgalerias.Checked = this.chbgalerias.Checked;
                    formprincipal.chbmatriz.Checked = this.chbmatriz.Checked;
                    formprincipal.chbnorte.Checked = this.chbnorte.Checked;

                    MessageBox.Show("Cambios sincronizados con éxito.");
                }
                else
                {
                    MessageBox.Show("⚠️ No se encontró el estudio con ese ID, no se actualizó nada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al actualizar: " + ex.Message);
            }
        }

    }
}