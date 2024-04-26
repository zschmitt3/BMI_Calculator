﻿using System.Reflection;

namespace MauiApp2.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;
        private double heightweight;

        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            heightweight = Convert.ToDouble(Weight.Text) / Convert.ToDouble(Height.Text);
            CounterLabel.Text = "Your BMI is " + (heightweight * heightweight * 703);
            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}