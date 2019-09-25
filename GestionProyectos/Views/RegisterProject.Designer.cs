namespace GestionProyectos.Views
{
    partial class RegisterProject
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
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLenguajeProg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPresupuesto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lsvProject = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(46, 30);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(64, 20);
            this.txbCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de proyecto:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(46, 77);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(126, 20);
            this.txbNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lenguaje de Programación:";
            // 
            // txbLenguajeProg
            // 
            this.txbLenguajeProg.Location = new System.Drawing.Point(227, 30);
            this.txbLenguajeProg.Name = "txbLenguajeProg";
            this.txbLenguajeProg.Size = new System.Drawing.Size(126, 20);
            this.txbLenguajeProg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Presupuesto del proyecto:";
            // 
            // txbPresupuesto
            // 
            this.txbPresupuesto.Location = new System.Drawing.Point(227, 76);
            this.txbPresupuesto.Name = "txbPresupuesto";
            this.txbPresupuesto.Size = new System.Drawing.Size(77, 20);
            this.txbPresupuesto.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(158, 103);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(304, 302);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lsvProject
            // 
            this.lsvProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvProject.Location = new System.Drawing.Point(22, 148);
            this.lsvProject.Name = "lsvProject";
            this.lsvProject.Size = new System.Drawing.Size(357, 148);
            this.lsvProject.TabIndex = 10;
            this.lsvProject.UseCompatibleStateImageBehavior = false;
            this.lsvProject.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lenguaje";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Presupuesto";
            this.columnHeader4.Width = 80;
            // 
            // RegisterProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 337);
            this.Controls.Add(this.lsvProject);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPresupuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbLenguajeProg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodigo);
            this.Name = "RegisterProject";
            this.Text = "Cartera de Proyectos";
            this.Load += new System.EventHandler(this.RegisterProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLenguajeProg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPresupuesto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListView lsvProject;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}