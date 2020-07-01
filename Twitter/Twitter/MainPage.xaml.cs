using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Twitter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Connection is clicked");
            String identifierStr = this.identifier.Text;
            String passwordStr = this.password.Text;
            Boolean isRemember = this.remember.IsToggled;

            this.error.IsVisible = false;
            this.form.IsVisible = false;
            this.tweets.IsVisible = true;
            this.buttonsback.IsVisible = true;

            if (String.IsNullOrEmpty(identifierStr) || identifierStr.Length < 3)
            {
                this.form.IsVisible = true;
                this.tweets.IsVisible = false;
                this.buttonsback.IsVisible = false;

                this.error.Text = "Veuillez entrer un identifiant d'au moins 3 caractères";
                this.error.IsVisible = true;
                return;
            }
            if (String.IsNullOrEmpty(passwordStr) || passwordStr.Length < 6)
            {
                this.form.IsVisible = true;
                this.tweets.IsVisible = false;
                this.buttonsback.IsVisible = false;

                this.error.Text = "Veuillez entrer un mot de passe d'au moins 6 caractères";
                this.error.IsVisible = true;
                return;
            }
        }
    }
}
