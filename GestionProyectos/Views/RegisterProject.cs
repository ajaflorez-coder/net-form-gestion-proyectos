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
    public partial class RegisterProject : Form
    {
        private GestorController GestorController;
        public RegisterProject()
        {
            InitializeComponent();
            GestorController = new GestorController();
        }

        private void RegisterProject_Load(object sender, EventArgs e)
        {
            // Agregar los project al ListView
            foreach (Project project in GestorController.Projects)
            {
                AddProjectToListView(project);
            }            
        }
        private void AddProjectToListView( Project project )
        {
            ListViewItem item = new ListViewItem(project.Codigo.ToString());
            item.SubItems.Add(project.Nombre);
            item.SubItems.Add(project.LenguajeProg);
            item.SubItems.Add(Convert.ToString(project.Presupuesto));

            lsvProject.Items.Add(item);
        }
        private void ClearComponent()
        {
            txbCodigo.Clear();
            txbNombre.Clear();
            txbLenguajeProg.Clear();
            txbPresupuesto.Clear();
            txbCodigo.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txbCodigo.Text);
            string nombre = txbNombre.Text;
            string lenguajeProg = txbLenguajeProg.Text;
            int presupuesto = Convert.ToInt32(txbPresupuesto.Text);

            if (!GestorController.ExistsProject(codigo))
            {
                Project project = new Project() { Codigo = codigo, Nombre = nombre, LenguajeProg = lenguajeProg, Presupuesto = presupuesto };
                if(GestorController.addProject(project))
                {
                    AddProjectToListView(project);                    
                    MessageBox.Show("El proyecto se registro de forma satisfactoria.");
                    ClearComponent();
                }
                else
                {
                    MessageBox.Show("El proyecto NO se registro.");
                }
            }
            else
            {
                MessageBox.Show("El código de proyecto ya existe");
            }
        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
