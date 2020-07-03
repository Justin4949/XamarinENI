using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Twitter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewHeader : ContentView
    {
        public ViewHeader()
        {
            InitializeComponent();
        }
    }
}