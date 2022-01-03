using System;
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
                return "";
            }
        }

        public ProgramInfo() { }
    }
}
