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
using Hospital.Pacientes;
using Hospital.Especialidades;

namespace Hospital
{
    public partial class Form1 : Form
    {

        public SqlConnection cn;
        private PacientesQry pacientesQry;
        private EspecialidadesQry especialidadesQry;
        
        //private NotasQry notasQry;

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(local);Initial Catalog=parainfo;Integrated Security=SSPI;");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PacientesQry))
                {
                    form.Activate();
                    return;
                }
            }

            pacientesQry = new PacientesQry(this);
            pacientesQry.MdiParent = this;
            pacientesQry.Show();
            pacientesQry.BringToFront();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientesIns pacientesIns = new PacientesIns(this, pacientesQry);

            pacientesIns.MdiParent = this;
            pacientesIns.Show();
        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PacientesQry))
                {
                    pacientesQry = (PacientesQry)form;
                    pacientesQry.Activate();
                    pacientesQry.RetirarFila();

                    msg = false;
                    break;
                }
                else
                {
                    msg = true;
                }
            }

            if (msg)
            {
                MessageBox.Show("Para retirar active el formulario de CONSULTAS DE PACIENTES");
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientesUpd pacientesUpd = new PacientesUpd(this, pacientesQry);

            pacientesUpd.MdiParent = this;
            pacientesUpd.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EspecialidadesQry))
                {
                    form.Activate();
                    return;
                }
            }

            especialidadesQry = new EspecialidadesQry(this);
            especialidadesQry.MdiParent = this;
            especialidadesQry.Show();
            especialidadesQry.BringToFront();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EspecialidadesIns especialidadesIns = new EspecialidadesIns(this, especialidadesQry);

            especialidadesIns.MdiParent = this;
            especialidadesIns.Show();
        }

        private void retirarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EspecialidadesQry))
                {
                    especialidadesQry = (EspecialidadesQry)form;
                    especialidadesQry.Activate();
                    especialidadesQry.RetirarFila();

                    msg = false;
                    break;
                }
                else
                {
                    msg = true;
                }
            }

            if (msg)
            {
                MessageBox.Show("Para retirar active el formulario de CONSULTAS DE ESPECIALIDADES");
            }
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EspecialidadesUpd especialidadesUpd = new EspecialidadesUpd(this, especialidadesQry);

            especialidadesUpd.MdiParent = this;
            especialidadesUpd.Show();
        }
    }
}
