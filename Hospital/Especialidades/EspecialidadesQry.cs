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

namespace Hospital.Especialidades
{
    public partial class EspecialidadesQry : Form
    {

        private Form1 form1;

        public EspecialidadesQry()
        {
            InitializeComponent();
        }

        public EspecialidadesQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void EspecialidadesQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idespecialidad AS 'CODIGO ESPECIALIDAD', especialidad AS 'ESPECIALIDAD' " +
                "FROM especialidades ORDER BY especialidad ASC", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvListaEspecialidades.DataSource = ds.Tables[0];

            dgvListaEspecialidades.Columns[0].Width = 100;
            dgvListaEspecialidades.Columns[1].Width = 400;
        }

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvListaEspecialidades.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este registro?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idespecialidad = Convert.ToInt32(dgvListaEspecialidades.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "DELETE FROM especialidades WHERE idespecialidad = " + idespecialidad;
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos eliminados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    consulta();
                }
            }
            else
            {
                MessageBox.Show("Seleccione fila a retirar");
            }
        }
    }
}
