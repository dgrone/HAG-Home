using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HAG_HomeLights.Models
{
    public class LampInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string aName)
        {
            PropertyChangedEventHandler lHandler = PropertyChanged;
            if (lHandler != null)
                lHandler(this, new PropertyChangedEventArgs(aName));
        }

        public Image? _Image = null;
        public Image? Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
                OnPropertyChanged("Image");
            }

        }

        public string _Group = "";
        public string Group
        {
            get
            {
                return _Group;
            }
            set
            {
                _Group = value;
                OnPropertyChanged("Group");
            }

        }

        public Point _Point;
        public Point Point
        {
            get
            {
                return _Point;
            }
            set
            {
                _Point = value;
                OnPropertyChanged("Point");
            }

        }

        public int _Width;
        public int Width
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
                OnPropertyChanged("Width");
            }

        }

    }

}