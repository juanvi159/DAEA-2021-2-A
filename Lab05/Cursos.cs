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

namespace Lab05
{
    public partial class Cursos : Form
    {
        SqlConnection con;
        public Cursos()
        {
            InitializeComponent();
        }
        private void Cursos_Load(object sender, EventArgs e)
        {
            String str = "Server=LAPTOP-QDCS59UR\\LOCAL;DataBase=School;Integrated Security=true;";
            con = new SqlConnection(str);
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btnListar2_Click(object sender, EventArgs e)
        {
            con.Open();
            String sql = "SELECT * FROM Course";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            con.Close();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "InsertCourse";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Credits", txtCredits.Text);
            cmd.Parameters.AddWithValue("DepartamentID", txtDepartamentID.Text);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nuevo Curso con codigo: " + codigo);
            con.Close();
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "UpdateCourse";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Credits", txtCredits.Text);
            cmd.Parameters.AddWithValue("DepartamentID", txtDepartamentID.Text);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }
            con.Close();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "DeleteCourse";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtCursosID.Text);

            int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Se ha eliminado el registro correctamente");
            }
            con.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtCursosID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtTitle.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtCredits.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtDepartamentID.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
