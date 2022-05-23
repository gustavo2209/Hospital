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

namespace Hospital.Citas
{
    public partial class CitasQry : Form
    {

        private Form1 form1;

        public CitasQry()
        {
            InitializeComponent();
        }

        public CitasQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void CitasQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT C.idcita AS 'CÓDIGO DE CITA', " +
                "P.nombre AS 'APELLIDOS Y NOMBRES DEL PACIENTE', " +
                "M.nombre AS 'MÉDICO TRATANTE', " +
                "E.especialidad AS 'ESPECIALIDAD', " +
                "FORMAT(C.diahora, 'dd/MM/yyyy hh:mm:ss tt') AS 'FECHA Y HORA DE CITA' FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND E.idespecialidad = M.idespecialidad", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvListaCitas.DataSource = ds.Tables[0];

            dgvListaCitas.Columns[0].Width = 100;
            dgvListaCitas.Columns[1].Width = 250;
            dgvListaCitas.Columns[2].Width = 250;
            dgvListaCitas.Columns[3].Width = 200;
            dgvListaCitas.Columns[4].Width = 180;

        }

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvListaCitas.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este registro?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idcita = Convert.ToInt32(dgvListaCitas.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "DELETE FROM citas WHERE idcita = " + idcita;
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
