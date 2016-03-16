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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace multiplePagesUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //peli on pelattu ja Score on tiedossa
            int score = 100;
            //sijoitetaan pelin tulos pääohjelmassa olevaan Score ominaisuuteen
            (App.Current as App).Score = score;
            // get root frame (which show pages) Navigoidaan takaisin pääsivulle 
            Frame rootFrame = Window.Current.Content as Frame;
            // did we get it correctly
            if (rootFrame == null) return;
            // navigate back if possible 
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }
        //sivulle on tultu
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string)
            {
               
                GreetingTextBlock.Text = "Hei sinä ihana, " + e.Parameter;
            }
          
            base.OnNavigatedTo(e);
        }
    }
}
