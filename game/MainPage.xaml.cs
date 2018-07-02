using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MyToolkit.Media;
using MyToolkit.Multimedia;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {


            {
                void DelayAction(int millisecond, Action action)
                {
                    var timer = new DispatcherTimer();
                    timer.Tick += delegate

                    {
                        action.Invoke();
                        timer.Stop();
                    };

                    timer.Interval = TimeSpan.FromMilliseconds(500);
                    timer.Start();


                }
                async Task<Uri> GetYoutubeUri(string jItnCGRsMjw)
                {
                    YouTubeUri uri = await YouTube.GetVideoUriAsync(jItnCGRsMjw, YouTubeQuality.Quality1080P);
                    return uri.Uri;
                }
                Uri _videoUri = await GetYoutubeUri("jItnCGRsMjw");
                if (_videoUri != null)
                {
                    player.Source = _videoUri;
                    player.Play();
                }

            }


            }

            private void Button3_Click(object sender, RoutedEventArgs e)
            {

            }
        }
    }

