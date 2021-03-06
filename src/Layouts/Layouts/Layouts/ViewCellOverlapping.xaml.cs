﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCellOverlapping : ContentPage
    {

        public ViewCellOverlapping()
        {
            InitializeComponent();

            BindingContext = DataFactory.Places;
        }
    }

    public class GreatPlace
    {
        public string Title { get; set; }
        public string Handle { get; set; }
        public int ViewCount { get; set; }
        public string HeroImage { get; set; }
        public string ProfileImage { get; set; }
    }

    public static class DataFactory
    {
        public static IList<GreatPlace> Places { get; private set; }

        static DataFactory()
        {

            Places = new ObservableCollection<GreatPlace>
            {
                new GreatPlace
                {
                    Title = "Fiji Getaway",
                    Handle = "@beachcomber",
                    ViewCount = 2654,
                    HeroImage = "Fiji.jpg",
                    ProfileImage = "Person_1.jpg"
                },
                new GreatPlace
                {
                    Title = "A Hipster day out",
                    Handle = "@handlebar",
                    ViewCount = 124,
                    HeroImage = "Hipster.jpg",
                    ProfileImage = "Person_4.jpg"
                                },
                new GreatPlace
                {
                    Title = "Mediteranian Bliss",
                    Handle = "@greekdude",
                    ViewCount = 562,
                    HeroImage = "greekisland.jpg",
                    ProfileImage = "Person_5.jpg"
                },
                new GreatPlace
                {
                    Title = "Down the slopes",
                    Handle = "@skibunny",
                    ViewCount = 132,
                    HeroImage = "snow.jpg",
                    ProfileImage = "Person_2.jpg"
                                },
                new GreatPlace
                {
                    Title = "Wide open road",
                    Handle = "@vroom",
                    ViewCount = 3221,
                    HeroImage = "combi.jpg",
                    ProfileImage = "Person_3.jpg"
                                },
            };
        }
    }
}