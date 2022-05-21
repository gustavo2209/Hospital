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
    public partial class CitasQry : Form
    {

        private Form1 form1;

        public CitasQry()
        {
            InitializeComponent();
        }

        public CitasQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void CitasQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT C.idcita AS 'CÓDIGO DE CITA', " +
                "P.nombre AS 'APELLIDOS Y NOMBRES DEL PACIENTE', " +
                "M.nombre AS 'MÉDICO TRATANTE', " +
                "E.especialidad AS 'ESPECIALIDAD', " +
                "FORMAT(C.diahora, 'dd/MM/yyyy hh:mm:ss tt') AS 'FECHA Y HORA DE CITA' FROM citas C, pacientes P, medicos M, especialidades E " +
                "WHERE C.idpaciente = P.idpaciente AND C.idmedico = M.idmedico AND E.idespecialidad = M.idespecialidad", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvListaCitas.DataSource = ds.Tables[0];

        }
    }
}
