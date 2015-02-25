using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetecXMLModels
{
    public class Tube
    {
        #region Members //TODO complete private implementation!!
        private int _id;
        private int _legacyId;
        private int _gridX;
        private int _gridY;
        private decimal _inletX;
        private decimal _inletY;

        
        #endregion

        #region Accessors
        public int ID { get; set; }
        public int LegacyID { get; set; }
        public int GridX { get; set; }
        public int GridY { get; set; }
        public int OutletDisplaySymbolID { get; set; }
        public int IntletDisplaySymbolID { get; set; }
        public int MaterialID { get; set; }
        public decimal OutletX { get; set; }
        public decimal OutletY { get; set; }
        public decimal InletX { get; set; }
        public decimal InletY { get; set; }
        public String XLabel { get; set; }
        public String YLabel { get; set; }
        public String SectionLabel { get; set; }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            String str = "Sec:" + SectionLabel + " Row:" + XLabel + " Col:"  + YLabel;
            return str;
        }
        #endregion
    }
}
