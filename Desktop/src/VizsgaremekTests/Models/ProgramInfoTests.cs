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
            Version expected = new Version(0,0,3,0);

            Version actual = programInfo.Version;
            Assert.AreEqual(expected, actual,"Version is not 0.0.3.0");
            
        }
    }
}