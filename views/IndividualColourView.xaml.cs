using System.Windows;
using System.Windows.Controls;

namespace ColourLab
{
    /// <summary>
    /// Interaction logic for IndividualColourView.xaml
    /// </summary>
    public partial class IndividualColourView : UserControl
    {
        private const int Min = 20;
        private const int Max = 100;
        public static readonly DependencyProperty ColourWidthProperty = DependencyProperty.Register(
            "ColourWidth", typeof (int), typeof (IndividualColourView),new PropertyMetadata(Min));

        public IndividualColourView()
        {
            InitializeComponent();
            ColourWidth = Min;
        }

        public int ColourWidth
        {
            get { return (int) GetValue(ColourWidthProperty); }
            set { SetValue(ColourWidthProperty, value); }
        }
    }
}