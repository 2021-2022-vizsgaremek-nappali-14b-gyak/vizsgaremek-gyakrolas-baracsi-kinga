using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vizsgaremek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0, 0, 3, 0);

            Version actual = programInfo.Version;
            Assert.AreEqual(expected, actual, "Version is not 0.0.3.0");

        }

        
        [TestMethod()]
        public void ProgramInfoTestTitle()
        {
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Vizsgaremek");

            string actual = programInfo.Title;
            Assert.AreEqual(expected, actual, "Hiba!");
        }

        [TestMethod()]
        public void ProgramInfoTestDescription()
        {
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Program MVVM része készítése");

            string actual = programInfo.Description;
            Assert.AreEqual(expected, actual, "Hiba!");
        }

        [TestMethod()]
        public void ProgramInfoTestCompany()
        {
            ProgramInfo programInfo = new ProgramInfo();
            string expected = new string("Vasvári");

            string actual = programInfo.Company;
            Assert.AreEqual(expected, actual, "Hiba!");
        }
    }
}