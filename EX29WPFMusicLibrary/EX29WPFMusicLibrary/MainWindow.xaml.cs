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

namespace EX29WPFMusicLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Playlist playlist { get; set; } = new Playlist("Daniels Playliste");
        List<Playlist> playlists = new List<Playlist>();
        public MainWindow()
        {
            InitializeComponent();
            Title = "Ingen Playliste";
            lbxTracks.ItemsSource = playlist.Tracks;

            lbxPlaylists.ItemsSource = playlists;
        }

        private void btnAddSong_Click(object sender, RoutedEventArgs e)
        {
            if (lbxPlaylists.SelectedItem != null) { 
                playlist = playlists[lbxPlaylists.SelectedIndex];
            }

            if (byte.Parse(tbxMin.Text) <= 60 && byte.Parse(tbxSec.Text) <= 60)
            {
                Track Sang = new Track(tbxArtist.Text, tbxTitle.Text, byte.Parse(tbxMin.Text), byte.Parse(tbxSec.Text));
                playlist.AddTrack(Sang);

                lbxTracks.Items.Refresh();

                lblShortTrack.Content = playlist.FindShortestTrack().ToString();


                FindShortestAllPlaylists();

                lblfejl.Content = "";

                lbxTracks.ItemsSource = playlist.Tracks;

                Title = playlist.Name;
            }

            else
            {
                lblfejl.Content = "Kan max være 60";
            }
            
            
        }

        private void btnRemoveSong_Click(object sender, RoutedEventArgs e)
        {
            if (lbxTracks.SelectedItem != null)
            {
                playlist.RemoveTrack(lbxTracks.SelectedItem as Track);

                lbxTracks.Items.Refresh();

                lblShortTrack.Content = playlist.FindShortestTrack().ToString();
                FindShortestAllPlaylists();
            }

        }

        private void btnNewPlaylist_Click(object sender, RoutedEventArgs e)
        {

            playlist = new Playlist(tbxPlaylistName.Text);
            Name = tbxPlaylistName.Text;

            playlists.Add(playlist);

            lbxPlaylists.Items.Refresh();

            Title = playlist.Name;
        }

        private void btnDeletewPlaylist_Click(object sender, RoutedEventArgs e)
        {
            if (lbxPlaylists.SelectedItem != null)
            {
                playlists.RemoveAt(lbxPlaylists.SelectedIndex);

                lbxPlaylists.Items.Refresh();

                lbxTracks.Items.Refresh();
            }
        }

        private void FindShortestAllPlaylists()
        {
            // kortest i alle playlister:

            Track shortest = playlist.FindShortestTrack();

            foreach (Playlist play in playlists)
            {
                Track mb = playlist.FindShortestTrack();
                if (float.Parse($"{shortest.Min}.{shortest.Sec}") < float.Parse($"{mb.Min}.{mb.Sec}"))
                {
                    shortest = mb;
                }

            }
            lblShortestAllPlaylist.Content = shortest.ToString();
        }
    }
}
