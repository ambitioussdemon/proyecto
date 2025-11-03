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


namespace DTproyectop1
{
    public partial class frmsi : Form
    {
        //Estructura para los chb de preparaciones
        struct preparaciones
        {
            public int ayuno;
            public int vejiga;
            public int creatinina;
            public int microlax;
            public int higiene;
            public int metal;
        }

        //Estructura para los chb de sucursales
        struct suc
        {
            public int trojes;
            public int galerias;
            public int matriz;
            public int norte;
        }

        /*Estructura principal, se incluyen previas struct 
         y txtbox y rd button*/
        struct estudio
        {
            public int id;
            public string nombre;
            public int costo;
            public preparaciones prep;
            public suc sucus;
            public int cita;
        }

        //Arreglo de la estructura principal
        estudio[] est;
        int indice;
        MySqlConnection conexion; //conexion global

        public frmsi()
        {
            InitializeComponent();
            est = new estudio[10];
            indice = 0;
            // 🔹 Conexión automática a la base de datos
            conexion = Conexion.conectar();

        }

        private void chbtrojes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbgalerias_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbmatriz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbnorte_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Metodo para la consulta de los estudios 
        //Ayuda para no escribir tanta linea de codigo
        // Este método está dentro de la clase frmsi
        private void CargarEstudio(estudio estu)
        {
            txtid.Text = estu.id.ToString();
            txtestudio.Text = estu.nombre;
            txtcosto.Text = estu.costo.ToString();

            rbsi.Checked = estu.cita == 1;
            rbno.Checked = estu.cita == 2;

            chbayuno.Checked = estu.prep.ayuno == 1;
            chbvejiga.Checked = estu.prep.vejiga == 1;
            chbcrea.Checked = estu.prep.creatinina == 1;
            chbmicro.Checked = estu.prep.microlax == 1;
            chbhigiene.Checked = estu.prep.higiene == 1;
            chbmetal.Checked = estu.prep.metal == 1;

            chbtrojes.Checked = estu.sucus.trojes == 1;
            chbgalerias.Checked = estu.sucus.galerias == 1;
            chbmatriz.Checked = estu.sucus.matriz == 1;
            chbnorte.Checked = estu.sucus.norte == 1;
        }


