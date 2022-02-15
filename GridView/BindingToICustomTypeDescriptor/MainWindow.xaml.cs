using System;
using System.Windows;

namespace BindingToICustomTypeDescriptor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _rnd;

        public MainWindow()
        {
            _rnd = new Random();
            InitializeComponent();
        }

        private void Addy(object sender, RoutedEventArgs e)
        {
            var model = panel.DataContext as MyViewModel;
            var fields = model.GenerateData();
            model.Data.Add(fields[_rnd.Next(fields.Count-1)]);
        }
    }
}
