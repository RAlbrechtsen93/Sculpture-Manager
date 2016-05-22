using SculptureManagerV6.Common;
using SculptureManagerV6.Handler;
using SculptureManagerV6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SculptureManagerV6.ViewModel
{
    class SculptureViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));

        }

        public int C_SculptureID { get; set; }
        public string C_Name { get; set; }
        public string C_Location { get; set; }
        public SculptureCatalogSingleton SculptureCatalogSingleton { get; set; }
        public SculptureHandler SculptureHandler { get; set; }
        public ICommand CreateCommand { get; set; }


        public SculptureViewModel()
        {
            SculptureCatalogSingleton = SculptureCatalogSingleton.Instance;
            NewSculpture = new Sculpture();

            SculptureHandler = new Handler.SculptureHandler(this);
            CreateCommand = new RelayCommand(SculptureHandler.CreateSculpture);
            NewSculpture = new Sculpture();


        }

        private Sculpture _newSculpture;
        public Sculpture NewSculpture
        {
            get { return _newSculpture; }
            set { _newSculpture = value; OnPropertyChanged(); }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        

    }
}
