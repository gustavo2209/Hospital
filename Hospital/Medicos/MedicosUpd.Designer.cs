
namespace Hospital.Medicos
{
    partial class MedicosUpd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicosUpd));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizarMédico = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdApeNomMedico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.cboUpdEspeMedico = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cboUpdEspeMedico);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 75);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Especialidad:";
            // 
            // btnActualizarMédico
            // 
            this.btnActualizarMédico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMédico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMédico.Location = new System.Drawing.Point(18, 296);
            this.btnActualizarMédico.Name = "btnActualizarMédico";
            this.btnActualizarMédico.Size = new System.Drawing.Size(364, 33);
            this.btnActualizarMédico.TabIndex = 15;
            this.btnActualizarMédico.Text = "Actualizar Datos";
            this.btnActualizarMédico.UseVisualStyleBackColor = true;
            this.btnActualizarMédico.Click += new System.EventHandler(this.btnActualizarMédico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtUpdApeNomMedico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 75);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apellidos y Nombres:";
            // 
            // txtUpdApeNomMedico
            // 
            this.txtUpdApeNomMedico.Location = new System.Drawing.Point(19, 36);
            this.txtUpdApeNomMedico.Name = "txtUpdApeNomMedico";
            this.txtUpdApeNomMedico.Size = new System.Drawing.Size(327, 23);
            this.txtUpdApeNomMedico.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboMedico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Médico:";
            // 
            // cboMedico
            // 
            this.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(18, 32);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(328, 24);
            this.cboMedico.TabIndex = 0;
            this.cboMedico.SelectionChangeCommitted += new System.EventHandler(this.cboMedico_SelectionChangeCommitted);
            // 
            // cboUpdEspeMedico
            // 
            this.cboUpdEspeMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdEspeMedico.FormattingEnabled = true;
            this.cboUpdEspeMedico.Location = new System.Drawing.Point(18, 32);
            this.cboUpdEspeMedico.Name = "cboUpdEspeMedico";
            this.cboUpdEspeMedico.Size = new System.Drawing.Size(328, 24);
            this.cboUpdEspeMedico.TabIndex = 0;
            // 
            // MedicosUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.back13;
            this.ClientSize = new System.Drawing.Size(405, 347);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnActualizarMédico);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicosUpd";
            this.Text = "Actualizar datos del Médico";
            this.Load += new System.EventHandler(this.MedicosUpd_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboUpdEspeMedico;
        private System.Windows.Forms.Button btnActualizarMédico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdApeNomMedico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMedico;
    }
}