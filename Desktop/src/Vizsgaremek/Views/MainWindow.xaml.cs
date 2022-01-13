using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vizsgaremek.Views.Navigation;
using Vizsgaremek.Views.Pages;
using Vizsgaremek.ViewModels;

namespace Vizsgaremek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainWindowViewModel;
        DatabaseSourceViewModel databaseSourceViewModel;


        public MainWindow()
        {
            //különböző ablakok adatai
            mainWindowViewModel = new MainWindowViewModel();
            databaseSourceViewModel = new DatabaseSourceViewModel();
            mainWindowViewModel.SelectedSource = databaseSourceViewModel.DisplayedDatabaseSource;
            InitializeComponent();
            //A MainWindow ablakban megjelenő adatok a MainWindowViewModel-ben vannak
            this.DataContext = mainWindowViewModel;


            //Statikus osztály a Navigate
            //Eltárolja a nyitó ablakot, hogy azon tudjuk mósodítani a "page"-eket
            Navigate.mainWindow = this;
            //Létrehozzuk a nyitó "UserControl"WelcomePage
            WelcomePage welcomePage = new WelcomePage();
            //Megjelenítjük a WelcomePage-et
            Navigate.Navigation(welcomePage);
        }

        /// <summary>
        /// ListView elem bal egér gomb fel lett engedve
        /// </summary>
        /// <param name="sender">ListView, amin megnyomtuk a bal egérgombot</param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListView lwMenu = sender as ListView;
            ListViewItem lwMenuItem = lwMenu.SelectedItem as ListViewItem; //as helyett típuskényszerítés

            if (lwMenuItem != null)
            {
                //x:Name tulajdonságot vizsgáljuk
                switch (lwMenuItem.Name)
                {
                    case "lwiExit":
                        Close();
                        break;
                    case "lwiDatabaseSourceSelection":
                        DatabaseSourcePage databaseSourcePage = new DatabaseSourcePage(databaseSourceViewModel);
                        Navigate.Navigation(databaseSourcePage);
                        break;
                    case "lwiProgramVersion":
                        ProgramVersion programVersion = new ProgramVersion();
                        Navigate.Navigation(programVersion);
                        break;
                   


                }
            }

        }
    }
}
