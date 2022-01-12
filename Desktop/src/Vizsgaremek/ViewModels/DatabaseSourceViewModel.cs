using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabaseSource;
        private string selectedDatabaseSource;
        DatabaseSources repoDatabaseSources;

       
        public ObservableCollection<string> DisplayedDatabaseSource
        {
            get => displayedDatabaseSource;
        }

        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSource = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
        }


    }
}
