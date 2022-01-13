using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vizsgaremek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels.Tests
{
    [TestClass()]
    public class DatabaseSourceViewModelTests
    {
        [TestMethod()]
        public void DatabaseSourceViewModelTest()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            //felhasználó rákattintott a localhost szóra
            databaseSourceViewModel.SelectedDatabaseSource = "localhost";
            DbSource expectedDbSource = DbSource.LOCALHOST;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'localhost', de nem váltott át DbSource.LOCALHOST-ra");

        }
        [TestMethod()]
        public void DatabaseSourceViewModelTestDevops()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            //felhasználó rákattintott a localhost szóra
            databaseSourceViewModel.SelectedDatabaseSource = "devops";
            DbSource expectedDbSource = DbSource.DEVOPS;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'devops', de nem váltott át DbSource.DEVOPS-ra");
        }
        [TestMethod()]
        public void DatabaseSourceViewModelTestNone()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            //felhasználó rákattintott a localhost szóra
            databaseSourceViewModel.SelectedDatabaseSource = "none";
            DbSource expectedDbSource = DbSource.NONE;

            DbSource actualDbSource = databaseSourceViewModel.DbSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'none', de nem váltott át DbSource.NONE-ra");
        }
    }
}