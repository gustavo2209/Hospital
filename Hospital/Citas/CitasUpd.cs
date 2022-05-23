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

            /*SqlDataAdapter daM = new SqlDataAdapter("SELECT idmedico, nombre FROM medicos", form1.cn);
            DataSet dsM = new DataSet();
            daM.Fill(dsM);

            cboMedicoTUpd.DataSource = dsM.Tables[0];
            cboMedicoTUpd.ValueMember = "idmedico";
            cboMedicoTUpd.DisplayMember = "nombre";*/

            MostrarDatos();
            MostrarMedicos(cboEspecialidadesCUpd.SelectedIndex);
            MessageBox.Show("" + cboEspecialidadesCUpd.SelectedIndex);
        }

        private void MostrarDatos()
        {
            if (cboIdCita.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT C.idcita AS idcita, " +
                "P.idpaciente, " +
                "M.idmedico, " +
                "E.idespecialidad, " +
                "FORMAT(C.diahora, 'dd/MM/yyyy hh:mm:ss tt') FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND E.idespecialidad = M.idespecialidad " +
                "AND idcita = " + cboIdCita.SelectedValue, form1.cn);

                /*SqlCommand cm = new SqlCommand();
                cm.Connection = form1.cn;
                cm.CommandText = "SELECT C.idcita AS idcita, " +
                "P.idpaciente, " +
                "M.idmedico, " +
                "E.idespecialidad, " +
                "FORMAT(C.diahora, 'dd/MM/yyyy hh:mm:ss tt') FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND E.idespecialidad = M.idespecialidad " +
                "AND idcita = " + cboIdCita.SelectedValue;

                MessageBox.Show(cm.CommandText);*/

                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Select().ElementAt(0);
                cboPacienteCUpd.SelectedValue = Convert.ToInt32(row["idpaciente"].ToString());
                cboEspecialidadesCUpd.SelectedValue = Convert.ToInt32(row["idespecialidad"].ToString());
                cboMedicoTUpd.SelectedValue = Convert.ToInt32(row["idmedico"].ToString());
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
            int idespecialidad = cboEspecialidadesCUpd.SelectedIndex;
            MostrarMedicos(idespecialidad);
        }
    }
}
