using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using ColourLab.viewmodels;

namespace ColourLab
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            var viewModels = new List<ColourCollectionViewModel>();
            var viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(25, 35, 43),
                                Color.FromRgb(48, 68, 85),
                                Color.FromRgb(210, 200, 162),
                                Color.FromRgb(217, 100, 83),
                                Color.FromRgb(237,130,103)
                            }, "cocoa dream"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(80,120,28),
                                Color.FromRgb(156,173,28),
                                Color.FromRgb(234,247,230),
                                Color.FromRgb(64,165,222),
                                Color.FromRgb(11,81,145)
                            }, "ruby love story"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(25, 35, 43),
                                Color.FromRgb(48, 68, 85),
                                Color.FromRgb(210, 200, 162),
                                Color.FromRgb(217, 100, 83),
                                Color.FromRgb(247, 140, 123)

                            }, "cocoa dream"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(232, 48, 0 ),
                                Color.FromRgb(255,0,127),
                                Color.FromRgb(127,0,255),
                                Color.FromRgb(0,127,255),
                                Color.FromRgb(50,187,255)
                            }, "#mello 2010"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(25, 35, 43),
                                Color.FromRgb(48, 68, 85),
                                Color.FromRgb(210, 200, 162),
                                Color.FromRgb(217, 100, 83),
                                Color.FromRgb(247, 140, 123)

                            }, "cocoa dream"));
            viewModels.Add(viewModel);
            viewModel =
     new ColourCollectionViewModel(
         new ColourCollectionModel(
             new List<Color>
                            {
                                Color.FromRgb(80,120,28),
                                Color.FromRgb(156,173,28),
                                Color.FromRgb(234,247,230),
                                Color.FromRgb(64,165,222),
                                Color.FromRgb(11,81,145)
                            }, "ruby love story"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(25, 35, 43),
                                Color.FromRgb(48, 68, 85),
                                Color.FromRgb(210, 200, 162),
                                Color.FromRgb(217, 100, 83),
                                Color.FromRgb(247, 140, 123)

                            }, "cocoa dream"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(232, 48, 0 ),
                                Color.FromRgb(255,0,127),
                                Color.FromRgb(127,0,255),
                                Color.FromRgb(0,127,255),
                                Color.FromRgb(50,187,255)
                            }, "#mello 2010"));
            viewModels.Add(viewModel);
            viewModel =
                new ColourCollectionViewModel(
                    new ColourCollectionModel(
                        new List<Color>
                            {
                                Color.FromRgb(25, 35, 43),
                                Color.FromRgb(48, 68, 85),
                                Color.FromRgb(210, 200, 162),
                                Color.FromRgb(217, 100, 83),
                                Color.FromRgb(247, 140, 123)

                            }, "cocoa dream"));
            viewModels.Add(viewModel);


            DataContext = viewModels;
        }
    }
}