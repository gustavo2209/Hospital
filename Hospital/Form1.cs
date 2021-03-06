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
using Hospital.Medicos;
using Hospital.Citas;
using Hospital.Reportes;

namespace Hospital
{
    public partial class Form1 : Form
    {

        public SqlConnection cn;
        private PacientesQry pacientesQry;
        private EspecialidadesQry especialidadesQry;
        private MedicosQry medicosQry;
        private CitasQry citasQry;

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

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MedicosQry))
                {
                    form.Activate();
                    return;
                }
            }

            medicosQry = new MedicosQry(this);
            medicosQry.MdiParent = this;
            medicosQry.Show();
            medicosQry.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MedicosIns medicosIns = new MedicosIns(this, medicosQry);

            medicosIns.MdiParent = this;
            medicosIns.Show();
        }

        private void retirarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MedicosQry))
                {
                    medicosQry = (MedicosQry)form;
                    medicosQry.Activate();
                    medicosQry.RetirarFila();

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
                MessageBox.Show("Para retirar active el formulario de CONSULTAS DE MÉDICOS");
            }
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MedicosUpd medicosUpd = new MedicosUpd(this, medicosQry);

            medicosUpd.MdiParent = this;
            medicosUpd.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CitasQry))
                {
                    form.Activate();
                    return;
                }
            }

            citasQry = new CitasQry(this);
            citasQry.MdiParent = this;
            citasQry.Show();
            citasQry.BringToFront();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CitasIns citasIns = new CitasIns(this, citasQry);

            citasIns.MdiParent = this;
            citasIns.Show();
        }

        private void retirarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CitasQry))
                {
                    citasQry = (CitasQry)form;
                    citasQry.Activate();
                    citasQry.RetirarFila();

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
                MessageBox.Show("Para retirar active el formulario de CONSULTAS DE MÉDICOS");
            }
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CitasUpd citasUpd = new CitasUpd(this, citasQry);

            citasUpd.MdiParent = this;
            citasUpd.Show();
        }

        private void citasPorMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reporte01))
                {
                    form.Activate();
                    return;
                }
            }

            Reporte01 reporte01 = new Reporte01(this);
            reporte01.MdiParent = this;
            reporte01.Show();
            reporte01.BringToFront();
        }

        private void rangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Reporte02))
                {
                    form.Activate();
                    return;
                }
            }

            Reporte02 reporte02 = new Reporte02(this);
            reporte02.MdiParent = this;
            reporte02.Show();
            reporte02.BringToFront();
        }
    }
}
