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
    public partial class PacientesUpd : Form
    {

        private Form1 form1;
        private PacientesQry pacientesQry;

        public PacientesUpd()
        {
            InitializeComponent();
        }

        public PacientesUpd(Form1 form1, PacientesQry pacientesQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.pacientesQry = pacientesQry;
        }

        private void PacientesUpd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idpaciente, nombre FROM pacientes", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboPaciente.DataSource = ds.Tables[0];
            cboPaciente.ValueMember = "idpaciente";
            cboPaciente.DisplayMember = "nombre";

            PintaDatos();
        }

        private void PintaDatos()
        {
            if (cboPaciente.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre, nacimiento FROM pacientes WHERE idpaciente = " + cboPaciente.SelectedValue, form1.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Select().ElementAt(0);
                txtUpdApeNom.Text = row["nombre"].ToString();
                dtpUpdFechaNac.Text = row["nacimiento"].ToString();
            }
            else
            {
                MessageBox.Show("Seleccione Paciente");
            }
        }

        private void cboPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PintaDatos();
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            if (txtUpdApeNom.Text.Trim().Length > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de actualizar este registro?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    DateTime dt1 = dtpUpdFechaNac.Value;

                    string s1 = dt1.Day + "-" + dt1.Month + "-" + dt1.Year;

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "set dateformat 'dmy' UPDATE pacientes SET nombre = '" + txtUpdApeNom.Text + "', nacimiento = '" + s1 + "' WHERE idpaciente = " + cboPaciente.SelectedValue;
                    //MessageBox.Show(cm.CommandText); PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos actualizados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(PacientesQry))
                        {
                            ((PacientesQry)form).consulta();
                            form.Activate();
                            form.BringToFront();
                        }
                    }

                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Digite nombres y apellidos del paciente", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdApeNom.Focus();
            }
        }
    }
}
