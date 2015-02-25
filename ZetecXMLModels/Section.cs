using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetecXMLModels
{

    public enum PitchType { SQUARE, TRIANGLE_ODD, TRIANGLE_EVEN }

    public class Section
    {
        public int ID { get; set; }
        public String ExternalDisplayEncode { get; set; }
        public String InternalDisplayEncode { get; set; }
        public Int32 NumOfColumns { get; set; }
        public Int32 NumOfRows { get; set; }
        public decimal XPitch { get; set; }
        public decimal YPitch { get; set; }
        public PitchType PitchType { get; set; }
        public String Label { get; set; }
    }
}
