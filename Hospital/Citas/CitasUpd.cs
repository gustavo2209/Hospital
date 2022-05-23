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
    public partial class CitasUpd : Form
    {

        private Form1 form1;
        private CitasQry citasQry;

        public CitasUpd()
        {
            InitializeComponent();
        }

        public CitasUpd(Form1 form1, CitasQry citasQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.citasQry = citasQry;
        }

        private void CitasUpd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idcita FROM citas", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboIdCita.DataSource = ds.Tables[0];
            cboIdCita.ValueMember = "idcita";
            cboIdCita.DisplayMember = "idcita";

            SqlDataAdapter daP = new SqlDataAdapter("SELECT idpaciente, nombre FROM pacientes", form1.cn);
            DataSet dsP = new DataSet();
            daP.Fill(dsP);

            cboPacienteCUpd.DataSource = dsP.Tables[0];
            cboPacienteCUpd.ValueMember = "idpaciente";
            cboPacienteCUpd.DisplayMember = "nombre";

            SqlDataAdapter daE = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataSet dsE = new DataSet();
            daE.Fill(dsE);

            cboEspecialidadesCUpd.DataSource = dsE.Tables[0];
            cboEspecialidadesCUpd.ValueMember = "idespecialidad";
            cboEspecialidadesCUpd.DisplayMember = "especialidad";

            dtpFechaHoraCitaUpd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFechaHoraCitaUpd.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraCitaUpd.ShowUpDown = true;

            MostrarDatos();
            
        }

        private void MostrarDatos()
        {
            if (cboIdCita.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT C.idcita AS idcita, " +
                "P.idpaciente, " +
                "M.idmedico, " +
                "E.idespecialidad, " +
                "FORMAT(C.diahora, 'dd/MM/yyyy hh:mm:ss tt') AS 'fecha' FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND E.idespecialidad = M.idespecialidad " +
                "AND idcita = " + cboIdCita.SelectedValue, form1.cn);

                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Select().ElementAt(0);
                cboPacienteCUpd.SelectedValue = Convert.ToInt32(row["idpaciente"].ToString());
                cboEspecialidadesCUpd.SelectedValue = Convert.ToInt32(row["idespecialidad"].ToString());
                MostrarMedicos(Convert.ToInt32(cboEspecialidadesCUpd.SelectedValue));
                cboMedicoTUpd.SelectedValue = Convert.ToInt32(row["idmedico"].ToString());
                dtpFechaHoraCitaUpd.Value = Convert.ToDateTime(row["fecha"].ToString());
            }
            else
            {
                MessageBox.Show("Seleccione Especialidad");
            }
        }

        private void MostrarMedicos(int idespecialidad)
        {
            if (cboEspecialidadesCUpd.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand("SELECT idmedico, nombre FROM medicos WHERE idespecialidad = @idespecialidad", form1.cn);
                cmd.Parameters.AddWithValue("idespecialidad", idespecialidad);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cboMedicoTUpd.DataSource = dt;

                cboMedicoTUpd.ValueMember = "idmedico";
                cboMedicoTUpd.DisplayMember = "nombre";
            }
            else
            {
                MessageBox.Show("Seleccione Especialidad");
            }
        }

        private void cboIdCita_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void cboEspecialidadesCUpd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idespecialidad = Convert.ToInt32(cboEspecialidadesCUpd.SelectedValue);
            MostrarMedicos(idespecialidad);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de actualizar este registro?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                DateTime dt1 = dtpFechaHoraCitaUpd.Value;
                string s1 = dt1.Day + "-" + dt1.Month + "-" + dt1.Year + " " + dt1.Hour + ":" + dt1.Minute + ":" + dt1.Second;

                SqlCommand cm = new SqlCommand();

                cm.Connection = form1.cn;
                cm.CommandText = "set dateformat 'dmy' UPDATE citas SET idmedico = " + cboMedicoTUpd.SelectedValue + ", diahora = '" + s1 + "' WHERE idcita = " + cboIdCita.SelectedValue;
                //MessageBox.Show(cm.CommandText); //PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                form1.cn.Open();
                cm.ExecuteNonQuery();
                form1.cn.Close();

                MessageBox.Show("Datos actualizados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(CitasQry))
                    {
                        ((CitasQry)form).consulta();
                        form.Activate();
                        form.BringToFront();
                    }
                }

                this.Dispose();
            }
        }
    }
}
