using System;
using System.Collections.Generic;
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

namespace ObjectOrientedDesignProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Examples_Visual_C__Click(object sender, RoutedEventArgs e)
        {
            ExamplesVisualCSharp ExamplesVisualCSharpObject = new ExamplesVisualCSharp();
            ExamplesVisualCSharpObject.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Algorithms AlgorithmsObject = new Algorithms();
            AlgorithmsObject.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AlgorithmsC__ AlgorithmsC__Object = new AlgorithmsC__();
            AlgorithmsC__Object.Show();
        }
    }
}
