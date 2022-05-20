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
    public partial class EspecialidadesUpd : Form
    {

        private Form1 form1;
        private EspecialidadesQry especialidadesQry;

        public EspecialidadesUpd()
        {
            InitializeComponent();
        }

        public EspecialidadesUpd(Form1 form1, EspecialidadesQry especialidadesQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.especialidadesQry = especialidadesQry;
        }

        private void EspecialidadesUpd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboEspecialidad.DataSource = ds.Tables[0];
            cboEspecialidad.ValueMember = "idespecialidad";
            cboEspecialidad.DisplayMember = "especialidad";

            PintaDatos();
        }

        private void PintaDatos()
        {
            if (cboEspecialidad.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades WHERE idespecialidad = " + cboEspecialidad.SelectedValue, form1.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Select().ElementAt(0);
                txtUpdEspecialidad.Text = row["especialidad"].ToString();
            }
            else
            {
                MessageBox.Show("Seleccione Especialidad");
            }
        }

        private void cboEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PintaDatos();
        }

        private void btnActualizarEspecialidad_Click(object sender, EventArgs e)
        {
            if (txtUpdEspecialidad.Text.Trim().Length > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de actualizar este registro?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "UPDATE especialidades SET especialidad = '" + txtUpdEspecialidad.Text + "' WHERE idespecialidad = " + cboEspecialidad.SelectedValue;
                    //MessageBox.Show(cm.CommandText); PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos actualizados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(EspecialidadesQry))
                        {
                            ((EspecialidadesQry)form).consulta();
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
                txtUpdEspecialidad.Focus();
            }
        }
    }
}
