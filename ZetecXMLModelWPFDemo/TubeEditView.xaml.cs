using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZetecModelWPFDemo
{
    /// <summary>
    /// Interaction logic for TubeView.xaml
    /// </summary>
    public partial class TubeEditView : Window
    {
        private readonly TubeViewModel _tvm;

        public TubeEditView(TubeViewModel tvm)
        {
            InitializeComponent();
            _tvm = tvm;
            this.DataContext = _tvm;
            //if ( _tvm.CloseAction == null)
            //     _tvm.CloseAction = new Action(() => this.Close());<-- not working for some reason?
            TubeTypeCombo.ItemsSource = Enum.GetValues(typeof(TubeType));

        }


        public TubeViewModel TubeSheet() { return _tvm; }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); //closes view somehow?
        }
    }
}
