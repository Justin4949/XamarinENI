using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTweetPage : ContentPage
    {
        public MainTweetPage()
        {
            InitializeComponent();
            this.listViewTweets.ItemsSource = new TwitterService().Tweets;
        }
    }
}