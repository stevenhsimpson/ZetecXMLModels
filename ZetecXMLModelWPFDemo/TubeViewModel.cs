using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Input;

namespace ZetecModelWPFDemo
{
    public enum TubeType { NONE, TUBE, STAY, PLUG };

    public class TubeViewModel : INotifyPropertyChanged
    {
        #region Members
        private int _id;
        private decimal _inletx;
        private decimal _inlety;
        private decimal _outletx;
        private decimal _outlety;
        private double _topPosition;
        private double _leftPosition;
        private String _xlabel;
        private String _ylabel;
        private String _toolTipString;
        private Brush _stroke = Brushes.Gray;
        private Brush _fill = Brushes.Transparent;
        private bool _selected = false;
        private TubeType _type = TubeType.TUBE;
        private decimal _symbolsize;
        private String _symbol;
        private readonly ICommand _selectCommand;
        private readonly ICommand _deselectCommand;
        #endregion

        #region Accessors
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("ID");
            }
        }
        public decimal InletX
        {
            get { return _inletx; }
            set
            {
                _inletx = value;
                NotifyPropertyChanged("InletX");
            }
        }
        public decimal InletY
        {
            get { return _inlety; }
            set
            {
                _inlety = value;
                NotifyPropertyChanged("InletY");
            }
        }
        public decimal OutletX
        {
            get { return _outletx; }
            set
            {
                _outletx = value;
                NotifyPropertyChanged("OutletX");
            }
        }
        public decimal OutletY
        {
            get { return _outlety; }
            set
            {
                _outlety = value;
                NotifyPropertyChanged("OutletY");
            }
        }
        public decimal SymbolSize
        {
            get { return _symbolsize; }
            set
            {
                _symbolsize = value;
                NotifyPropertyChanged("SymbolSize");
            }
        }
        public double TopPosition
        {
            get
            {
                return _topPosition;
            }
            set
            {
                _topPosition = value;
                NotifyPropertyChanged("TopPosition");
            }
        }
        public double LeftPosition
        {
            get
            {
                return _leftPosition;
            }
            set
            {
                _leftPosition = value;
                NotifyPropertyChanged("LeftPosition");
            }
        }
        public String YLabel
        {
            get { return _ylabel; }
            set
            {
                _ylabel = value;
                NotifyPropertyChanged("YLabel");
            }
        }
        public String XLabel
        {
            get { return _xlabel; }
            set
            {
                _xlabel = value;
                NotifyPropertyChanged("XLabel");
            }
        }
        public String ToolTipString
        {
            get { return _toolTipString; }
            set
            {
                _toolTipString = value;
                NotifyPropertyChanged("TooltipString");
            }
        }
        public Brush Stroke
        {
            get { return _stroke; }
            set
            {
                _stroke = value;
                NotifyPropertyChanged("Stroke");
            }
        }
        public Brush Fill
        {
            get { return _fill; }
            set
            {
                _fill = value;
                NotifyPropertyChanged("Fill");
            }
        }
        public bool Selected
        {
            //selection is set...and looks inverted.
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected == true)
                {
                    Stroke = Brushes.SteelBlue;
                    Fill = Brushes.LightSteelBlue;
                    //Console.WriteLine( "Selecting..." + _toolTipString );
                }
                else
                {
                    Stroke = Brushes.Gray;
                    Fill = Brushes.Transparent;
                    //Console.WriteLine( "Deselecting..." + _toolTipString );
                }
                //Console.WriteLine("Notifying Selected Property Changed.");
                NotifyPropertyChanged("Selected");
            }
        }
        public TubeType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case TubeType.NONE:
                        Stroke = Brushes.Transparent;
                        Fill = Brushes.Transparent;
                        break;
                    case TubeType.TUBE:
                        SetToTube();
                        break;
                    case TubeType.PLUG:
                        SetToPlug();
                        break;
                    case TubeType.STAY:
                        SetToStay();
                        break;

                }
                NotifyPropertyChanged("Stroke");
                NotifyPropertyChanged("Fill");
                NotifyPropertyChanged("Type");
            }
        }
        public String Symbol
        {
            get { return _symbol; }
            set
            {
                _symbol = value;
                NotifyPropertyChanged("Symbol");
            }
        }
        #endregion

        #region C'Tor
        public TubeViewModel(ZetecXMLModels.Tube tube)
        {
            _type = TubeType.TUBE;
            _selectCommand = new RelayCommand(SelectTube, true);
            _deselectCommand = new RelayCommand(DeselectTube, true);

            _id = tube.ID;
            _inletx = tube.InletX;
            _inlety = tube.InletY;
            _outletx = tube.OutletX;
            _outlety = tube.OutletY;
            _ylabel = tube.YLabel;
            _xlabel = tube.XLabel;

            _toolTipString = "Y" + tube.YLabel + "X" + tube.XLabel;


        }
        #endregion


        #region Methods
        public void SetToStay()
        {
            Console.WriteLine("Changing " + _toolTipString.ToString() + " to Stay.");
            _type = TubeType.STAY;
            _stroke = Brushes.Transparent;
            _fill = Brushes.Transparent;
        }
        public void SetToPlug()
        {
            _type = TubeType.PLUG;
            _stroke = Brushes.Gray;
            _fill = Brushes.Gray;
            _symbol = "P";
            NotifyPropertyChanged("Symbol");
        }
        public void SetToTube()
        {
            _type = TubeType.TUBE;
            _stroke = Brushes.Gray;
            _fill = Brushes.Transparent;
        }
        #endregion

        #region INotify Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region ICommand

        public ICommand SelectCommand
        {
            get { return _selectCommand; }
        }

        public ICommand DeselectCommand
        {
            get { return _deselectCommand; }
        }

        private void SelectTube()
        {
            if (_type == TubeType.STAY || _type == TubeType.PLUG)
                return;

            if (Selected == false)
            {
                Selected = true;
            }
            else
            {
                Selected = false;
            }
        }
             
            private void DeselectTube()
        {
            TubeView tv = new TubeView(this);
            tv.ShowDialog();
        }
        
        #endregion
    }
}