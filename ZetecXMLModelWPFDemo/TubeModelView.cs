using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Input;

namespace ZetecModelWPFDemo 
{
    public enum TubeType { TUBE, STAY, PLUG };

    public class TubeModelView : INotifyPropertyChanged
    {
        #region Members
        private int _id;
        private decimal _inletx;
        private decimal _inlety;
        private double _topPosition;
        private double _leftPosition;
        private String _toolTipString;
        private Brush _stroke = Brushes.Gray;
        private Brush _fill = Brushes.Transparent;
        private bool _selected=false;
        private TubeType _type = TubeType.TUBE;
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
            set { 
                    _inletx=value;
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
        public decimal SymbolSize { get; set; }
        public double TopPosition { get; set; }
        public double LeftPosition { get; set; }
        public String ToolTipString 
        {
            get { return _toolTipString; }
            set
            {
                _toolTipString=value;
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
                    Stroke = Brushes.LightGray;
                    Fill = Brushes.Gray;
                }
                else
                {
                    Stroke = Brushes.Gray;
                    Fill = Brushes.Transparent;
                }
                NotifyPropertyChanged("Selected");
            }
        }
        #endregion

        #region C'Tor
        public TubeModelView()
        {
            _selectCommand = new RelayCommand(SelectTube, true);
        }
#endregion

        #region Methods
        public void SetToStay()
        {
            _type = TubeType.STAY;
            _stroke = Brushes.Transparent;
            _fill = Brushes.Transparent;
        }
        public void SetToPlug()
        {
            _type = TubeType.PLUG;
            _stroke = Brushes.Gray;
            _fill = Brushes.Gray;
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
        private readonly ICommand _selectCommand;
        public ICommand SelectCommand
        {
            get { return _selectCommand; }
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
            //Console.WriteLine("{0} is {1}", _toolTipString, _selected.ToString());
        }
        #endregion
    }
}
