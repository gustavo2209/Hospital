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
    public partial class MedicosIns : Form
    {

        private Form1 form1;
        private MedicosQry medicosQry;

        public MedicosIns()
        {
            InitializeComponent();
            txtApeNomMedico.Focus();
        }

        public MedicosIns(Form1 form1, MedicosQry medicosQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.medicosQry = medicosQry;
        }

        private void MedicosIns_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboEspeMedico.DataSource = ds.Tables[0];
            cboEspeMedico.ValueMember = "idespecialidad";
            cboEspeMedico.DisplayMember = "especialidad";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtApeNomMedico.Text.Trim().Length > 0)
            {

                var confirmResult = MessageBox.Show("¿Está seguro de grabar este registro?", "CONFIRMAR GRABACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand();
                    cm.Connection = form1.cn;
                    cm.CommandText = "INSERT INTO medicos VALUES(" + cboEspeMedico.SelectedValue + ", '" + txtApeNomMedico.Text + "')";
                    //MessageBox.Show(cm.CommandText); // PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos grabados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtApeNomMedico.Focus();
            }
        }
    }
}