        //Boton para agregar un estudio [cupo de 10 estudios]
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (indice < 10)
            {
                est[indice].id = int.Parse(txtid.Text);
                //Validacion de id
                for (int j=0; j < indice; j++)
                {
                    if (est[indice].id == est[j].id)
                    {
                        MessageBox.Show("El ID ya existe, ingrese uno diferente.");
                        return; 
                    }
                }
                est[indice].nombre = txtestudio.Text;
                est[indice].costo = int.Parse(txtcosto.Text);
                //Guadado de los botones radio [cita]
                if (rbsi.Checked == true)
                    est[indice].cita = 1;
                else
                    est[indice].cita = 2;

                //Guardado de las variables de chb de preparaciones

                //Ayuno
                if (chbayuno.Checked == true)
                    est[indice].prep.ayuno = 1;
                else
                    est[indice].prep.ayuno = 0;
                //Vejiga
                if (chbvejiga.Checked == true)
                    est[indice].prep.vejiga = 1;
                else
                    est[indice].prep.vejiga = 0;
                //creatinina
                if (chbcrea.Checked == true)
                    est[indice].prep.creatinina = 1;
                else
                    est[indice].prep.creatinina = 0;
                //Microlax
                if (chbmicro.Checked == true)
                    est[indice].prep.microlax = 1;
                else
                    est[indice].prep.microlax = 0;
                //higiene
                if (chbhigiene.Checked == true)
                    est[indice].prep.higiene = 1;
                else
                    est[indice].prep.higiene = 0;
                //Metal
                if (chbmetal.Checked == true)
                    est[indice].prep.metal = 1;
                else
                    est[indice].prep.metal = 0;

                //Guardado de chb de sucursales

                //Trojes
                if (chbtrojes.Checked == true)
                    est[indice].sucus.trojes = 1;
                else
                    est[indice].sucus.trojes = 0;
                //Galerias
                if (chbgalerias.Checked == true)
                    est[indice].sucus.galerias = 1;
                else
                    est[indice].sucus.galerias = 0;
                //matriz
                if (chbmatriz.Checked == true)
                    est[indice].sucus.matriz = 1;
                else
                    est[indice].sucus.matriz = 0;
                //Norte
                if (chbnorte.Checked == true)
                    est[indice].sucus.norte = 1;
                else
                    est[indice].sucus.norte = 0;

                //incremeto del indice [si esto no se realiza se sobre escribe en la misma posicion]
                indice++;

                //Reinicio de valores
                txtid.Text = "";
                txtestudio.Text = "";
                txtcosto.Text = "";
                chbayuno.Checked = false;
                chbvejiga.Checked = false;
                chbcrea.Checked = false;
                chbmicro.Checked = false;
                chbhigiene.Checked = false;
                chbmetal.Checked = false;
                chbtrojes.Checked = false;
                chbgalerias.Checked = false;
                chbmatriz.Checked = false;
                chbnorte.Checked = false;
                rbsi.Checked = false;
                rbno.Checked = false;

                // 🔹 Guardar en la base de datos
                try
                {
                    string query = "INSERT INTO estudios (id, nombre, costo, cita, ayuno, vejiga, creatinina, microlax, higiene, metal, trojes, galerias, matriz, norte) " +
                                   "VALUES (@id, @nombre, @costo, @cita, @ayuno, @vejiga, @creatinina, @microlax, @higiene, @metal, @trojes, @galerias, @matriz, @norte)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", est[indice - 1].id);
                    cmd.Parameters.AddWithValue("@nombre", est[indice - 1].nombre);
                    cmd.Parameters.AddWithValue("@costo", est[indice - 1].costo);
                    cmd.Parameters.AddWithValue("@cita", est[indice - 1].cita);
                    cmd.Parameters.AddWithValue("@ayuno", est[indice - 1].prep.ayuno);
                    cmd.Parameters.AddWithValue("@vejiga", est[indice - 1].prep.vejiga);
                    cmd.Parameters.AddWithValue("@creatinina", est[indice - 1].prep.creatinina);
                    cmd.Parameters.AddWithValue("@microlax", est[indice - 1].prep.microlax);
                    cmd.Parameters.AddWithValue("@higiene", est[indice - 1].prep.higiene);
                    cmd.Parameters.AddWithValue("@metal", est[indice - 1].prep.metal);
                    cmd.Parameters.AddWithValue("@trojes", est[indice - 1].sucus.trojes);
                    cmd.Parameters.AddWithValue("@galerias", est[indice - 1].sucus.galerias);
                    cmd.Parameters.AddWithValue("@matriz", est[indice - 1].sucus.matriz);
                    cmd.Parameters.AddWithValue("@norte", est[indice - 1].sucus.norte);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estudio guardado correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }
      
        //Boton para limpiar o "resetear" los valores del form
        private void button1_Click(object sender, EventArgs e)
        {
            //Limpieza de cuadros de texto [id,nombre, costo]
            txtid.Text = "";    
            txtestudio.Text = "";
            txtcosto.Text = "";
            //Limpieza de valores en chb para preparaciones
            chbayuno.Checked = false;
            chbvejiga.Checked = false;
            chbcrea.Checked = false;
            chbmicro.Checked = false;
            chbhigiene.Checked = false;
            chbmetal.Checked = false;
            //Limpieza de valores en chb para sucursales
            chbtrojes.Checked = false;
            chbgalerias.Checked = false;
            chbmatriz.Checked = false;
            chbnorte.Checked = false;
            //Limpieza de valores en rb para cita
            rbsi.Checked = false;
            rbno.Checked = false;
        }

