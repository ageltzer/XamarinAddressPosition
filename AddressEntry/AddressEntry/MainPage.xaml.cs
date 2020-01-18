﻿using AddressEntry.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AddressEntry
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ReactiveContentPage<MainViewModel>
    {
        public MainPage():base()
        {
            InitializeComponent();
        }
    }
}
