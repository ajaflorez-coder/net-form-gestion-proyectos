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
    public partial class ListDevelopers : Form
    {
        private GestorController GestorController;
        public ListDevelopers()
        {
            InitializeComponent();
            GestorController = new GestorController();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListDevelopers_Load(object sender, EventArgs e)
        {
            cmbProyectos.DisplayMember = "Nombre";
            cmbProyectos.ValueMember = "Codigo";
            cmbProyectos.DataSource = GestorController.Projects;
        }

        private void cmbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = (Project)cmbProyectos.SelectedItem;
            lsvDevelopers.Items.Clear();
            // Agregar los developers al ListView
            foreach (Developer developer in GestorController.FindAllDevelopers(project.Codigo))
            {
                AddDeveloperToListView(developer);
            }
        }
        private void AddDeveloperToListView(Developer developer)
        {
            ListViewItem item = new ListViewItem(developer.DNI);
            item.SubItems.Add(developer.Apellidos);
            item.SubItems.Add(developer.Nombres);

            lsvDevelopers.Items.Add(item);
        }
    }
}
