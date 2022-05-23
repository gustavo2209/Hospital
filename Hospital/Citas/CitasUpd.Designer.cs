
namespace Hospital.Citas
{
    partial class CitasUpd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasUpd));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboIdCita = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaHoraCitaUpd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMedicoTUpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEspecialidadesCUpd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPacienteCUpd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(130, 274);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(330, 30);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboIdCita);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaHoraCitaUpd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMedicoTUpd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboEspecialidadesCUpd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPacienteCUpd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Necesarios:";
            // 
            // cboIdCita
            // 
            this.cboIdCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCita.FormattingEnabled = true;
            this.cboIdCita.Location = new System.Drawing.Point(227, 28);
            this.cboIdCita.Name = "cboIdCita";
            this.cboIdCita.Size = new System.Drawing.Size(62, 24);
            this.cboIdCita.TabIndex = 9;
            this.cboIdCita.SelectionChangeCommitted += new System.EventHandler(this.cboIdCita_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código de Cita:";
            // 
            // dtpFechaHoraCitaUpd
            // 
            this.dtpFechaHoraCitaUpd.Location = new System.Drawing.Point(227, 191);
            this.dtpFechaHoraCitaUpd.Name = "dtpFechaHoraCitaUpd";
            this.dtpFechaHoraCitaUpd.Size = new System.Drawing.Size(328, 22);
            this.dtpFechaHoraCitaUpd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha y Hora de Cita:";
            // 
            // cboMedicoTUpd
            // 
            this.cboMedicoTUpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicoTUpd.FormattingEnabled = true;
            this.cboMedicoTUpd.Location = new System.Drawing.Point(227, 150);
            this.cboMedicoTUpd.Name = "cboMedicoTUpd";
            this.cboMedicoTUpd.Size = new System.Drawing.Size(328, 24);
            this.cboMedicoTUpd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Médico Tratante:";
            // 
            // cboEspecialidadesCUpd
            // 
            this.cboEspecialidadesCUpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidadesCUpd.FormattingEnabled = true;
            this.cboEspecialidadesCUpd.Location = new System.Drawing.Point(227, 108);
            this.cboEspecialidadesCUpd.Name = "cboEspecialidadesCUpd";
            this.cboEspecialidadesCUpd.Size = new System.Drawing.Size(328, 24);
            this.cboEspecialidadesCUpd.TabIndex = 7;
            this.cboEspecialidadesCUpd.SelectionChangeCommitted += new System.EventHandler(this.cboEspecialidadesCUpd_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Especialidad:";
            // 
            // cboPacienteCUpd
            // 
            this.cboPacienteCUpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacienteCUpd.Enabled = false;
            this.cboPacienteCUpd.FormattingEnabled = true;
            this.cboPacienteCUpd.Location = new System.Drawing.Point(227, 68);
            this.cboPacienteCUpd.Name = "cboPacienteCUpd";
            this.cboPacienteCUpd.Size = new System.Drawing.Size(328, 24);
            this.cboPacienteCUpd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos y Nombres de Paciente:";
            // 
            // CitasUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.back13;
            this.ClientSize = new System.Drawing.Size(610, 322);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CitasUpd";
            this.Text = "Actualizar datos de Cita";
            this.Load += new System.EventHandler(this.CitasUpd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboIdCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraCitaUpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMedicoTUpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEspecialidadesCUpd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPacienteCUpd;
        private System.Windows.Forms.Label label1;
    }
}