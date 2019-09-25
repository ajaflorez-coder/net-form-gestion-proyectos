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
    public partial class RegisterDeveloper : Form
    {
        private GestorController GestorController;
        public RegisterDeveloper()
        {
            InitializeComponent();
            GestorController = new GestorController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterDeveloper_Load(object sender, EventArgs e)
        {
            // Agregar los projects al ListBox
            lsbProyectos.DisplayMember = "Nombre";
            lsbProyectos.ValueMember = "Codigo";
            lsbProyectos.DataSource = GestorController.Projects;
            lsbProyectos.SelectedIndex = -1;

            // Agregar los developers al ListView
            foreach (Developer developer in GestorController.Developers)
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
        private void ClearComponent()
        {
            txbDni.Clear();
            txbApellidos.Clear();
            txbNombres.Clear();
            txbDni.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = txbDni.Text;
            string apellidos = txbApellidos.Text;
            string nombres = txbNombres.Text;

            foreach (Project project in lsbProyectos.SelectedItems)
            {
                if (!GestorController.ExistsDeveloper(project.Codigo, dni))
                {
                    Developer developer = new Developer() { DNI = dni, Apellidos = apellidos, Nombres = nombres };
                    if (GestorController.addDeveloper(project.Codigo, developer) )
                    {
                        AddDeveloperToListView(developer);
                        MessageBox.Show("El Developer se registro de forma satisfactoria.");
                        ClearComponent();
                    }
                    else
                    {
                        MessageBox.Show("El developer NO se registro.");
                    }

                }
            }
        }
    }
}
