using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Diagnostics;


namespace Vizsgaremek.Models
{
   public class ProgramInfo
    {
        private Version version;
        private string authors;
        private string title;
        private string description;
        private string company;


        public Version Version
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyVersion = assembly.GetName().Version;
                return assemblyVersion;
            }
        }

        

        
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Company { get => company; set => company = value; }

        

        public ProgramInfo() 
        {
            

            Assembly assembly = Assembly.GetExecutingAssembly();


            foreach (Attribute attr in Attribute.GetCustomAttributes(assembly))
            {
                GetGithubCollaboratorsName();
                if (attr.GetType() == typeof(AssemblyTitleAttribute))
                    title = ((AssemblyTitleAttribute)attr).Title;
                else if (attr.GetType() == typeof(AssemblyDescriptionAttribute))
                    description = ((AssemblyDescriptionAttribute)attr).Description;
                else if (attr.GetType() == typeof(AssemblyCompanyAttribute))
                    company = ((AssemblyCompanyAttribute)attr).Company;

            }

        }
        private async void GetGithubCollaboratorsName()
        {
            string reponame = "baracsi-kinga";
            int repoId = 431761378;
            var client = new GitHubClient(new ProductHeaderValue(reponame));

            // fejlesztők meghatározása
            try
            {
                var collaborators = await client.Repository.GetAllContributors(repoId);
                string collaboratorsName = string.Empty;
                foreach (var collaborator in collaborators)
                {
                    string collaboratorLoginName = collaborator.Login;
                    var user = await client.User.Get(collaboratorLoginName);
                    collaboratorsName += user.Name + " (" + user.Login + ") ";
                }
                authors = collaboratorsName;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

    }
}
