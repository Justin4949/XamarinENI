﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Twitter.Entities;
using Twitter.Services;
using Twitter.Models;

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
            new LoginForm(this.login, this.password, this.isRemind, this.errorLabel, this.btnConnection, this.Navigation);
        }

        protected override void OnAppearing()
        {
            this.login.Text = "";
            this.password.Text = "";
            this.isRemind.IsToggled = false;
            base.OnAppearing();
        }
    }
}
