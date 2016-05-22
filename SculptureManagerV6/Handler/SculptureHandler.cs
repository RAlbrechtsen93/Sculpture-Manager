using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SculptureManagerV6.Model;
//using SculptureManagerV6.Persistency;
using SculptureManagerV6.ViewModel;

namespace SculptureManagerV6.Handler
{
    class SculptureHandler
    {
        public SculptureViewModel SculptureViewModel { get; set; }
        public SculptureHandler(SculptureViewModel sculptureViewModel)
        {
            SculptureViewModel = sculptureViewModel;
        }

        public void CreateSculpture()
        {
            Sculpture sculpture = new Sculpture();
            sculpture.C_SculptureID = SculptureViewModel.NewSculpture.C_SculptureID;
            sculpture.C_Name = SculptureViewModel.NewSculpture.C_Name;
            sculpture.C_Location = SculptureViewModel.NewSculpture.C_Location;

            SculptureViewModel.SculptureCatalogSingleton.Sculptures.Add(sculpture);

            //SculptureViewModel.NewSculpture.C_SculptureID = 0;
            //SculptureViewModel.NewSculpture.C_Name = "";
            //SculptureViewModel.NewSculpture.C_Location = "";
        }

        public void DeleteSculpture()
        {
            int deletesculptureid = SculptureViewModel.NewSculpture.C_SculptureID;

            SculptureViewModel.SculptureCatalogSingleton.Sculptures.Clear();
        }
    }
}
