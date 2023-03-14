using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Pivo> _data;
        public MainWindow()
        {
            
            InitializeComponent();
            _data = new ObservableCollection<Pivo>();
            dg_info.ItemsSource = _data;
            Pivo pivko = new Pivo()
            {
                Name = "Балтика 9",
                Percent = 8
            };

            _data.Add(pivko);
        }   
        class Pivo
        {
            public string Name { get; set; }
            public double Percent { get; set; }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            var ga = (e.OriginalSource as Button).DataContext;
            Pivo current = (Pivo) ga;
            _data.Remove(current);
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
