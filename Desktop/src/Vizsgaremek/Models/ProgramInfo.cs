﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public string Authors
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyAuthor = assembly.GetName().ToString();
                return assemblyAuthor;
            }
        }

        public string Title
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyTitle = assembly.GetName().ToString();
                return assemblyTitle;
            }
        }

        public string Description
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyDescription = assembly.GetName().ToString();
                return assemblyDescription;
            }
        }

        public string Company
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyCompany = assembly.GetName().ToString();
                return assemblyCompany;
            }
        }

        /*public Version Version1 { get => version; set => version = value; }
        public string Authors1 { get => authors; set => authors = value; }
        public string Description { get => description; set => description = value; }
        public string Title { get => title; set => title = value; }
        public string Company { get => company; set => company = value; }*/

        public ProgramInfo() 
        {
            Assembly assembly = Assembly.GetExecutingAssembly();


            foreach (Attribute attr in Attribute.GetCustomAttributes(assembly))
            {
                if (attr.GetType() == typeof(AssemblyTitleAttribute))
                    title = ((AssemblyTitleAttribute)attr).Title;
                else if (attr.GetType() == typeof(AssemblyDescriptionAttribute))
                    description = ((AssemblyDescriptionAttribute)attr).Description;
                else if (attr.GetType() == typeof(AssemblyCompanyAttribute))
                    company = ((AssemblyCompanyAttribute)attr).Company;

            }

        }
    }
}
