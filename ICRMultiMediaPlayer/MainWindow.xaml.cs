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
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Xml;
using System.IO;

namespace ICRMultiMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Playlist seznam;
        MultiMedia playedMedia;
        UserControlPlay usr;

        public struct MultiMediaStruct
        {

            public string pot;
            //[System.Xml.Serialization.XmlElement(IsNullable = true)]
            public string slika;
            public string zvrst;
            //public Nullable<System.DateTime> datumIzdaje;
            public DateTime datumIzdaje;
            //public Nullable<float> ocena;
            public float ocena;
            //[System.Xml.Serialization.XmlElement(IsNullable = true)]
            public string opis;
        }

        public struct PlaylistStruct
        {
            public string naslov;
            public List<MultiMediaStruct> mediaList;
        }

        public class MultiMedia : INotifyPropertyChanged
        {
            
            public string Pot { get { return pot; } set {
                    pot = value;
                    NotifyPropertyChanged("Pot");
                } 
            }
            public BitmapImage Slika { get => slika; set{
                    slika = value;
                    NotifyPropertyChanged("Slika");
                }
            }
            public string Zvrst { get => zvrst; set{
                    zvrst = value;
                    NotifyPropertyChanged("Zvrst");
                }
            }
            public DateTime DatumIzdaje { get => datumIzdaje; set
                {
                    datumIzdaje = value;
                    NotifyPropertyChanged("DatumIzdaje");
                }
            }
            public float Ocena { get => ocena; set{
                    ocena = value;
                    NotifyPropertyChanged("Ocena");
                }
            }
            public string Opis { get => opis; set{
                    opis = value;
                    NotifyPropertyChanged("Opis");
                }
            }
            public bool Predvajan
            {
                get => predvajan; set
                {
                    predvajan = value;
                    NotifyPropertyChanged("Predvajan");
                }
            }

            public string pot;
            private BitmapImage slika;
            private string zvrst;
            private DateTime datumIzdaje;
            private float ocena;
            private string opis;
            private bool predvajan;
            public string slikaPot;

            public MultiMedia(string pot)
            {
                this.pot = pot;
                datumIzdaje = DateTime.Now;
                predvajan = false;
                zvrst = "/";
            }

            public MultiMedia()
            {
                datumIzdaje = DateTime.Now;
                predvajan = false;
                zvrst = "/";
            }

            public MultiMedia(MultiMediaStruct mediaStruct)
            {
                pot = mediaStruct.pot;
                zvrst = mediaStruct.zvrst;
                datumIzdaje = mediaStruct.datumIzdaje;
                ocena = mediaStruct.ocena;
                opis = mediaStruct.opis;
                predvajan = false;

                if (File.Exists(mediaStruct.slika))
                {
                    slikaPot = mediaStruct.slika;
                    slika = new BitmapImage(new Uri(slikaPot, UriKind.Absolute));
                }
            }

            //public string naslov;
            //public int dolžina;

            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged(string info)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(info));
                }
            }

            public MultiMediaStruct MakeStruct()
            {
                MultiMediaStruct copyStruct = new MultiMediaStruct();
                copyStruct.ocena = ocena;
                copyStruct.opis = opis;
                copyStruct.pot = pot;
                copyStruct.slika = slikaPot;
                copyStruct.zvrst = zvrst;
                copyStruct.datumIzdaje = datumIzdaje;
                return copyStruct;
            }

            public override string ToString()
            {
                return pot;
            }
            
        }

        public class Playlist //: INotifyPropertyChanged
        {
            string naslov;
            ObservableCollection<MultiMedia> mediaList;

            public Playlist(){}

            public Playlist(string naslov)
            {
                this.Naslov = naslov;
                mediaList = new ObservableCollection<MultiMedia>();
            }

            public Playlist(string naslov, ObservableCollection<MultiMedia> mediaList) : this(naslov)
            {
                this.mediaList = mediaList;
            }

            public string Naslov { get => naslov; set => naslov = value; }
            public ObservableCollection<MultiMedia> MediaList { get => mediaList; 
                set
                {
                    mediaList = value;
                    //NotifyPropertyChanged("MediaList");
                } 
            }

            public void AddMedia(MultiMedia media)
            {
                mediaList.Add(media);
            }

            public void RemoveMedia(int index)
            {
                mediaList.RemoveAt(index);
            }

            /*public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged(string info)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(info));
                }
            }*/

            public PlaylistStruct MakeStruct()
            {
                PlaylistStruct copyStruct = new PlaylistStruct();
                copyStruct.naslov = naslov;
                copyStruct.mediaList = new List<MultiMediaStruct>();
                foreach(MultiMedia media in mediaList)
                {
                    copyStruct.mediaList.Add(media.MakeStruct());
                }
                return copyStruct;
            }

            public void Import(PlaylistStruct plistStruct)
            {
                this.Naslov = plistStruct.naslov;
                mediaList.Clear();
                foreach (MultiMediaStruct media in plistStruct.mediaList)
                {
                    mediaList.Add(new MultiMedia(media));
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            if (playlist.Items.Count == 0 || playlist.SelectedIndex < 0)
            {
                odstraniBtn.IsEnabled = false;
                urediBtn.IsEnabled = false;
            }

            ObservableCollection<MultiMedia> mediaList1;
            mediaList1 = new ObservableCollection<MultiMedia>();
            

            seznam = new Playlist("seznam", mediaList1);

            //seznam.AddMedia(new MultiMedia(@"D:\Documents\Cool video.mp4"));

            playlist.ItemsSource = mediaList1;
            //playlist.ItemsSource.OfType


        }


        private void izhodBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();   
        }

        private void dodajBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video (*.mp4; *mov)|*.mp4;*.mov|Audio (*.mp3;*.wav)|*.mp3;*.wav";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    seznam.AddMedia(new MultiMedia(filename));
                }
            } 
            //seznam.AddMedia(new MultiMedia(@"D:\Documents\Cool video.mp4"));
        }


        private void playlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(playlist.IsLoaded && playlist.SelectedIndex >= 0)
            {
                odstraniBtn.IsEnabled = true;
                urediBtn.IsEnabled = true;
            }
        }

        private void odstraniBtn_Click(object sender, RoutedEventArgs e)
        {
            int tempIndex = playlist.SelectedIndex;
            if (seznam.MediaList.ElementAt(tempIndex).Predvajan)
                usr.PlayedMedia = playedMedia = null;
            seznam.RemoveMedia(playlist.SelectedIndex);
            if (playlist.Items.Count > 0)
            {
                if (playlist.Items.Count >= tempIndex+1)
                {
                    playlist.SelectedIndex = tempIndex;
                }
                else
                {
                    playlist.SelectedIndex = tempIndex - 1;
                }
            }
            else
            {
                odstraniBtn.IsEnabled = false;
                urediBtn.IsEnabled = false;
            }
        }

        private void playlist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (playedMedia != null)
            {
                playedMedia.Predvajan = false;
            }
            if(usr.PlayedMedia != null)
            {
                usr.PlayedMedia.Predvajan = false;
            }
            playedMedia = seznam.MediaList.ElementAt(playlist.SelectedIndex);
            usr.PlayedMedia = playedMedia;
            playedMedia.Predvajan = true;
            mediaPlayer.Source = new Uri(playedMedia.Pot);
            usr.PlayMedia();
            //MessageBox.Show(System.IO.Path.GetFileName(seznam.MediaList.ElementAt(playlist.SelectedIndex).ToString()));
        }

        private void nastavitveBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowNastavitve windowNastavitve = new WindowNastavitve();
            if(windowNastavitve.ShowDialog() == true)
            {

            }
        }

        private void urediBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowPregled windowPregled = new WindowPregled(seznam.MediaList[playlist.SelectedIndex]);
            if (windowPregled.ShowDialog() == true)
            {

            }
        }

        private void UvoziBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                //seznam.Naslov = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                //PlaylistStruct seznamStruct = new PlaylistStruct(); //seznam.MakeStruct();

                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(PlaylistStruct));
                var xmlString = File.ReadAllText(openFileDialog.FileName);

                using (TextReader textReader = new StringReader(xmlString))
                {
                    PlaylistStruct seznamStruct = (PlaylistStruct)xmlSerializer.Deserialize(textReader);
                    seznam.Import(seznamStruct);
                    usr.PlayedMedia = playedMedia  = null;
                }
            }
        }

        private void IzvoziBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML (*.xml)|*.xml";
            saveFileDialog.FileName = seznam.Naslov;
            if (saveFileDialog.ShowDialog() == true)
            {
                seznam.Naslov = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                PlaylistStruct seznamStruct = seznam.MakeStruct();

                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(PlaylistStruct));
                var xmlString = "";
                using (var stringWriter = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(stringWriter))
                    {
                        xmlSerializer.Serialize(writer, seznamStruct);
                        xmlString = stringWriter.ToString();
                    }
                }
                File.WriteAllText(saveFileDialog.FileName, xmlString);
            }
        }

        private void TogglePlaylist()
        {
            if (playlist.Visibility == Visibility.Visible)
            {
                playlist.Visibility = Visibility.Collapsed;
            }
            else
            {
                playlist.Visibility = Visibility.Visible;
            }
        }

        private void SelectNext()
        {
            bool changed = false;
            if (playedMedia != null)
            {
                int index = seznam.MediaList.IndexOf(playedMedia) + 1;
                if (index < seznam.MediaList.Count && index > 0)
                {
                    playedMedia.Predvajan = false;
                    playedMedia = seznam.MediaList.ElementAt(index);
                    playedMedia.Predvajan = true;
                    changed = true;
                }

            }
            else if (seznam.MediaList.Count > 0)
            {
                playedMedia = seznam.MediaList.ElementAt(0);
                playedMedia.Predvajan = true;
                changed = true;
            }
            if (changed)
            {
                mediaPlayer.Source = new Uri(playedMedia.Pot);
                usr.PlayMedia();
            }

        }

        private void SelectPrev()
        {
            bool changed = false;
            if (playedMedia != null)
            {
                int index = seznam.MediaList.IndexOf(playedMedia) - 1;
                if (index >= 0)
                {
                    playedMedia.Predvajan = false;
                    playedMedia = seznam.MediaList.ElementAt(index);
                    playedMedia.Predvajan = true;
                    changed = true;
                }

            }
            else if (seznam.MediaList.Count > 0)
            {
                playedMedia = seznam.MediaList.ElementAt(0);
                playedMedia.Predvajan = true;
                changed = true;
            }
            if (changed)
            {
                mediaPlayer.Source = new Uri(playedMedia.Pot);
                usr.PlayMedia();
            }
        }

        private void playControls_Loaded(object sender, RoutedEventArgs e)
        {
            usr = (UserControlPlay) e.Source;
            usr.MediaList = seznam.MediaList;
            usr.PlayedMedia = playedMedia;
            usr.MediaPlayer = mediaPlayer;
        }
    }
}
