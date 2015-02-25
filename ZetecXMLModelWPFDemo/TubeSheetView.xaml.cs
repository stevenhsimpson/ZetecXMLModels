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
    /// Interaction logic for TubeSheetView.xaml
    /// </summary>
    public partial class TubeSheetView : Window
    {
        private readonly TubeSheetModelView _tsmv;

        public TubeSheetView(TubeSheetModelView tsmv)
        {
            InitializeComponent();
            _tsmv = tsmv;
            this.DataContext = _tsmv;
        }


        public TubeSheetModelView TubeSheet(){  return _tsmv; }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) //this callback didn't work?
        {
            Console.WriteLine("Hello World!");
        }



    }
}
