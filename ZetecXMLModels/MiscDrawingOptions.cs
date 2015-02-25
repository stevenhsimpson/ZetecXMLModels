using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetecXMLModels
{
    public class MiscDrawingOptions
    {
        public System.Drawing.Color TextColor { get; set; }
        public System.Drawing.Color GridColor { get; set; }
        public System.Drawing.Color GroupOutlineColor { get; set; }
        public System.Drawing.Color BackgroundColor { get; set; }
        public System.Drawing.Color ForegroundColor { get; set; }
        public int GridScale { get; set; }
        public int SymbolSize { get; set; }
        public decimal PixelsPerInch { get; set; }
    }
     
}
