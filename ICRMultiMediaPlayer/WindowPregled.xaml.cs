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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace ICRMultiMediaPlayer
{
    /// <summary>
    /// Interaction logic for WindowPregled.xaml
    /// </summary>
    public partial class WindowPregled : Window
    {
        MainWindow.MultiMedia multiMedia;
        public string slikaPot;
        public WindowPregled(MainWindow.MultiMedia multiMedia)
        {
            this.multiMedia = multiMedia;
            this.DataContext = this.multiMedia;
            slikaPot = multiMedia.slikaPot;
            InitializeComponent();
            this.Title = System.IO.Path.GetFileName(this.multiMedia.Pot);
        }

        private void slikaSelect_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Slika (*.png; *jpg;)|*.png;*.jpg|Gif (*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == true)
            {
                pregledSlika.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
                slikaPot = openFileDialog.FileName;
            }
            
        }

        private void shraniMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            //pregledSlika.GetBindingExpression(Image.SourceProperty).UpdateSource();
            multiMedia.Slika = (BitmapImage) pregledSlika.Source;
            multiMedia.slikaPot = slikaPot;
            pregledOcena.GetBindingExpression(Slider.ValueProperty).UpdateSource();
            pregledOpis.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            pregledZvrst.GetBindingExpression(ComboBox.SelectedItemProperty).UpdateSource();
            pregledDatum.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
            this.Close();
        }

        private void zavrniMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
