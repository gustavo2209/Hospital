
namespace Hospital.Citas
{
    partial class CitasIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasIns));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPacienteC = new System.Windows.Forms.ComboBox();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMedicoT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHoraCita = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(132, 224);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(330, 30);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar Datos";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpFechaHoraCita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMedicoT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboEspecialidades);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPacienteC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Necesarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos y Nombres de Paciente:";
            // 
            // cboPacienteC
            // 
            this.cboPacienteC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacienteC.FormattingEnabled = true;
            this.cboPacienteC.Location = new System.Drawing.Point(227, 32);
            this.cboPacienteC.Name = "cboPacienteC";
            this.cboPacienteC.Size = new System.Drawing.Size(328, 24);
            this.cboPacienteC.TabIndex = 1;
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(227, 72);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(328, 24);
            this.cboEspecialidades.TabIndex = 7;
            this.cboEspecialidades.SelectionChangeCommitted += new System.EventHandler(this.cboEspecialidades_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Especialidad:";
            // 
            // cboMedicoT
            // 
            this.cboMedicoT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicoT.FormattingEnabled = true;
            this.cboMedicoT.Location = new System.Drawing.Point(227, 114);
            this.cboMedicoT.Name = "cboMedicoT";
            this.cboMedicoT.Size = new System.Drawing.Size(328, 24);
            this.cboMedicoT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Médico Tratante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha y Hora de Cita:";
            // 
            // dtpFechaHoraCita
            // 
            this.dtpFechaHoraCita.Location = new System.Drawing.Point(227, 155);
            this.dtpFechaHoraCita.Name = "dtpFechaHoraCita";
            this.dtpFechaHoraCita.Size = new System.Drawing.Size(328, 22);
            this.dtpFechaHoraCita.TabIndex = 8;
            // 
            // CitasIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.back13;
            this.ClientSize = new System.Drawing.Size(614, 272);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CitasIns";
            this.Text = "Registro de Nueva Cita";
            this.Load += new System.EventHandler(this.CitasIns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMedicoT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPacienteC;
        private System.Windows.Forms.Label label1;
    }
}