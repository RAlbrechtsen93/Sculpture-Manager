using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SculptureManagerV6.Model
{
    class SculptureCatalogSingleton
    {
        private static SculptureCatalogSingleton instance = new SculptureCatalogSingleton();
        public static SculptureCatalogSingleton Instance
        {
            get { return instance; }
        }

        public ObservableCollection<Sculpture> Sculptures { get; set; }

        public SculptureCatalogSingleton()
        {
            Sculptures = new ObservableCollection<Sculpture>();
            Sculpture s1 = new Sculpture(001, "yndling til hest", "københavn");
            Sculpture s2 = new Sculpture(002, "yndling til hest", "københavn");
            Sculpture s3 = new Sculpture(003, "yndling til hest", "københavn");

            Sculptures.Add(s1);
            Sculptures.Add(s2);
            Sculptures.Add(s3);
        }

        public void Add (int SculptureID, string Name, string Location)
        {
            Sculptures.Add(new Sculpture(SculptureID, Name, Location));
        }

    }
}
