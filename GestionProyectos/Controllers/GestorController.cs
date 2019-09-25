using GestionProyectos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Controllers
{
    public class GestorController
    {
        public static List<Project> Projects { get; set; }
        public static List<Developer> Developers { get; set; }

        static GestorController()
        {
            Projects = new List<Project>();
            Developers = new List<Developer>();
        }
        // Find Project By codigo
        public Project FindProject( int codigo )
        {
            return Projects.Find(delegate (Project project)
            {
                return project.Codigo == codigo;
            });
        }
        // Find Developer by DNI
        public Developer FindDeveloper(string dni)
        {
            return Developers.Find(delegate (Developer developer)
            {
                return developer.DNI == dni;
            });
        }

        // Return true if the Project exists in the Projects's List
        public bool ExistsProject(int codigo)
        {
            return Projects.Exists( delegate (Project project) {
                return project.Codigo == codigo;
            });
        }
        public bool ExistsProject(Project project)
        {
            return ExistsProject(project.Codigo);
        }
        // Registrar Proyectos de desarrollo de software, no se debe permitir repetido
        public bool addProject(Project project)
        {
            if( !ExistsProject(project.Codigo) )
            {
                Projects.Add(project);
                return true;
            }
            return false;
        }

        // Return true if the Developer exists in the Developer's List of Projects
        public bool ExistsDeveloper(int codigo, String dni)
        {
            Project projectWanted = FindProject(codigo);
            if(projectWanted != null)
            {
                return ExistsDeveloper(projectWanted.Developers, dni);
            }
            return false;
        }        
        public bool IsRepeatedDeveloper(List<Developer> developers, Developer developer)
        {
            return ExistsDeveloper(developers, developer.DNI);
        }
        public bool ExistsDeveloper(List<Developer> developers, String dni)
        {
            return developers.Exists(delegate (Developer developer) {
                return developer.DNI == dni;
            });
        }

        // Registrar Developers que participan en un Proyecto de desarrollo de software
        public bool addDeveloper( Project project, Developer developer )
        {
            if (!ExistsDeveloper(Developers, developer.DNI))
            {
                Developers.Add(developer);
            }
            if ( !ExistsDeveloper(project.Developers, developer.DNI) )
            {
                project.Developers.Add(developer);
                return true;
            }
            return false;
        }
        public bool addDeveloper(int codigo, Developer developer)
        {
            if( ExistsProject(codigo) )
            {
                return addDeveloper(FindProject(codigo), developer);
            }
            return false;
        }

        // Listar los Developers que participan en un Proyecto de Desarrollo de Software
        public List<Developer> FindAllDevelopers(int codigo)
        {
            if(ExistsProject(codigo))
            {
                return FindProject(codigo).Developers;
            }
            return new List<Developer>();
        }

        // Listar el o los Proyectos de Desarrollo de Software que tienen más Developers participando.
        public List<Project> FindProjectsMaxDevelopers()
        {
            List<Project> projectsMax = new List<Project>();
            int current = 0, max = 0;
            foreach (Project project in Projects)
            {
                current = project.Developers.Count;
                if (current >= max)
                {
                    if(current > max)
                    {
                        projectsMax.Clear();
                        max = current;
                    }
                    projectsMax.Add(project);
                }
            }
            return projectsMax;
        }
    }
}
