using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ZetecXMLModels
{
    public class XMLModelReader
    {
       // Utility for reading Zete Model files testing
       // reader an Zetec Model file and get the appropriate elements/nodes out
       // We will not use only the bits we need to populate the BW Model files.
       // 
       public static MiscDrawingOptions ReadMiscOptionsFromZetecModelFile(String path )
       {    
            //Brute force wins again!!!
            //The goofy bit about this is that there should only be one of these.
            XElement xelement = XElement.Load(path);
            IEnumerable<XElement> miscList = xelement.Element("miscs").Elements("misc");

            List<MiscDrawingOptions> myMiscs = new List<MiscDrawingOptions>();
            foreach (var m in miscList)
            {
                System.Diagnostics.Debug.WriteLine("Misc Options");
                System.Diagnostics.Debug.WriteLine("-------------");
                System.Diagnostics.Debug.WriteLine("Text Color:\t\t", m.Element("text_color").Value);
                System.Diagnostics.Debug.WriteLine("Grid Color:\t\t", m.Element("grid_color").Value);
                System.Diagnostics.Debug.WriteLine("Group Outline Color:\t\t", m.Element("group_outline_color").Value);
                System.Diagnostics.Debug.WriteLine("BG Color:\t\t", m.Element("background_color").Value);
                System.Diagnostics.Debug.WriteLine("FG Color:\t\t", m.Element("foreground_color").Value);
                System.Diagnostics.Debug.WriteLine("Grid Scale:\t\t", m.Element("grid_scale").Value);
                System.Diagnostics.Debug.WriteLine("Symbol Size:\t\t", m.Element("symbol_size").Value);
                System.Diagnostics.Debug.WriteLine("Pixels per Inch:\t", m.Element("pixels_per_inch").Value);
                MiscDrawingOptions myMisc = new MiscDrawingOptions();
                myMisc.SymbolSize = (int)m.Element("symbol_size");
                myMisc.PixelsPerInch = (decimal)m.Element("pixels_per_inch");
                myMisc.TextColor = System.Drawing.ColorTranslator.FromHtml(m.Element("text_color").Value);
                myMisc.GridColor = System.Drawing.ColorTranslator.FromHtml(m.Element("grid_color").Value);
                myMisc.GroupOutlineColor = System.Drawing.ColorTranslator.FromHtml(m.Element("group_outline_color").Value);
                myMisc.BackgroundColor = System.Drawing.ColorTranslator.FromHtml(m.Element("background_color").Value);
                myMisc.ForegroundColor = System.Drawing.ColorTranslator.FromHtml(m.Element("foreground_color").Value);
                myMiscs.Add(myMisc);
            }
            return myMiscs.FirstOrDefault(); //If we get a null object if empty.
       }
       public static List<Tube> ReadTubesFromZetecModelFile(String path)
       {
           XElement xelement = XElement.Load(path);
           List<Tube> myTubes = new List<Tube>();
           IEnumerable<XElement> tubelist = xelement.Element("tubes").Elements("tube");
           foreach (var t in tubelist)
           {
               Tube tube = new Tube();
               tube.ID = Convert.ToInt32(t.Attribute("id").Value.Substring(5));
               tube.LegacyID = Convert.ToInt32(t.Attribute("legacy_tube_id").Value);
               tube.GridX = Convert.ToInt32(t.Attribute("grid_x").Value);
               tube.GridY = Convert.ToInt32(t.Attribute("grid_y").Value);
               tube.OutletDisplaySymbolID = Convert.ToInt32(t.Attribute("cl_ds_id").Value.Substring(3));
               tube.IntletDisplaySymbolID = Convert.ToInt32(t.Attribute("hl_ds_id").Value.Substring(3));
               tube.MaterialID = Convert.ToInt32(t.Attribute("mat_id").Value.Substring(3));
               tube.OutletX = Convert.ToDecimal(t.Attribute("cl_x").Value);
               tube.OutletY = Convert.ToDecimal(t.Attribute("cl_y").Value);
               tube.InletX = Convert.ToDecimal(t.Attribute("hl_x").Value);
               tube.InletY = Convert.ToDecimal(t.Attribute("hl_y").Value);
               tube.XLabel = t.Attribute("x_label").Value;
               tube.YLabel = t.Attribute("y_label").Value;
               tube.SectionLabel = t.Attribute("sec_label").Value.Substring(5);
               myTubes.Add(tube);

               //System.Diagnostics.Debug.WriteLine("ID:\t\t{0}", t.Attribute("id").Value);
               //System.Diagnostics.Debug.WriteLine("LegacyID:\t\t{0}", t.Attribute("legacy_tube_id").Value);
               //System.Diagnostics.Debug.WriteLine("GridX:\t\t{0}", t.Attribute("grid_x").Value);
               //System.Diagnostics.Debug.WriteLine("GridY:\t\t{0}", t.Attribute("grid_y").Value);
               //System.Diagnostics.Debug.WriteLine("ClDsID:\t\t{0}", t.Attribute("cl_ds_id").Value);
               //System.Diagnostics.Debug.WriteLine("HlDsID:\t\t{0}", t.Attribute("hl_ds_id").Value);
               //System.Diagnostics.Debug.WriteLine("MatlID:\t\t{0}", t.Attribute("mat_id").Value);
               //System.Diagnostics.Debug.WriteLine("Cl X:\t\t{0}", t.Attribute("cl_x").Value);
               //System.Diagnostics.Debug.WriteLine("Cl Y:\t\t{0}", t.Attribute("cl_y").Value);
               //System.Diagnostics.Debug.WriteLine("Hl X:\t\t{0}", t.Attribute("hl_x").Value);
               //System.Diagnostics.Debug.WriteLine("Hl Y:\t\t{0}", t.Attribute("hl_y").Value);
               //System.Diagnostics.Debug.WriteLine("X Label:\t\t{0}", t.Attribute("x_label").Value);
               //System.Diagnostics.Debug.WriteLine("Y Label:\t\t{0}", t.Attribute("y_label").Value);
               //System.Diagnostics.Debug.WriteLine("Sec Label:\t\t{0}", t.Attribute("sec_label").Value);

           }
           Console.WriteLine("Returning {0} tubes.", myTubes.Count);
           return myTubes;
       }
       public static VesselInformation ReadVesselInformationFromZetecModelFile(String path)
       {
           
           XElement xelement = XElement.Load(path);
           IEnumerable<XElement> vesselXElements = xelement.Element("vessels").Elements("vessel");

           List<VesselInformation> myVesselInformationList = new List<VesselInformation>();
           foreach (var v in vesselXElements)
           {
               VesselInformation myVesselInfo = new VesselInformation();
               myVesselInfo.OutletCalNumbering = (CalNumberingType)Enum.Parse(typeof(CalNumberingType), v.Attribute("cl_cal_numbering").Value);
               myVesselInfo.InletCalNumbering = (CalNumberingType)Enum.Parse(typeof(CalNumberingType), v.Attribute("hl_cal_numbering").Value);
               myVesselInfo.InletChannelHead = (ChannelHeadLocationType)Enum.Parse(typeof(ChannelHeadLocationType), v.Attribute("hl_channelhead").Value);
               myVesselInfo.InletRow1Col1Location = (InletRow1Col1LocationType)Enum.Parse(typeof(InletRow1Col1LocationType), v.Attribute("hl_r1c1_location").Value);
               myVesselInfo.YxXyNotation = (YxXyNotationType)Enum.Parse(typeof(YxXyNotationType), v.Attribute("yx_xy_notation").Value);
               myVesselInfo.VesselType = (VesselType)Enum.Parse(typeof(VesselType), v.Attribute("vessel_type").Value);
               myVesselInfo.SectionsActive = Convert.ToBoolean(v.Attribute("section_active").Value);
               myVesselInfo.VesselIDType = (VesselIDType)Enum.Parse(typeof(VesselIDType), v.Attribute("vessel_id_type").Value);
               myVesselInfo.UtilityDesignation = v.Element("utility_designation").Value;
               myVesselInfo.UtilityName = v.Element("utility").Value;
               myVesselInfo.ModelDesignation = v.Element("model_designation").Value;
               myVesselInfo.ModelName = v.Element("model").Value;
               myVesselInfo.PlantDesignation = v.Element("plant_designation").Value;
               myVesselInfo.PlantName = v.Element("plant").Value;
               myVesselInfo.ComponentDesignation = v.Element("component_designation").Value;
               myVesselInfo.ComponentName = v.Element("component").Value;
               myVesselInfo.Contractor = v.Element("contractor").Value;
               myVesselInfo.Unit = v.Element("unit").Value;
               myVesselInfo.InletVesselID = v.Element("hl_vessel_id").Value;
               myVesselInfo.OutletVesselID = v.Element("cl_vessel_id").Value;
               myVesselInfo.SectionDesignation = v.Element("section_designation").Value;
               myVesselInfo.YDesignation = v.Element("y_designation").Value;
               myVesselInfo.XDesignation = v.Element("x_designation").Value;
               myVesselInfo.MinimumTubeRadius = Convert.ToDecimal(v.Element("min_radius").Value);
               myVesselInfo.BowlRadius = Convert.ToDecimal(v.Element("bowl_radius").Value);
               myVesselInfo.TubeSheetNumberingType = (TubeSheetNumberType)Convert.ToInt32(v.Element("tubesheet_numbering_index").Value);

               myVesselInformationList.Add(myVesselInfo);

           }
           if (myVesselInformationList.FirstOrDefault() == null)
           {
               Console.WriteLine("The VesselInfo is null!");
               return new VesselInformation();
           }
           return myVesselInformationList.FirstOrDefault();
       }
       public static Section ReadSectionFromZetecModelFile(String path)
       {
           XElement xelement = XElement.Load(path);
           IEnumerable<XElement> SectionElements = xelement.Element("sections").Elements("section");

           List<Section> mySectionList = new List<Section>();
           foreach (var s in SectionElements)
           {
               Section mySection = new Section();
               Console.WriteLine("ID ... {0}", s.Attribute("id").Value.Substring(4)); 
               mySection.ID = Convert.ToInt32(s.Attribute("id").Value.Substring(4));
               mySection.ExternalDisplayEncode = s.Attribute("external_display_encode").Value;
               mySection.InternalDisplayEncode = s.Attribute("internal_display_encode").Value;
               mySection.NumOfColumns = Convert.ToInt32(s.Attribute("num_cols").Value);
               mySection.NumOfRows = Convert.ToInt32(s.Attribute("num_rows").Value);
               mySection.XPitch = Convert.ToDecimal(s.Attribute("x_pitch").Value);
               mySection.PitchType = (PitchType)Enum.Parse(typeof(PitchType),s.Attribute("pitch_type").Value);
               mySection.Label = s.Attribute("label").Value;
           }
           
           
           
           
           
           
           return mySectionList.FirstOrDefault();
       }
       public static ZetecModel ReadZetecModel(String path)
       {
           ZetecModel ZetecModel = new ZetecModel();
           ZetecModel.MiscDrawingOptions = ReadMiscOptionsFromZetecModelFile(path);
           ZetecModel.Tubes = ReadTubesFromZetecModelFile(path);
           ZetecModel.VesselInformation = ReadVesselInformationFromZetecModelFile(path);
           ZetecModel.Section = ReadSectionFromZetecModelFile(path);
           //check to see if we are flaking out somewhere here...
           return ZetecModel;
       }

    }
}
