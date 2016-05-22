using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SculptureManagerV6.Model
{
    class Sculpture
    {
        public int C_SculptureID { get; set; }
        public string C_Name { get; set; }
        public string C_Location { get; set; }

        public Sculpture()
        {

        }
        public Sculpture(int SculptureID, string Name, string Location)
        {
            C_SculptureID = SculptureID;
            C_Name = Name;
            C_Location = Location;
        }

        public override string ToString()
        {
            return string.Format("SculptureID{0}, Name{1}, Location{2}", C_SculptureID, C_Name, C_Location);
        }
    }
}
