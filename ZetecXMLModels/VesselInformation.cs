using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetecXMLModels
{
    public enum CalNumberingType { BOTH, ODD, EVEN }
    public enum ChannelHeadLocationType { LEFT, RIGHT, CENTER }
    public enum InletRow1Col1LocationType { MANWAY, NOZZLE }
    public enum YxXyNotationType { YX_NOTATION, XY_NOTATION }
    public enum VesselType { RECIRC, OTSG }
    public enum VesselIDType { SET_BY_RESULTS }
    public enum TubeSheetNumberType { COORDINATE, BYROW }
    
    
    public class VesselInformation
    {
        public CalNumberingType OutletCalNumbering { get; set; }
        public CalNumberingType InletCalNumbering { get; set; }
        public ChannelHeadLocationType InletChannelHead { get; set; }
        public InletRow1Col1LocationType InletRow1Col1Location { get; set; }
        public YxXyNotationType YxXyNotation { get; set; }
        public VesselType VesselType { get; set; }
        public bool SectionsActive { get; set; }
        public VesselIDType VesselIDType { get; set; }
        public String UtilityDesignation { get; set; }
        public String UtilityName { get; set; }
        public String ModelDesignation { get; set; }
        public String ModelName { get; set; }
        public String PlantDesignation { get; set; }
        public String PlantName { get; set; }
        public String ComponentDesignation { get; set; }
        public String ComponentName { get; set; }
        public String Contractor { get; set; }
        public String Unit { get; set; }
        public String InletVesselID { get; set; }
        public String OutletVesselID { get; set; }
        public String SectionDesignation { get; set; }
        public String YDesignation { get; set; }
        public String XDesignation { get; set; }
        public Decimal MinimumTubeRadius { get; set; }
        public Decimal BowlRadius { get; set; }
        public TubeSheetNumberType TubeSheetNumberingType { get; set; }
    }
}
