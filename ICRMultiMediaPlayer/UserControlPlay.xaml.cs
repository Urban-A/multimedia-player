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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ICRMultiMediaPlayer
{
    /// <summary>
    /// Interaction logic for UserControlPlay.xaml
    /// </summary>
    /// 
    public delegate void OutsideDelegate();
    public partial class UserControlPlay : UserControl, INotifyPropertyChanged
    {

        private OutsideDelegate toggle;
        private OutsideDelegate prevPl;
        private OutsideDelegate nextPl;

        public OutsideDelegate Toggle { get => toggle; set => toggle = value; }
        public OutsideDelegate PrevPl { get => prevPl; set => prevPl = value; }
        public OutsideDelegate NextPl { get => nextPl; set => nextPl = value; }
        

        private ObservableCollection <MainWindow.MultiMedia> mediaList;
        private MainWindow.MultiMedia playedMedia;
        private MediaElement mediaPlayer;
        private bool isPlaying = false;

        public ObservableCollection<MainWindow.MultiMedia> MediaList { get => mediaList; set => mediaList = value; }
        public MainWindow.MultiMedia PlayedMedia { get => playedMedia; set => playedMedia = value; }
        public MediaElement MediaPlayer { get => mediaPlayer; set => mediaPlayer = value; }
        public bool IsPlaying { get => isPlaying; set
            {
                isPlaying = value;
                NotifyPropertyChanged("IsPlaying");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        public UserControlPlay()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SelectNext()
        {
            bool changed = false;
            if (playedMedia != null)
            {
                int index = MediaList.IndexOf(playedMedia) + 1;
                if (index < MediaList.Count && index > 0)
                {
                    playedMedia.Predvajan = false;
                    playedMedia = MediaList.ElementAt(index);
                    playedMedia.Predvajan = true;
                    changed = true;
                }

            }
            else if (MediaList.Count > 0)
            {
                playedMedia = MediaList.ElementAt(0);
                playedMedia.Predvajan = true;
                changed = true;
            }
            if (changed)
            {
                mediaPlayer.Source = new Uri(playedMedia.Pot);
                PlayMedia();
            }
            
        }

        private void SelectPrev()
        {
            bool changed = false;
            if (playedMedia != null)
            {
                int index = MediaList.IndexOf(playedMedia) - 1;
                if (index >= 0)
                {
                    playedMedia.Predvajan = false;
                    playedMedia = MediaList.ElementAt(index);
                    playedMedia.Predvajan = true;
                    changed = true;
                }

            }
            else if (MediaList.Count > 0)
            {
                playedMedia = MediaList.ElementAt(0);
                playedMedia.Predvajan = true;
                changed = true;
            }
            if (changed)
            {
                mediaPlayer.Source = new Uri(playedMedia.Pot);
                PlayMedia();
            }
        }


        private void pListBtn_Click(object sender, RoutedEventArgs e)
        {
            Toggle.Invoke();
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            //PrevPl.Invoke();
            SelectPrev();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            //NextPl.Invoke();
            SelectNext();
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.IsLoaded)
            {
                mediaPlayer.Stop();
                IsPlaying = false;
            }
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.CanPause&&isPlaying)
            {
                mediaPlayer.Pause();
                IsPlaying = false;
            }else if (mediaPlayer.IsLoaded)
            {
                mediaPlayer.Play();
                IsPlaying = true;
            }
        }

        public void PlayMedia()
        {
            IsPlaying = true;
            mediaPlayer.Play();
        }
    }
}
