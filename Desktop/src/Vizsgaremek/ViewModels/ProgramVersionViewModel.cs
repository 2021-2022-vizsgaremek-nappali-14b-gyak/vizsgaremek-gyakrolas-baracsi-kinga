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
        


        public string Title
        {
            get
            {
                return programInfo.Title.ToString();
            }
            set
            {
                Title = value;
            }

        }
        public string Company
        {
            get
            {
                return programInfo.Company.ToString();
            }
            set
            {
                Company = value;
            }

        }
        public string Description
        {
            get
            {
                return programInfo.Description.ToString();
            }
            set
            {
                Description = value;
            }

        }

        public ProgramVersionViewModel()
        {
            programInfo = new ProgramInfo();

        }
    }
}
