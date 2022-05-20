
namespace Hospital.Especialidades
{
    partial class EspecialidadesUpd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspecialidadesUpd));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdEspecialidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnActualizarEspecialidad = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtUpdEspecialidad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre:";
            // 
            // txtUpdEspecialidad
            // 
            this.txtUpdEspecialidad.Location = new System.Drawing.Point(19, 36);
            this.txtUpdEspecialidad.Name = "txtUpdEspecialidad";
            this.txtUpdEspecialidad.Size = new System.Drawing.Size(327, 23);
            this.txtUpdEspecialidad.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboEspecialidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Especialidad:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(18, 32);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(328, 24);
            this.cboEspecialidad.TabIndex = 0;
            this.cboEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cboEspecialidad_SelectionChangeCommitted);
            // 
            // btnActualizarEspecialidad
            // 
            this.btnActualizarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEspecialidad.Location = new System.Drawing.Point(22, 200);
            this.btnActualizarEspecialidad.Name = "btnActualizarEspecialidad";
            this.btnActualizarEspecialidad.Size = new System.Drawing.Size(364, 33);
            this.btnActualizarEspecialidad.TabIndex = 13;
            this.btnActualizarEspecialidad.Text = "Actualizar Datos";
            this.btnActualizarEspecialidad.UseVisualStyleBackColor = true;
            this.btnActualizarEspecialidad.Click += new System.EventHandler(this.btnActualizarEspecialidad_Click);
            // 
            // EspecialidadesUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.back13;
            this.ClientSize = new System.Drawing.Size(409, 252);
            this.Controls.Add(this.btnActualizarEspecialidad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EspecialidadesUpd";
            this.Text = "Actualizar datos de la Especialidad";
            this.Load += new System.EventHandler(this.EspecialidadesUpd_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdEspecialidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Button btnActualizarEspecialidad;
    }
}