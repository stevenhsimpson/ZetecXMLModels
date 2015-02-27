using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ZetecModelWPFDemo
{
    public class TubeSheetModelView
    {
        public ObservableCollection<TubeViewModel> Tubes { get; set; }
        public int DefaultTubeSheetDisplaySizeY { get; set;}
        public int DefaultTubeSheetDisplaySizeX { get; set; }
        public decimal ScaleFactor { get; set; }
        public String ModelName { get; set; }

        public TubeSheetModelView(String path)
        {

            DefaultTubeSheetDisplaySizeX = 1200;
            DefaultTubeSheetDisplaySizeY = 800;
            ScaleFactor = 0.85M;

            Tubes = new ObservableCollection<TubeViewModel>();
            //read in the data...in real life we get a repository for this bit!
            ZetecXMLModels.ZetecModel zm = ZetecXMLModels.XMLModelReader.ReadZetecModel(path);

            ModelName = zm.VesselInformation.ModelName;
            
            if (zm != null)
            {
                //go thru make a bunch of tubeviews
                foreach (ZetecXMLModels.Tube tube in zm.Tubes)
                {
                    TubeViewModel tmv = new TubeViewModel(tube);
                    tmv.ID = tube.ID;
                    tmv.InletX = tube.InletX;
                    tmv.InletY = tube.InletY;
                    tmv.ToolTipString = "R" + tube.YLabel + "C" + tube.XLabel;
                    tmv.SymbolSize = zm.MiscDrawingOptions.SymbolSize;
                    tmv.TopPosition = DefaultTubeSheetDisplaySizeY - (double)(tube.InletY * zm.MiscDrawingOptions.PixelsPerInch * ScaleFactor + tmv.SymbolSize / 2);
                    tmv.LeftPosition = (double)(tube.InletX * zm.MiscDrawingOptions.PixelsPerInch * ScaleFactor - tmv.SymbolSize / 2);

                    if (tube.IntletDisplaySymbolID == 3)
                        tmv.SetToStay();
                    else if (tube.IntletDisplaySymbolID == 2)
                        tmv.SetToPlug();

                    Tubes.Add(tmv);
                }
            }
        }

    }
}
 
//Section- specifically the NumOfColumns, NumOfRows, XPitch, YPitch, PitchType
//MiscDrawingOptions- SymbolSize, PixelsPerInch (various colors, etc.).