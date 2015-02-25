using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ZetecModelWPFDemo
{
    public class RelayCommand : ICommand
    {
        private Action _handler;
        public RelayCommand(Action handler)
        {
            _handler = handler;
        }

        public RelayCommand(Action handler, bool Enabled)
        {
            _handler = handler;
            _isEnabled = Enabled;
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (value != _isEnabled)
                {
                    _isEnabled = value;
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _handler();
        }
    }
}


