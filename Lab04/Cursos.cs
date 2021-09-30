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
using System.Data;

namespace Lab03
{
    public partial class Cursos : Form
    {
        SqlConnection conn;
        public Cursos(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void btnListar2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado2.DataSource = dt;
                dgvListado2.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta Cerrada");
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtTitulo.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoTitulo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "Title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado2.DataSource = dt;
                dgvListado2.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion es cerrada");
            }
        }
    }
}
