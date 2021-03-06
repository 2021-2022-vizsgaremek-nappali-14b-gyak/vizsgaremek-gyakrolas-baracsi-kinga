using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vizsgaremek.Views.Navigation
{
    public static class Navigate
    {
        //eltároljuk a MainWindow, hogy tudjunk váltani ablakot (pages)
        public static MainWindow mainWindow;

        /// <summary>
        /// egy új ablakra vált
        /// </summary>
        /// <param name="userControl">erre az ablakra váltunk</param>
        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Clear();
            mainWindow.PageContent.Children.Add(userControl);
        }
        public static void NavigationToFullScreen(Page userPage)
        {
            mainWindow.Content = userPage;
        }
    }
}
