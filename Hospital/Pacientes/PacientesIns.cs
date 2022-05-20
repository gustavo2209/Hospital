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
    public partial class PacientesIns : Form
    {

        private Form1 form1;
        private PacientesQry pacientesQry;

        public PacientesIns()
        {
            InitializeComponent();
            txtApeNomPaciente.Focus();
        }

        public PacientesIns(Form1 form1, PacientesQry pacientesQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.pacientesQry = pacientesQry;
        }

        private void PacientesIns_Load(object sender, EventArgs e)
        {
            dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            dtpFechaNac.Format = DateTimePickerFormat.Custom;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(txtApeNomPaciente.Text.Trim().Length > 0)
            {

                var confirmResult = MessageBox.Show("¿Está seguro de grabar este registro?", "CONFIRMAR GRABACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    DateTime dt1 = dtpFechaNac.Value;

                    string s1 = dt1.Day + "-" + dt1.Month + "-" + dt1.Year;

                    SqlCommand cm = new SqlCommand();
                    cm.Connection = form1.cn;
                    cm.CommandText = "set dateformat 'dmy' INSERT INTO pacientes VALUES('" + txtApeNomPaciente.Text + "', '" + s1 + "')";
                    //MessageBox.Show(cm.CommandText); // PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos grabados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtApeNomPaciente.Focus();
            }
        }
    }
}
