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

namespace Hospital.Reportes
{
    public partial class Reporte01 : Form
    {

        private Form1 form1;

        public Reporte01()
        {
            InitializeComponent();
        }

        public Reporte01(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Reporte01_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daE = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataTable dtE = new DataTable();
            daE.Fill(dtE);
            DataRow filaE = dtE.NewRow();
            filaE["especialidad"] = "Seleccione...";
            dtE.Rows.InsertAt(filaE, 0);

            cboEspecialidad.DataSource = dtE;
            cboEspecialidad.ValueMember = "idespecialidad";
            cboEspecialidad.DisplayMember = "especialidad";

            //Consulta();
        }

        private void MostrarMedicos(int idespecialidad)
        {
            if (cboEspecialidad.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand("SELECT idmedico, nombre FROM medicos WHERE idespecialidad = @idespecialidad", form1.cn);
                cmd.Parameters.AddWithValue("idespecialidad", idespecialidad);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["nombre"] = "Seleccione...";
                dt.Rows.InsertAt(dr, 0);

                cboMedico.DataSource = dt;
                cboMedico.ValueMember = "idmedico";
                cboMedico.DisplayMember = "nombre";
            }
            else
            {
                MessageBox.Show("Seleccione Especialidad");
            }
        }

        private void cboEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cboEspecialidad.SelectedIndex != -1)
            {
                int idespecialidad = Convert.ToInt32(cboEspecialidad.SelectedValue.ToString());
                MostrarMedicos(idespecialidad);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        public void Consulta()
        {
            if(cboEspecialidad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Especialidad", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEspecialidad.Focus();
            }
            else
            {
                if(cboMedico.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione Médico", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboEspecialidad.Focus();
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT P.nombre AS 'PACIENTE', " +
                                                            "FORMAT(diahora, 'dd/MM/yyyy HH:mm:ss tt') FECHA " +
                                                            "FROM pacientes P, citas C " +
                                                            "WHERE P.idpaciente = C.idpaciente " +
                                                            "AND C.idmedico = " + cboMedico.SelectedValue, form1.cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvResultados.DataSource = ds.Tables[0];

                    dgvResultados.Columns[0].Width = 300;
                    dgvResultados.Columns[1].Width = 200;
                }
            } 
        }
    }
}
