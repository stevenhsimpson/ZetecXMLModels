using ZetecXMLModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace ZetecXMLModelsUnitTests
{
    
    
    /// <summary>
    ///This is a test class for miscTest and is intended
    ///to contain all miscTest Unit Tests
    ///</summary>
    [TestClass()]
    public class miscTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        ///
        static MiscDrawingOptions myMisc = new MiscDrawingOptions();

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
            MiscDrawingOptions myMisc = XMLModelReader.ReadMiscOptionsFromZetecModelFile("BGA-33110-SG.xml");
        }
        //
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
        ///A test for misc Constructor
        ///</summary>
        [TestMethod()]
        public void miscConstructorTest()
        {
            MiscDrawingOptions target = new MiscDrawingOptions(); 
            //Assert.Inconclusive("TODO: Implement code to verify target");
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for background_color
        ///</summary>
        [TestMethod()]
        public void background_colorTest()
        {
            MiscDrawingOptions target = myMisc; 
            Color expected = new Color();
            expected = System.Drawing.ColorTranslator.FromHtml("#090947");
            Color actual;
            target.BackgroundColor = expected;
            actual = target.BackgroundColor;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for foreground_color
        ///</summary>
        [TestMethod()]
        public void foreground_colorTest()
        {
            MiscDrawingOptions target = myMisc;
            Color expected = new Color();
            expected = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            Color actual;
            target.ForegroundColor = expected;
            actual = target.ForegroundColor;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for grid_color
        ///</summary>
        [TestMethod()]
        public void grid_colorTest()
        {
            MiscDrawingOptions target = myMisc;
            Color expected = new Color();
            expected = System.Drawing.ColorTranslator.FromHtml("#14a80a");
            Color actual;
            target.GridColor = expected;
            actual = target.GridColor;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for grid_scale
        ///</summary>
        [TestMethod()]
        public void grid_scaleTest()
        {
            MiscDrawingOptions target = myMisc;
            int expected = target.GridScale; 
            int actual;
            target.GridScale = expected;
            actual = target.GridScale;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for group_outline_color
        ///</summary>
        [TestMethod()]
        public void group_outline_colorTest()
        {
            MiscDrawingOptions target = myMisc;
            Color expected = new Color();
            expected = System.Drawing.ColorTranslator.FromHtml("#871199");
            Color actual;
            target.GroupOutlineColor = expected;
            actual = target.GroupOutlineColor;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for pixels_per_inch
        ///</summary>
        [TestMethod()]
        public void pixels_per_inchTest()
        {
            MiscDrawingOptions target = myMisc;
            decimal expected = target.PixelsPerInch;
            decimal actual;
            target.PixelsPerInch = expected;
            actual = target.PixelsPerInch;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for symbol_size
        ///</summary>
        [TestMethod()]
        public void symbol_sizeTest()
        {
            MiscDrawingOptions target = myMisc;
            int expected = target.SymbolSize;
            int actual;
            target.SymbolSize = expected;
            actual = target.SymbolSize;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for text_color
        ///</summary>
        [TestMethod()]
        public void text_colorTest()
        {
            MiscDrawingOptions target = myMisc;
            Color expected = new Color();
            expected = System.Drawing.ColorTranslator.FromHtml("#2519fa");
            Color actual;
            target.TextColor = expected;
            actual = target.TextColor;
            Assert.AreEqual(expected, actual);
        }
    }
}
