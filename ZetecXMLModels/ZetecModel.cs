using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetecXMLModels
{
    public class ZetecModel
    {
        public Section Section { get; set; }
        public List<Tube> Tubes { get; set; }
        public VesselInformation VesselInformation { get; set; }
        public MiscDrawingOptions MiscDrawingOptions { get; set; }
    }
}
