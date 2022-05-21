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
    public partial class CitasIns : Form
    {

        private Form1 form1;
        private CitasQry citasQry;

        public CitasIns()
        {
            InitializeComponent();
        }

        public CitasIns(Form1 form1, CitasQry citasQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.citasQry = citasQry;
        }

        private void CitasIns_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT idpaciente, nombre FROM pacientes", form1.cn);
            DataTable dtP = new DataTable();
            da.Fill(dtP);
            DataRow filaP = dtP.NewRow();
            filaP["nombre"] = "Seleccione...";
            dtP.Rows.InsertAt(filaP, 0);

            cboPacienteC.DataSource = dtP;
            cboPacienteC.ValueMember = "idpaciente";
            cboPacienteC.DisplayMember = "nombre";

            /* ------------------------------------------------------------------------------------------------------------ */

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT idespecialidad, especialidad FROM especialidades", form1.cn);
            DataTable dt = new DataTable();
            da2.Fill(dt);
            DataRow fila = dt.NewRow();
            fila["especialidad"] = "Seleccione...";
            dt.Rows.InsertAt(fila, 0);

            cboEspecialidades.DataSource = dt;
            cboEspecialidades.ValueMember = "idespecialidad";
            cboEspecialidades.DisplayMember = "especialidad";

            /* ------------------------------------------------------------------------------------------------------------ */

            dtpFechaHoraCita.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFechaHoraCita.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraCita.ShowUpDown = true;
        }

        private void MostrarMedicos(int idespecialidad)
        {
            if (cboEspecialidades.SelectedIndex != -1)
            {
                SqlCommand cmd = new SqlCommand("SELECT idmedico, nombre FROM medicos WHERE idespecialidad = @idespecialidad", form1.cn);
                cmd.Parameters.AddWithValue("idespecialidad", idespecialidad);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["nombre"] = "Seleccione...";
                dt.Rows.InsertAt(dr, 0);

                cboMedicoT.DataSource = dt;
                cboMedicoT.ValueMember = "idmedico";
                cboMedicoT.DisplayMember = "nombre";
            }
            else
            {
                MessageBox.Show("Seleccione Especialidad");
            }
        }

        private void cboEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idespecialidad = cboEspecialidades.SelectedIndex;
            MostrarMedicos(idespecialidad);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cboPacienteC.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione datos del Paciente", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPacienteC.Focus();
            }
            else
            {
                if (cboEspecialidades.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione Especialidad", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboEspecialidades.Focus();
                }
                else
                {
                    if (cboMedicoT.Items.Count == 1)
                    {
                        MessageBox.Show("No existen médicos para la especialidad seleccionada", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboMedicoT.Focus();
                    }
                    else
                    {
                        if(cboMedicoT.SelectedIndex == 0)
                        {
                            MessageBox.Show("Seleccione médico", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboMedicoT.Focus();
                        }
                        else
                        {
                            DateTime dt1 = dtpFechaHoraCita.Value;
                            string s1 = dt1.Day + "-" + dt1.Month + "-" + dt1.Year + " " + dt1.Hour + ":" + dt1.Minute + ":" + dt1.Second;

                            var confirmResult = MessageBox.Show("¿Está seguro de grabar este registro?", "CONFIRMAR GRABACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirmResult == DialogResult.Yes)
                            {

                                SqlCommand cm = new SqlCommand();
                                cm.Connection = form1.cn;
                                cm.CommandText = "set dateformat 'dmy' INSERT INTO citas VALUES(" + cboPacienteC.SelectedValue + ", " + cboMedicoT.SelectedValue + ", '" + s1 + "')";
                                //MessageBox.Show(cm.CommandText); // PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                                form1.cn.Open();
                                cm.ExecuteNonQuery();
                                form1.cn.Close();

                                MessageBox.Show("Datos grabados correctamente", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }
        }
    }
}
