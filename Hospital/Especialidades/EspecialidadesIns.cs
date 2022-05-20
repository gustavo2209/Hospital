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
    public partial class EspecialidadesIns : Form
    {

        private Form1 form1;
        private EspecialidadesQry especialidadesQry;

        public EspecialidadesIns()
        {
            InitializeComponent();
            txtNomEspecialidad.Focus();
        }

        public EspecialidadesIns(Form1 form1, EspecialidadesQry especialidadesQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.especialidadesQry = especialidadesQry;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNomEspecialidad.Text.Trim().Length > 0)
            {

                var confirmResult = MessageBox.Show("¿Está seguro de grabar este registro?", "CONFIRMAR GRABACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand();
                    cm.Connection = form1.cn;
                    cm.CommandText = "INSERT INTO especialidades VALUES('" + txtNomEspecialidad.Text + "')";
                    //MessageBox.Show(cm.CommandText); // PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                    form1.cn.Open();
                    cm.ExecuteNonQuery();
                    form1.cn.Close();

                    MessageBox.Show("Datos grabados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Digite nombre de la especialidad", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomEspecialidad.Focus();
            }
        }
    }
}