        //Boton para consultar los estudios
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //Reseteo de valores totales
            chbayuno.Checked = false;
            chbvejiga.Checked = false;
            chbcrea.Checked = false;
            chbmicro.Checked = false;
            chbhigiene.Checked = false;
            chbmetal.Checked = false;
            chbtrojes.Checked = false;
            chbgalerias.Checked = false;
            chbmatriz.Checked = false;
            chbnorte.Checked = false;
            rbsi.Checked = false;
            rbno.Checked = false;

            //Busqueda
            string nom = txtestudio.Text.Trim();
            int idBuscado;
            int.TryParse(txtid.Text, out idBuscado);

            // 🔹 Buscar en la base de datos
            try
            {
                string query = "SELECT * FROM estudios WHERE id = @id OR nombre = @nombre LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idBuscado);
                cmd.Parameters.AddWithValue("@nombre", nom);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtid.Text = reader["id"].ToString();
                    txtestudio.Text = reader["nombre"].ToString();
                    txtcosto.Text = reader["costo"].ToString();

                    rbsi.Checked = Convert.ToInt32(reader["cita"]) == 1;
                    rbno.Checked = Convert.ToInt32(reader["cita"]) == 2;

                    chbayuno.Checked = Convert.ToInt32(reader["ayuno"]) == 1;
                    chbvejiga.Checked = Convert.ToInt32(reader["vejiga"]) == 1;
                    chbcrea.Checked = Convert.ToInt32(reader["creatinina"]) == 1;
                    chbmicro.Checked = Convert.ToInt32(reader["microlax"]) == 1;
                    chbhigiene.Checked = Convert.ToInt32(reader["higiene"]) == 1;
                    chbmetal.Checked = Convert.ToInt32(reader["metal"]) == 1;

                    chbtrojes.Checked = Convert.ToInt32(reader["trojes"]) == 1;
                    chbgalerias.Checked = Convert.ToInt32(reader["galerias"]) == 1;
                    chbmatriz.Checked = Convert.ToInt32(reader["matriz"]) == 1;
                    chbnorte.Checked = Convert.ToInt32(reader["norte"]) == 1;

                    reader.Close();
                    return;
                }
                reader.Close();
                MessageBox.Show("No se encontró el estudio en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }


            for (int i = 0; i < indice; i++) // solo recorro hasta lo registrado
            {
                if ((idBuscado != 0 && est[i].id == idBuscado) ||
                    (!string.IsNullOrEmpty(nom) && est[i].nombre == nom))
                {
                    CargarEstudio(est[i]);
                    return; // salgo porque ya lo encontré
                }
            }

            MessageBox.Show("No se encontró el estudio.");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(txtid.Text.Trim(), out id))
                {
                    MessageBox.Show("El ID debe ser un número válido antes de modificar.");
                    return;
                }

                int costo;
                if (!int.TryParse(txtcosto.Text.Trim(), out costo))
                {
                    MessageBox.Show("El costo debe ser un número válido.");
                    return;
                }

                string query = "UPDATE estudios SET nombre=@nombre, costo=@costo, cita=@cita, ayuno=@ayuno, vejiga=@vejiga, creatinina=@creatinina, microlax=@microlax, higiene=@higiene, metal=@metal, trojes=@trojes, galerias=@galerias, matriz=@matriz, norte=@norte WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", txtestudio.Text.Trim());
                cmd.Parameters.AddWithValue("@costo", costo);
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
                    MessageBox.Show("Estudio modificado correctamente en la base de datos.");
                else
                    MessageBox.Show("No se encontró ningún registro con ese ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        //Boton para eliminar un estuido
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM estudios WHERE nombre=@nombre";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtestudio.Text);
                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                    MessageBox.Show("Estudio eliminado correctamente de la base de datos.");
                else
                    MessageBox.Show("No se encontró el estudio para eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        //Link para cerrar el formulario    
        private void lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


