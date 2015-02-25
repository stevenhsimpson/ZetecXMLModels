using ZetecXMLModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZetecXMLModelsUnitTests
{
    
    
    /// <summary>
    ///This is a test class for VesselInformationTest and is intended
    ///to contain all VesselInformationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VesselInformationTest
    {
        VesselInformation myVesselInformation;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            myVesselInformation = XMLModelReader.ReadVesselInformationFromZetecModelFile("BGA-33110-SG.xml");
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for VesselInformation Constructor
        ///</summary>
        [TestMethod()]
        public void VesselInformationConstructorTest()
        {
            VesselInformation target = new VesselInformation();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for BowlRadius
        ///</summary>
        [TestMethod()]
        public void BowlRadiusTest()
        {
            VesselInformation target = myVesselInformation;
            Decimal expected = 43.500999M; 
            Decimal actual;
            actual = target.BowlRadius;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ComponentDesignation
        ///</summary>
        [TestMethod()]
        public void ComponentDesignationTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "Component";
            string actual;
            actual = target.ComponentDesignation;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for ComponentName
        ///</summary>
        [TestMethod()]
        public void ComponentNameTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "component";
            string actual;
            actual = target.ComponentName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Contractor
        ///</summary>
        [TestMethod()]
        public void ContractorTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = string.Empty;
            string actual;
            actual = target.Contractor;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InletCalNumbering
        ///</summary>
        [TestMethod()]
        public void InletCalNumberingTest()
        {
            VesselInformation target = myVesselInformation;
            CalNumberingType expected = CalNumberingType.BOTH;
            CalNumberingType actual;
            actual = target.InletCalNumbering;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InletChannelHead
        ///</summary>
        [TestMethod()]
        public void InletChannelHeadTest()
        {
            VesselInformation target = myVesselInformation;
            ChannelHeadLocationType expected = ChannelHeadLocationType.LEFT;
            ChannelHeadLocationType actual;
            actual = target.InletChannelHead;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InletRow1Col1Location
        ///</summary>
        [TestMethod()]
        public void InletRow1Col1LocationTest()
        {
            VesselInformation target = myVesselInformation; 
            InletRow1Col1LocationType expected = InletRow1Col1LocationType.MANWAY;
            InletRow1Col1LocationType actual;
            actual = target.InletRow1Col1Location;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InletVesselID
        ///</summary>
        [TestMethod()]
        public void InletVesselIDTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "XX";
            string actual;
            actual = target.InletVesselID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MinimumTubeRadius
        ///</summary>
        [TestMethod()]
        public void MinimumTubeRadiusTest()
        {
            VesselInformation target = myVesselInformation;
            Decimal expected = 2.190000M; // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.MinimumTubeRadius;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ModelDesignation
        ///</summary>
        [TestMethod()]
        public void ModelDesignationTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "Model";
            string actual;
            actual = target.ModelDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ModelName
        ///</summary>
        [TestMethod()]
        public void ModelNameTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "BGA_33110_SG";
            string actual;
            actual = target.ModelName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for OutletCalNumbering
        ///</summary>
        [TestMethod()]
        public void OutletCalNumberingTest()
        {
            VesselInformation target = myVesselInformation;
            CalNumberingType expected = CalNumberingType.BOTH;
            CalNumberingType actual;
            actual = target.OutletCalNumbering;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for OutletVesselID
        ///</summary>
        [TestMethod()]
        public void OutletVesselIDTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "XX";
            string actual;
            actual = target.OutletVesselID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PlantDesignation
        ///</summary>
        [TestMethod()]
        public void PlantDesignationTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "Plant";
            string actual;
            actual = target.PlantDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PlantName
        ///</summary>
        [TestMethod()]
        public void PlantNameTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "Bruce_SG_A";
            string actual;
            actual = target.PlantName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SectionDesignation
        ///</summary>
        [TestMethod()]
        public void SectionDesignationTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "sec";
            string actual;
            actual = target.SectionDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SectionsActive
        ///</summary>
        [TestMethod()]
        public void SectionsActiveTest()
        {
            VesselInformation target = myVesselInformation; 
            bool expected = false;
            bool actual;
            target.SectionsActive = expected;
            actual = target.SectionsActive;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for TubeSheetNumberingType
        ///</summary>
        [TestMethod()]
        public void TubeSheetNumberingTypeTest()
        {
            VesselInformation target = myVesselInformation;
            TubeSheetNumberType expected = TubeSheetNumberType.COORDINATE;
            TubeSheetNumberType actual;
            actual = target.TubeSheetNumberingType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Unit
        ///</summary>
        [TestMethod()]
        public void UnitTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "A";
            string actual;
            actual = target.Unit;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for UtilityDesignation
        ///</summary>
        [TestMethod()]
        public void UtilityDesignationTest()
        {
            VesselInformation target = myVesselInformation; 
            string expected = "Utility";
            string actual;
            actual = target.UtilityDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for UtilityName
        ///</summary>
        [TestMethod()]
        public void UtilityNameTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = string.Empty;
            string actual;
            actual = target.UtilityName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for VesselIDType
        ///</summary>
        [TestMethod()]
        public void VesselIDTypeTest()
        {
            VesselInformation target = myVesselInformation;
            VesselIDType expected = VesselIDType.SET_BY_RESULTS;
            VesselIDType actual;
            actual = target.VesselIDType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for VesselType
        ///</summary>
        [TestMethod()]
        public void VesselTypeTest()
        {
            VesselInformation target = myVesselInformation; 
            VesselType expected = VesselType.RECIRC;
            VesselType actual;
            actual = target.VesselType;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for XDesignation
        ///</summary>
        [TestMethod()]
        public void XDesignationTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "COL";
            string actual;
            target.XDesignation = expected;
            actual = target.XDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for YDesignation
        ///</summary>
        [TestMethod()]
        public void YDesignationTest()
        {
            VesselInformation target = myVesselInformation;
            string expected = "ROW";
            string actual;
            actual = target.YDesignation;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for YxXyNotation
        ///</summary>
        [TestMethod()]
        public void YxXyNotationTest()
        {
            VesselInformation target = myVesselInformation; 
            YxXyNotationType expected = YxXyNotationType.YX_NOTATION;
            YxXyNotationType actual;
            actual = target.YxXyNotation;
            Assert.AreEqual(expected, actual);
        }
    }
}
