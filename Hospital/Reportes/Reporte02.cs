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

namespace Hospital.Reportes
{
    public partial class Reporte02 : Form
    {

        private Form1 form1;

        public Reporte02()
        {
            InitializeComponent();
        }

        public Reporte02(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Reporte02_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";

            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Format = DateTimePickerFormat.Custom;

            Consulta();
        }

        public void Consulta()
        {
            DateTime dt1 = dtpFechaInicio.Value;
            DateTime dt2 = dtpFechaFin.Value;

            //yyyyMMdd
            string s1 = dt1.Year + String.Format("{0:00}", dt1.Month) + String.Format("{0:00}", dt1.Day);
            string s2 = dt2.Year + String.Format("{0:00}", dt2.Month) + String.Format("{0:00}", dt2.Day);

            SqlDataAdapter da = new SqlDataAdapter("SELECT P.nombre AS 'PACIENTE', " +
                "M.nombre AS 'MÉDICO', " +
                "E.especialidad AS 'ESPECIALIDAD', " +
                "FORMAT(diahora, 'dd/MM/yyyy HH:mm:ss tt') 'FECHA Y HORA DE CITA' FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND M.idespecialidad = E.idespecialidad AND FORMAT(diahora, 'yyyyMMdd') >= '" + s1 + "' " +
                "AND FORMAT(diahora, 'yyyyMMdd') <= '" + s2 + "'", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvResultados.DataSource = ds.Tables[0];

            dgvResultados.Columns[0].Width = 200;
            dgvResultados.Columns[1].Width = 250;
            dgvResultados.Columns[2].Width = 200;
            dgvResultados.Columns[3].Width = 180;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
    }
}
