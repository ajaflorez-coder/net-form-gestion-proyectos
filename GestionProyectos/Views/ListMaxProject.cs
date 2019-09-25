using GestionProyectos.Controllers;
using GestionProyectos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos.Views
{
    public partial class ListMaxProject : Form
    {
        private GestorController GestorController;
        public ListMaxProject()
        {
            InitializeComponent();
            GestorController = new GestorController();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListMaxProject_Load(object sender, EventArgs e)
        {
            // Agregar los project al ListView
            foreach (Project project in GestorController.FindProjectsMaxDevelopers())
            {
                AddProjectToListView(project);
            }
        }
        private void AddProjectToListView(Project project)
        {
            ListViewItem item = new ListViewItem(project.Codigo.ToString());
            item.SubItems.Add(project.Nombre);
            item.SubItems.Add(project.LenguajeProg);
            item.SubItems.Add(Convert.ToString(project.Presupuesto));

            lsvProject.Items.Add(item);
        }
    }
}
