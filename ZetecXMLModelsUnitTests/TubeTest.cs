using ZetecXMLModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZetecXMLModelsUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TubeTest and is intended
    ///to contain all TubeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TubeTest
    {

        private static System.Collections.Generic.List<Tube> myTubes;

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            myTubes = XMLModelReader.ReadTubesFromZetecModelFile("BGA-33110-SG.xml");
            System.Diagnostics.Debug.WriteLine(myTubes.Count);

        }
        
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Tube Constructor
        ///</summary>
        [TestMethod()]
        public void TubeConstructorTest()
        {
            Tube target = new Tube();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Tube target = myTubes[0]; 
            string expected = "Sec:XX Row:1 Col:1"; 
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GridX
        ///</summary>
        [TestMethod()]
        public void GridXTest()
        {
            Tube target = myTubes[0]; 
            int expected = 1; 
            int actual;
            actual = target.GridX;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for GridY
        ///</summary>
        [TestMethod()]
        public void GridYTest()
        {
            Tube target = myTubes[0]; 
            int expected = 1; 
            int actual;
            actual = target.GridY;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Tube target = myTubes[0]; 
            int expected = 1; 
            int actual;
            actual = target.ID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InletX
        ///</summary>
        [TestMethod()]
        public void InletXTest()
        {
            Tube target = myTubes[0]; 
            Decimal expected = 78.309M; 
            Decimal actual;
            actual = target.InletX;
            Assert.AreEqual(expected, actual);
             
        }

        /// <summary>
        ///A test for InletY
        ///</summary>
        [TestMethod()]
        public void InletYTest()
        {
            Tube target = myTubes[0];
            Decimal expected = 0.400M; 
            Decimal actual;
            actual = target.InletY;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IntletDisplaySymbolID
        ///</summary>
        [TestMethod()]
        public void IntletDisplaySymbolIDTest()
        {
            Tube target = myTubes[0];
            int expected = 1; 
            int actual;
            actual = target.IntletDisplaySymbolID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for LegacyID
        ///</summary>
        [TestMethod()]
        public void LegacyIDTest()
        {
            Tube target = myTubes[0];
            int expected = 58;
            int actual;
            actual = target.LegacyID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MaterialID
        ///</summary>
        [TestMethod()]
        public void MaterialIDTest()
        {
            Tube target = myTubes[0];
            int expected = 1;
            int actual;
            actual = target.MaterialID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for OutletDisplaySymbolID
        ///</summary>
        [TestMethod()]
        public void OutletDisplaySymbolIDTest()
        {
            Tube target = myTubes[0];
            int expected = 1;
            int actual;
            actual = target.OutletDisplaySymbolID;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for OutletX
        ///</summary>
        [TestMethod()]
        public void OutletXTest()
        {
            Tube target = myTubes[0];
            Decimal expected = 6.237M;
            Decimal actual;
            actual = target.OutletX;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for OutletY
        ///</summary>
        [TestMethod()]
        public void OutletYTest()
        {
            Tube target = myTubes[0];
            Decimal expected = 0.400M;
            Decimal actual;
            actual = target.OutletY;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SectionLabel
        ///</summary>
        [TestMethod()]
        public void SectionLabelTest()
        {
            Tube target = myTubes[0];
            string expected = "XX";
            string actual;
            actual = target.SectionLabel;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for XLabel
        ///</summary>
        [TestMethod()]
        public void XLabelTest()
        {
            Tube target = myTubes[0];
            string expected = "1"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.XLabel;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for YLabel
        ///</summary>
        [TestMethod()]
        public void YLabelTest()
        {
            Tube target = myTubes[0];
            string expected = "1";
            string actual;
            actual = target.YLabel;
            Assert.AreEqual(expected, actual);
        }
    }
}
