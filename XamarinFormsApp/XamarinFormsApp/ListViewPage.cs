// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListViewPage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using System.Diagnostics;
    using Xamarin.Forms;

    public class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            this.Padding = new Thickness(0, Device.RuntimePlatform == Device.iOS ? 20 : 0, 0, 0);

            ////var cellTemplate = new DataTemplate(typeof(TextCell));
            ////cellTemplate.SetBinding(TextCell.TextProperty, new Binding(nameof(Course.Title)));
            ////cellTemplate.SetBinding(TextCell.DetailProperty, new Binding(nameof(Course.Author)));
            ////cellTemplate.SetValue(TextCell.TextColorProperty, Color.Red);
            ////cellTemplate.SetValue(TextCell.DetailColorProperty, Color.Yellow);

            var listView = new ListView();
            listView.ItemsSource = Course.All;
            listView.ItemSelected += (s, e) => Debug.WriteLine("Selected: " + e.SelectedItem);
            listView.ItemTemplate = new DataTemplate(typeof(CourseCell));

            this.Content = listView;
        }
    }
}