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

namespace Hospital.Pacientes
{
    public partial class PacientesQry : Form
    {
        private Form1 form1;

        public PacientesQry()
        {
            InitializeComponent();
        }

        public PacientesQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void PacientesQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idpaciente AS 'CODIGO DEL PACIENTE', nombre AS 'APELLIDOS Y NOMBRES', nacimiento AS 'FECHA DE NACIMIENTO' " +
                "FROM pacientes ORDER BY nombre ASC", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvListaPacientes.DataSource = ds.Tables[0];
        }

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvListaPacientes.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este registro?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idpaciente = Convert.ToInt32(dgvListaPacientes.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "DELETE FROM pacientes WHERE idpaciente = " + idpaciente;
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
