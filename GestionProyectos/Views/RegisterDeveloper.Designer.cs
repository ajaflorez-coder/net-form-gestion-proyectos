namespace GestionProyectos.Views
{
    partial class RegisterDeveloper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lsbProyectos = new System.Windows.Forms.ListBox();
            this.lsvDevelopers = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(36, 33);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(100, 20);
            this.txbDni.TabIndex = 1;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(34, 77);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(100, 20);
            this.txbApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txbNombres
            // 
            this.txbNombres.Location = new System.Drawing.Point(36, 121);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(100, 20);
            this.txbNombres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(153, 161);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lsbProyectos
            // 
            this.lsbProyectos.FormattingEnabled = true;
            this.lsbProyectos.Location = new System.Drawing.Point(153, 33);
            this.lsbProyectos.Name = "lsbProyectos";
            this.lsbProyectos.Size = new System.Drawing.Size(187, 108);
            this.lsbProyectos.TabIndex = 7;
            // 
            // lsvDevelopers
            // 
            this.lsvDevelopers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDevelopers.Location = new System.Drawing.Point(32, 190);
            this.lsvDevelopers.Name = "lsvDevelopers";
            this.lsvDevelopers.Size = new System.Drawing.Size(308, 170);
            this.lsvDevelopers.TabIndex = 8;
            this.lsvDevelopers.UseCompatibleStateImageBehavior = false;
            this.lsvDevelopers.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proyectos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(265, 366);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombres";
            this.columnHeader3.Width = 102;
            // 
            // RegisterDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 401);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvDevelopers);
            this.Controls.Add(this.lsbProyectos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.label1);
            this.Name = "RegisterDeveloper";
            this.Text = "RegisterDeveloper";
            this.Load += new System.EventHandler(this.RegisterDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lsbProyectos;
        private System.Windows.Forms.ListView lsvDevelopers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}