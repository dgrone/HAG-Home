using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAG_HomeLights.Models
{
    public class HAGProject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _Name = "";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        string _Description = "";
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        DateTime _Created = DateTime.MaxValue;
        public DateTime Created
        {
            get
            {
                return _Created;
            }
            set
            {
                _Created = value;
                OnPropertyChanged("Created");
            }
        }

        public string CreatedString
        {
            get { return Created.ToString("d"); }
        }
        public string UpdatedString
        {
            get { return Updated.ToString("d"); }
        }

        DateTime _Updated = DateTime.MaxValue;
        public DateTime Updated
        {
            get
            {
                return _Updated;
            }
            set
            {
                _Updated = value;
                OnPropertyChanged("Updated");
            }
        }


        int _InstalledLights = 0;
        public int InstalledLights
        {
            get
            {
                return _InstalledLights;
            }
            set
            {
                _InstalledLights = value;
                OnPropertyChanged("InstalledLights");
            }
        }

        int _Groups = 0;
        public int Groups
        {
            get
            {
                return _Groups;
            }
            set
            {
                _Groups = value;
                OnPropertyChanged("Groups");
            }
        }

        int _HAGFiles = 0;
        public int HAGFiles
        {
            get
            {
                return _HAGFiles;
            }
            set
            {
                _HAGFiles = value;
                OnPropertyChanged("HAGFiles");
            }
        }

        protected void OnPropertyChanged(string aName)
        {
            PropertyChangedEventHandler lHandler = PropertyChanged;
            if (lHandler != null)
                lHandler(this, new PropertyChangedEventArgs(aName));
        }
    }
}
