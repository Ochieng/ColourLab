using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

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

        private void StackPanel_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //var animation = new Int32Animation(ColourWidth, Max, TimeSpan.FromSeconds(0.2)) {AccelerationRatio = 0.5};
            //BeginAnimation(ColourWidthProperty, animation);
        }

        private void StackPanel_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //var animation = new Int32Animation(ColourWidth, Min, TimeSpan.FromSeconds(0.2)) {AccelerationRatio = 0.5};
            //BeginAnimation(ColourWidthProperty, animation);
        }
    }
}