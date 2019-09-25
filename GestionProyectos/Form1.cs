using GestionProyectos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new RegisterProject()).Show();
        }

        private void registrarDevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new RegisterDeveloper()).Show();
        }

        private void listDevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ListDevelopers()).Show();
        }

        private void listProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ListMaxProject()).Show();
        }
    }
}
