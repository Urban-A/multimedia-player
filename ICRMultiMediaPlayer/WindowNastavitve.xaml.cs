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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ICRMultiMediaPlayer
{
    /// <summary>
    /// Interaction logic for WindowNastavitve.xaml
    /// </summary>
    public partial class WindowNastavitve : Window
    {
        public WindowNastavitve()
        {
            InitializeComponent();
            /*if (Properties.Settings.Default.Zvrsti == null)
            {
                Properties.Settings.Default.Zvrsti = new System.Collections.Specialized.StringCollection();
            }*/
            zvrstiList.ItemsSource = Properties.Settings.Default.Zvrsti;
        }

        private void zvrstDodajBtn_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Zvrsti.Add(zvrstText.Text);
            Properties.Settings.Default.Save();
            //NotifyPropertyChanged("Zvrsti");
            zvrstText.Clear();
        }

        private void zvrstOdstraniBtn_Click(object sender, RoutedEventArgs e)
        {
            if (zvrstiList.SelectedIndex >= 0)
            {
                Properties.Settings.Default.Zvrsti.RemoveAt(zvrstiList.SelectedIndex);
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Ni izbrane kategorije");
            }
        }
    }
}
