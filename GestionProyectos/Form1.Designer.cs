namespace GestionProyectos
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProyectosToolStripMenuItem,
            this.registrarDevelopersToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.registroToolStripMenuItem.Text = "Registers";
            // 
            // registrarProyectosToolStripMenuItem
            // 
            this.registrarProyectosToolStripMenuItem.Name = "registrarProyectosToolStripMenuItem";
            this.registrarProyectosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarProyectosToolStripMenuItem.Text = "Register Projects";
            this.registrarProyectosToolStripMenuItem.Click += new System.EventHandler(this.registrarProyectosToolStripMenuItem_Click);
            // 
            // registrarDevelopersToolStripMenuItem
            // 
            this.registrarDevelopersToolStripMenuItem.Name = "registrarDevelopersToolStripMenuItem";
            this.registrarDevelopersToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarDevelopersToolStripMenuItem.Text = "Register Developers";
            this.registrarDevelopersToolStripMenuItem.Click += new System.EventHandler(this.registrarDevelopersToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDevelopersToolStripMenuItem,
            this.listProjectsToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.listadosToolStripMenuItem.Text = "Lists";
            // 
            // listDevelopersToolStripMenuItem
            // 
            this.listDevelopersToolStripMenuItem.Name = "listDevelopersToolStripMenuItem";
            this.listDevelopersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listDevelopersToolStripMenuItem.Text = "List Developers";
            this.listDevelopersToolStripMenuItem.Click += new System.EventHandler(this.listDevelopersToolStripMenuItem_Click);
            // 
            // listProjectsToolStripMenuItem
            // 
            this.listProjectsToolStripMenuItem.Name = "listProjectsToolStripMenuItem";
            this.listProjectsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listProjectsToolStripMenuItem.Text = "List Projects";
            this.listProjectsToolStripMenuItem.Click += new System.EventHandler(this.listProjectsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProjectsToolStripMenuItem;
    }
}

