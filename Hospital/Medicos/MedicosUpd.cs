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
    public partial class MedicosUpd : Form
    {

        private Form1 form1;
        private MedicosQry medicosQry;

        public MedicosUpd()
        {
            InitializeComponent();
        }

        public MedicosUpd(Form1 form1, MedicosQry medicosQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.medicosQry = medicosQry;
        }

        private void MedicosUpd_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idmedico, nombre FROM medicos", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboMedico.DataSource = ds.Tables[0];
            cboMedico.ValueMember = "idmedico";
            cboMedico.DisplayMember = "nombre";

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            cboUpdEspeMedico.DataSource = ds2.Tables[0];
            cboUpdEspeMedico.ValueMember = "idespecialidad";
            cboUpdEspeMedico.DisplayMember = "especialidad";

            PintaDatos();
        }

        private void PintaDatos()
        {
            if (cboMedico.SelectedIndex != -1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idespecialidad, nombre FROM medicos WHERE idmedico = " + cboMedico.SelectedValue, form1.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Select().ElementAt(0);
                txtUpdApeNomMedico.Text = row["nombre"].ToString();
                cboUpdEspeMedico.SelectedValue = Convert.ToInt32(row["idespecialidad"].ToString());
            }
            else
            {
                MessageBox.Show("Seleccione Médico");
            }
        }

        private void btnActualizarMédico_Click(object sender, EventArgs e)
        {
            if (txtUpdApeNomMedico.Text.Trim().Length > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de actualizar este registro?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand();

                    cm.Connection = form1.cn;
                    cm.CommandText = "UPDATE medicos SET idespecialidad = " + cboUpdEspeMedico.SelectedIndex + ", nombre = '" + txtUpdApeNomMedico.Text + "' WHERE idmedico = " + cboMedico.SelectedValue;
                    MessageBox.Show(cm.CommandText); //PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos actualizados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(MedicosQry))
                        {
                            ((MedicosQry)form).consulta();
                            form.Activate();
                            form.BringToFront();
                        }
                    }

                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Digite nombres y apellidos del médico", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdApeNomMedico.Focus();
            }
        }

        private void cboMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PintaDatos();
        }
    }
}
