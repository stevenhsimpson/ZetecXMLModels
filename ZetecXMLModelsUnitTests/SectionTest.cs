using ZetecXMLModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZetecXMLModelsUnitTests
{
    
    
    /// <summary>
    ///This is a test class for SectionTest and is intended
    ///to contain all SectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SectionTest
    {


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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///A test for Section Constructor
        ///</summary>
        [TestMethod()]
        public void SectionConstructorTest()
        {
            Section target = new Section();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for ExternalDisplayEncode
        ///</summary>
        [TestMethod()]
        public void ExternalDisplayEncodeTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ExternalDisplayEncode = expected;
            actual = target.ExternalDisplayEncode;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.ID = expected;
            actual = target.ID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InternalDisplayEncode
        ///</summary>
        [TestMethod()]
        public void InternalDisplayEncodeTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.InternalDisplayEncode = expected;
            actual = target.InternalDisplayEncode;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Label
        ///</summary>
        [TestMethod()]
        public void LabelTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Label = expected;
            actual = target.Label;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for NumOfColumns
        ///</summary>
        [TestMethod()]
        public void NumOfColumnsTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumOfColumns = expected;
            actual = target.NumOfColumns;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for NumOfRows
        ///</summary>
        [TestMethod()]
        public void NumOfRowsTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumOfRows = expected;
            actual = target.NumOfRows;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PitchType
        ///</summary>
        [TestMethod()]
        public void PitchTypeTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            PitchType expected = new PitchType(); // TODO: Initialize to an appropriate value
            PitchType actual;
            target.PitchType = expected;
            actual = target.PitchType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for XPitch
        ///</summary>
        [TestMethod()]
        public void XPitchTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            target.XPitch = expected;
            actual = target.XPitch;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for YPitch
        ///</summary>
        [TestMethod()]
        public void YPitchTest()
        {
            Section target = new Section(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            target.YPitch = expected;
            actual = target.YPitch;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
