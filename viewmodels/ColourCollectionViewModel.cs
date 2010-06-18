using System.Collections.ObjectModel;
using System.Windows.Media;

namespace ColourLab.viewmodels
{
    public class ColourCollectionViewModel
    {
        private readonly ColourCollectionModel _collectionModel;

        private ObservableCollection<Color> _colours;
        public ObservableCollection<Color> Colours
        {
            get { return _colours ?? (_colours = new ObservableCollection<Color>(_collectionModel.Colours)); }
        }

        public string Description
        {
            get { return _collectionModel.Description; }
            set { _collectionModel.Description = value; }
        }

        public ColourCollectionViewModel(ColourCollectionModel collectionModel)
        {
            _collectionModel = collectionModel;
        }
    }
}