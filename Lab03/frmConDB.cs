using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class frmConDB : Form
    {
        SqlConnection conn;
        public frmConDB()
        {
            InitializeComponent();
        }

        private void frmConDB_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declaramos variables para almacenar los valores de los TextBox
            // y definimos una cadena
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + bd + ";";

            //La cadena de conexion cambia en funcion del estado del Checkbox
            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";

            //Abrir una conexion con el servidor, usando la cadena de conexion
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el Servidor: \n" + ex.ToString());
            }
        }
    }
}
