using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    //view model réteg a megjelenítendő adatokat kell megadni
    class ProgramVersionViewModel
    {
        private ProgramInfo programInfo;
        public string Version
        {
            get
            {
                return programInfo.Version.ToString();
            }
            set
            {
                Version = value;
            }

        }

        public ProgramVersionViewModel()
        {
            programInfo = new ProgramInfo();

        }
    }
}
