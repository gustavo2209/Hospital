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

namespace Hospital.Medicos
{
    public partial class MedicosQry : Form
    {

        private Form1 form1;

        public MedicosQry()
        {
            InitializeComponent();
        }

        public MedicosQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void MedicosQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idmedico AS 'CODIGO DEL MÉDICO', E.especialidad AS 'ESPECIALIDAD', M.nombre AS 'NOMBRE DEL MÉDICO' " +
                "FROM especialidades E, medicos M WHERE E.idespecialidad = M.idespecialidad ORDER BY idmedico ASC", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvListaMedicos.DataSource = ds.Tables[0];
        }

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvListaMedicos.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este registro?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idmedico = Convert.ToInt32(dgvListaMedicos.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "DELETE FROM medicos WHERE idmedico = " + idmedico;
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
