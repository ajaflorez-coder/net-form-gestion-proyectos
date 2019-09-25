namespace GestionProyectos.Views
{
    partial class ListDevelopers
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
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lsvDevelopers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proyecto:";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(117, 28);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(213, 21);
            this.cmbProyectos.TabIndex = 1;
            this.cmbProyectos.SelectedIndexChanged += new System.EventHandler(this.cmbProyectos_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(255, 243);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lsvDevelopers
            // 
            this.lsvDevelopers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDevelopers.Location = new System.Drawing.Point(25, 69);
            this.lsvDevelopers.Name = "lsvDevelopers";
            this.lsvDevelopers.Size = new System.Drawing.Size(305, 168);
            this.lsvDevelopers.TabIndex = 13;
            this.lsvDevelopers.UseCompatibleStateImageBehavior = false;
            this.lsvDevelopers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombres";
            // 
            // ListDevelopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 282);
            this.Controls.Add(this.lsvDevelopers);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbProyectos);
            this.Controls.Add(this.label1);
            this.Name = "ListDevelopers";
            this.Text = "ListDevelopers";
            this.Load += new System.EventHandler(this.ListDevelopers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListView lsvDevelopers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}