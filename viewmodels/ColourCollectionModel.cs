using System.Collections.Generic;
using System.Windows.Media;

namespace ColourLab.viewmodels
{
    public class ColourCollectionModel
    {
        public List<Color> Colours { get; set; }
        public string Description { get; set; }

        public ColourCollectionModel(List<Color> colours, string description)
        {
            Colours = colours;
            Description = description;
        }
    }
}


